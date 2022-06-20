USE MASTER
GO
if DB_ID('QuanLySanPhamDB') is not null
	DROP DATABASE QuanLySanPhamDB;
CREATE DATABASE QuanLySanPhamDB;
GO
USE QuanLySanPhamDB;
GO
CREATE TABLE NhomHang(
	MaNhomHang int primary key,
	TenNhomHang nvarchar(50)
);
GO
INSERT INTO NhomHang VALUES
	(1,N'Điện thoại'),
	(2,N'Nhà cửa'),
	(3,N'Làm đẹp'),
	(4,N'Thời trang'); 
 
GO
CREATE TABLE SanPham(
	MaSP int primary key,
	TenSanPham nvarchar(50),
	DonGia float,
	SoLuongBan float,
	TienBan float,
	MaNhomHang int foreign key references NhomHang(MaNhomHang)
)
GO
INSERT INTO SanPham VALUES
	(1,N'Iphone 7',1000000,2,2000000,1),
	(2,N'Son phấn',100000,2,200000,2),
	(3,N'Áo phông',150000,2,300000,3),
	(4,N'Cây lau nhà',420000,1,420000,4),
	(5,N'Note 10',8000000,2,16000000,1),
	(6,N'Iphone 8',1100000,2,2200000,1);