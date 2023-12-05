create database QuanLyNhanSuCuaHangQuanAo
go
use QuanLyNhanSuCuaHangQuanAo
go
create table TaiKhoan
(
	MaTK int primary key, 
	TenDangNhap nvarchar(50) not null,
	MatKhau nvarchar(50) not null,
	PhanQuyen nvarchar(10)
)
create table NhanVien
(
	MaNV int primary key,
	TenNV nvarchar(100) not null,
	NgaySinh date not null,
	SoDT int not null,
	DiaChi nvarchar(200) not null,
	ChucVu nvarchar(50) not null
)
create table NguoiThan
(
	MaNT int primary key,
	TenNT nvarchar(100) not null,
	MaNV int foreign key references NhanVien(MaNV) not null,
	NgheNghiep nvarchar(20) not null,
	NgaySinh date not null
)
create table ChamCong
(
	MaChamCong int primary key,
	MaNV int foreign key references NhanVien(MaNV) not null,
	NgayDiLam date not null,
	SoGioLam int not null
)

insert TaiKhoan values(1, N'nguyenvanA', N'1111', N'admin')
insert TaiKhoan values(2, N'nguyenvanB', N'2222', N'staff')
insert TaiKhoan values(3, N'nguyenvanC', N'3333', N'staff')

insert NhanVien values(1, N'Nguyễn Văn A', '01-01-2000', '012345678', N'Lê Chân, Hải Phòng', N'Quản lý')
insert NhanVien values(2, N'Nguyễn Văn B', '02-02-2003', '087654321', N'An Dương, Hải Phòng', N'Nhân viên')
insert NhanVien values(3, N'Nguyễn Văn C', '03-03-1996', '011111111', N'Lạch Tray, Hải Phòng', N'Nhân viên')

insert NguoiThan values(1, N'Nguyễn Văn D', 1, N'Giáo viên', '01-01-1970')
insert NguoiThan values(2, N'Nguyễn Văn E', 2, N'Bảo vệ', '01-01-1971')
insert NguoiThan values(3, N'Nguyễn Văn F', 3, N'Nội trợ', '01-01-1972')

insert ChamCong values(1, 1, '1/11/2023' , 8)
insert ChamCong values(2, 2, '1/11/2023' , 4)
insert ChamCong values(3, 1, '2/11/2023' , 8)
insert ChamCong values(4, 1, '3/11/2023' , 8)

