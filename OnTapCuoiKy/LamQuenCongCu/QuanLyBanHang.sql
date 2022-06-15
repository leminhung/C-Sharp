create database QL_BanHang;
use QL_BanHang;

create table LoaiSanPham (
	MaLoai char(5) not null primary key,
	TenLoai varchar(30)
);

create table TenSanPham (
	MaSP char(5) not null primary key,
	TenSP varchar(30),
	SoLuong int,
	DonGia float,
	MaLoai char(5) FOREIGN KEY REFERENCES LoaiSanPham(MaLoai)
);

INSERT INTO LoaiSanPham VALUES 
		('001', 'Quan ao'),		
		('002', 'Giay dep'),
		('003', 'Phu kien')

INSERT INTO TenSanPham VALUES 
		('001', 'Ao mua dong', 3, 30000, '001'),		
		('002', 'Ao khoac', 2, 20000, '001'),		
		('003', 'Ao co ngan', 4, 40000, '001'),		
		('004', 'Giay trang', 1, 10000, '002'),		
		('005', 'Giay dollars', 3, 50000, '002'),		
		('006', 'Tai nghe', 3, 60000, '003')		
		
