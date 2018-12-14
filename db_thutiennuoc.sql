CREATE DATABASE db_thutiennuoc
DROP DATABASE db_thutiennuoc

GO
CREATE TABLE tbl_nhanvien
(
pk_manv int identity not null primary key,
tennv nvarchar (30) not null,
ngaysinh date,
diachi nvarchar (50),
sdt nchar (11)
)
drop table tbl_congto
CREATE TABLE tbl_khachhang
(
pk_makh int identity not null primary key,
tenkh nvarchar(30),
ngaysinh date,
gioitinh nvarchar(3),
diachi nvarchar (30),
sdt nchar (12),
socmnd nchar (12),
maloaikh int)
GO
CREATE TABLE tbl_hoadon	
(
pk_mahoadon int identity not null primary key,
fk_makh int,
chisomoi int,
chisocu int,
fk_manv int,
ngaylap date,

)
GO


CREATE TABLE tbl_loaikh
(
pk_maloaikh int identity not null primary key,
tenloaikh nvarchar (50),
dongia int,
dongia2 int,
dongia3 int,
)

ALTER TABLE tbl_hoadon
ADD CONSTRAINT KH_HD FOREIGN KEY (fk_makh) REFERENCES tbl_khachhang(pk_makh)
ALTER TABLE tbl_hoadon
ADD CONSTRAINT NV_HD FOREIGN KEY (fk_manv) REFERENCES tbl_nhanvien(pk_manv)
ALTER TABLE tbl_congto
ADD CONSTRAINT KH_CT FOREIGN KEY (fk_makh) REFERENCES tbl_khachhang(pk_makh)
ALTER TABLE tbl_khachhang
ADD CONSTRAINT loaiKH FOREIGN KEY (maloaikh) REFERENCES tbl_loaikh(pk_maloaikh)

----------------------------------------------1.Bảng khách hàng-------------------------------
------------------Hiện
--CONVERT(nvarchar(11),ngaysinh,103) as [Ngày sinh] 
drop proc sp_HienKH
create proc sp_HienKH 
as
select pk_makh as[Mã khách hàng], tenkh as [Họ Tên],CONVERT(nvarchar(11),ngaysinh,101) as [Ngày sinh] , gioitinh as [Giới tính],diachi as [Địa chỉ],sdt as [Số ĐT],socmnd as [Số CMND],tenloaikh as [Loại KH] 
from tbl_khachhang ,tbl_loaikh
where tbl_khachhang.maloaikh = tbl_loaikh.pk_maloaikh

-------------------Thêm
create proc sp_ThemKH
@tenkh nvarchar(30),@ngaysinh date,@gioitinh nvarchar(3),@diachi nvarchar(50),@sdt nchar(11),@socmnd nchar(12),@maloaikh int
as
insert into tbl_khachhang values (@tenkh,@ngaysinh,@gioitinh,@diachi,@sdt,@socmnd,@maloaikh)
------------------- Xóa
create proc sp_XoaKH
@pk_makh int
as
delete from tbl_khachhang
where pk_makh = @pk_makh 
--------------------Sửa
create proc sp_CapNhat 
@pk_makh int ,@tenkh nvarchar(30),@ngaysinh date,@gioitinh nvarchar(3),@diachi nvarchar(50),@sdt nchar(11),@socmnd nchar(12),@maloaikh nvarchar(5)
as
update tbl_khachhang 
set tenkh = @tenkh,
	ngaysinh = @ngaysinh,
	gioitinh = @gioitinh,
	diachi = @diachi,
	sdt = @sdt,
	socmnd = @socmnd,
	maloaikh = @maloaikh
where pk_makh = @pk_makh

----------------------------------------------------------------------------------------------------
-----------------------------------2.Bảng loại khách hàng--------------------------------------------
-------------Hiện
drop proc sp_HienLoaiKH
create proc sp_HienLoaiKH
as
select pk_maloaikh as [Mã số],tenloaikh as[Tên loại],dongia as[Giá mức 1],dongia2 as [Giá mức 2],dongia3 as [Giá mức 3]
from tbl_loaikh

