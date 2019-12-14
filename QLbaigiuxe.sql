CREATE DATABASE PARKINGMANAGE
USE PARKINGMANAGE
Create Table TaiKhoan
(
	ID int IDENTITY(1,1) primary key,
	Username varchar(16),
	Pass varchar(24),
	LoaiTaiKhoan int
)
INSERT INTO TaiKhoan VALUES ('ADMIN','1',1)
SELECT * from TaiKhoan
Go
SELECT * FROM NhanVien, TaiKhoan where TaiKhoan.ID = Nhanvien.ID_taikhoan
Create table NhanVien
(
	ID int IDENTITY(1,1) primary key,
	Ten nvarchar(50),
	NgaySinh datetime,
	ID_taikhoan int foreign key references TaiKhoan(ID)
)
Go

Create table TheXe
(
	ID int primary key
)
Go

Create table LoaiXe
(
	ID int IDENTITY(1,1) primary key,
	LoaiXe int
)
Go

Create table Xe
(
	ID int IDENTITY(1,1) primary key,
	BienSo varchar(15),
	GioGui datetime,
	ID_loaixe int foreign key references LoaiXe(ID),
	ID_thexe int foreign key references TheXe(ID)
)
Go

Create table PhiGuiXe
(
	ID int IDENTITY(1,1) primary key,
	ID_loaixe int foreign key references LoaiXe(ID),
	PhiNgay money,
	PhiQuaDem money
)
Go

Create table DoanhThu
(
	ID int IDENTITY(1,1) primary key,
	Ngay datetime,
	MucThu money
)
