USE MASTER
GO
if DB_ID('QuanLyBenhNhanDB') is not null
	DROP DATABASE QuanLyBenhNhanDB;
CREATE DATABASE QuanLyBenhNhanDB;
GO
USE QuanLyBenhNhanDB;
GO
CREATE TABLE Khoa(
	MaKhoa int primary key,
	TenKhoa nvarchar(50)
);

GO
INSERT INTO Khoa VALUES
	(1,N'Tim mạch'),
	(2,N'Thần kinh'),
	(3,N'Ngoại'),
	(4,N'Nội'); 
 
GO
CREATE TABLE BenhNhan(
	MaBN int primary key,
	HoTen nvarchar(50),
	SoNgayNamVien int,
	VienPhi float,
	MaKhoa int foreign key references Khoa(MaKhoa)
)
GO
INSERT INTO BenhNhan VALUES
	(1, N'Lữ Bố', 5, 1000000,1),
	(2, N'Lưu Bị', 3, 600000,2),
	(3, N'Quan Vũ', 4, 800000,3),
	(4, N'Trương Phi', 2, 400000,4),
	(5, N'Khổng Minh', 1, 200000,1),
	(6, N'Điêu Thuyền', 2, 400000,1);