create proc showcbb
as
select tenloaikh, pk_maloaikh from tbl_loaikh
--------------Thêm
create proc sp_ThemLoaiKH
@tenloaikh nvarchar(30),@dongia int, @dongia2 int,@dongia3 int
as
INSERT INTO tbl_loaikh VALUES (@tenloaikh,@dongia,@dongia2,@dongia3)
--------------Sửa
create proc sp_CapnhatLKH 
@pk_maloaikh nvarchar(5), @tenloaikh nvarchar(30), @dongia int,@dongia2 int,@dongia3 int
as
update tbl_loaikh
set tenloaikh = @tenloaikh,
	dongia = @dongia,
	dongia2=@dongia2,
	dongia3=@dongia3
where pk_maloaikh = @pk_maloaikh
------Xóa
create proc sp_XoaLKH 
@pk_maloaikh int
as
delete from tbl_loaikh
where pk_maloaikh = @pk_maloaikh

----Linhtinh
drop proc f3
create proc f3
as
select tenloaikh as [Tên loại],COUNT(maloaikh) as [Số người dùng]
from tbl_loaikh inner join tbl_khachhang
on tbl_loaikh.pk_maloaikh = tbl_khachhang.maloaikh
group by tenloaikh
---------------------------------------------3.Bảng nhân viên-------------------------------
----------Hiện
create proc sp_Hiennv
as
select pk_manv as[Mã nhân viên],tennv as [Tên nhân viên],CONVERT(nvarchar(11),ngaysinh,101) as[Ngày sinh],diachi as [Địa chỉ],sdt as [Liên lạc]
from tbl_nhanvien
-----------Thêm
create proc sp_Themnv
@tennv nvarchar(30),@ngaysinh date,@diachi nvarchar(50),@sdt nchar(11)
as
insert into tbl_nhanvien values (@tennv,@ngaysinh,@diachi,@sdt)
-----------Sửa
create proc sp_Capnhatnv
@pk_manv int,@tennv nvarchar(30),@ngaysinh date,@diachi nvarchar(50),@sdt nchar(11)
as
update tbl_nhanvien
set tennv = @tennv,
	ngaysinh = @ngaysinh,
	diachi = @diachi,
	sdt = @sdt
where pk_manv = @pk_manv
-----------------Xóa
create proc sp_Xoanv
@pk_manv int
as
delete from tbl_nhanvien
where pk_manv = @pk_manv

--------------------------------4.Bảng hóa đơn--------------------------
--------------Hiện
drop proc sp_Hienhd	
Create proc sp_Hienhd
as
select H.pk_mahoadon as[Mã HĐ],chisomoi as [Số mới],chisocu as [Số cũ], (H.chisomoi - H.chisocu)as [Số nước],H.fk_makh as[Mã KH],K.tenkh as[Tên KH],L.tenloaikh as [Loại KH],fk_manv as [Mã NV],N.tennv as [Tên NV],CONVERT(nvarchar(11),H.ngaylap,101) as[Ngày lập]
from tbl_hoadon  H inner join tbl_khachhang K
on H.fk_makh = K.pk_makh inner join tbl_nhanvien N
on H.fk_manv = N.pk_manv inner join tbl_loaikh L
on L.pk_maloaikh = K.maloaikh
--------------Thêm 
create proc sp_Themhd
@fk_makh int,@fk_manv int ,@chisomoi int,@chisocu int,@ngaylap date
as
insert into tbl_hoadon values (@fk_makh,@chisomoi,@chisocu,@fk_manv,@ngaylap)
--------------Xóa
Create proc sp_Xoahd
@pk_mahoadon int
as
delete from tbl_hoadon 
where pk_mahoadon = @pk_mahoadon
---------------Sửa
--
drop proc sp_capnhathd
create proc sp_capnhathd 
@pk_mahoadon int ,@fk_makh int,@fk_manv int ,@chisomoi int,@chisocu int,@ngaylap date
as
update tbl_hoadon
set 
	fk_makh = @fk_makh,
	fk_manv = @fk_manv,
	chisomoi = @chisomoi,
	chisocu = @chisocu,
	ngaylap = @ngaylap
where pk_mahoadon = @pk_mahoadon

