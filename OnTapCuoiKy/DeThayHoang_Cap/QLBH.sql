create database QLBH
use QLBH
go
create table NhomHang(
	MaNhomHang int not null primary key,
	TenNhomHang nvarchar(50)
)
create table SanPham(
	MaSP int not null primary key,
	TenSanPham nvarchar(50),
	DonGia int,
	SoLuongBan int,
	MaNhomHang int not null,
	foreign key (MaNhomHang) references NhomHang(MaNhomHang)
)
go
insert into NhomHang values
	(01, N'Quần'),
	(02, N'Áo')

insert into SanPham values
	(01, N'Quần kaki', 150000, 15, 01),
	(02, N'Quần tây', 300000, 10, 01),
	(03, N'Áo sơ mi', 200000, 7, 02)

select * from NhomHang
select * from SanPham