CREATE PROC sp_thanhtien
@chisomoi int,@chisocu int
-----Linh tinh
drop proc f5cbb
CREATE PROC f5cbb
@tenloaikh nvarchar(20)
as
select H.pk_mahoadon as[Mã HĐ],chisomoi as [Số mới],chisocu as [Số cũ], (H.chisomoi - H.chisocu)as [Số nước],H.fk_makh as[Mã KH],K.tenkh as[Tên KH],L.dongia as [Giá Mức 1],L.dongia2 as [Giá Mức 2],L.dongia3 as [Giá Mức 3]
from tbl_hoadon  H inner join tbl_khachhang K
on H.fk_makh = K.pk_makh inner join tbl_nhanvien N
on H.fk_manv = N.pk_manv inner join tbl_loaikh L
on L.pk_maloaikh = K.maloaikh
where L.tenloaikh = 'HoGiaDinh'



select dongia from tbl_loaikh where tenloaikh = 'HoGiaDinh'
select dongia2 from tbl_loaikh where tenloaikh = 'HoGiaDinh'
select dongia3 from tbl_loaikh where tenloaikh = 'HoGiaDinh'


Create proc dongia
@tenloaikh nvarchar (30)
as










create proc sp_Hienhd
as
begin
	begin 
		update tbl_hoadon
		set tongtien = (chisomoi - chisocu) * dongia
		from tbl_khachhang,tbl_loaikh
		where tbl_hoadon.fk_makh = tbl_khachhang.pk_makh and tbl_khachhang.maloaikh = tbl_loaikh.pk_maloaikh
	end
	select pk_mahoadon,hdthang,so_tk,fk_makh,chisomoi,chisocu,fk_manv,CONVERT(nvarchar(11),ngaylap,103) as ngaylap,tongtien from tbl_hoadon
end
exec sp_Hienhd
select *from tbl_hoadon
exec sp_Hienhd
--sp lập hóa đơn ---



--sp cap nhật hóa đơn ---


--sp xóa hóa đơn --
create proc sp_xoahd
@pk_mahoadon int
as
delete from tbl_hoadon 
where pk_mahoadon = @pk_mahoadon
--sp hiện chi tiết hóa đơn--
create proc sp_chitietHD
as
select hdthang,tenkh,tbl_khachhang.diachi,tbl_khachhang.sdt,tenloaikh,so_tk,tennv,CONVERT(nvarchar(11),ngaylap,103) as ngaylap,chisomoi,chisocu,dongia,tongtien
from tbl_hoadon,tbl_nhanvien,tbl_loaikh,tbl_khachhang
where tbl_hoadon.fk_makh = tbl_khachhang.pk_makh and tbl_hoadon.fk_manv = tbl_nhanvien.pk_manv and tbl_khachhang.maloaikh = tbl_loaikh.pk_maloaikh 
---view ct hd---
create view Vw_CTHD
as
select hdthang,tenkh,tbl_khachhang.diachi,tbl_khachhang.sdt,tenloaikh,so_tk,tennv,CONVERT(nvarchar(11),ngaylap,103) as ngaylap,chisomoi,chisocu,dongia,tongtien
from tbl_hoadon,tbl_nhanvien,tbl_loaikh,tbl_khachhang
where tbl_hoadon.fk_makh = tbl_khachhang.pk_makh and tbl_hoadon.fk_manv = tbl_nhanvien.pk_manv and tbl_khachhang.maloaikh = tbl_loaikh.pk_maloaikh 

create view Vw_DSKH 
as
select Top 100 percent tenkh,CONVERT(nvarchar(11),ngaysinh,103) as ngaysinh,gioitinh,diachi,sdt,datediff(yy,ngaysinh, getdate()) as Tuoi 
from tbl_khachhang
order by Tuoi DESC
select *from Vw_DSKH
drop view Vw_DSKH


create proc cn1
as
select tbl_khachhang.sdt,tbl_khachhang.tenkh,(YEAR(GETDATE())- YEAR(tbl_khachhang.ngaysinh))as [Tuổi] 
from tbl_khachhang
where YEAR(GETDATE())- YEAR(tbl_khachhang.ngaysinh)  >25
and  YEAR(GETDATE())- YEAR(tbl_khachhang.ngaysinh) <60


select *from tbl_hoadon
where ngaylap > '2000-12-12'
      and ngaylap <'2012-05-14'
      
select N.diachi, N.ngaysinh,N.sdt,N.tennv,(D.chisomoi - D.chisocu) as SoNuoc
from tbl_nhanvien N inner join tbl_hoadon D
ON N.pk_manv = D.fk_manv      
ORder by SoNuoc Desc