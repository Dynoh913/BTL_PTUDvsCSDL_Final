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
	MaNT int identity(1,1) primary key not null,
	TenNT nvarchar(100) not null,
	MaNV int foreign key references NhanVien(MaNV) not null,
	NgheNghiep nvarchar(20) not null,
	NgaySinh date not null
)
create table ChamCong
(
	MaChamCong int identity(1,1) primary key not null,
	MaNV int foreign key references NhanVien(MaNV) not null,
	NgayDiLam date not null,
	SoGioLam int not null
)

insert TaiKhoan values(1, N'admin1', N'1', N'admin')
insert TaiKhoan values(2, N'user1', N'1', N'staff')
insert TaiKhoan values(3, N'user2', N'2', N'staff')

insert NhanVien values(1, N'Nguyễn Văn An', '01-01-2000', '012345678', N'Lê Chân, Hải Phòng', N'Quản lý')
insert NhanVien values(2, N'Nguyễn Văn Bình', '02-02-2003', '087654321', N'An Dương, Hải Phòng', N'Nhân viên')
insert NhanVien values(3, N'Nguyễn Văn Cường', '03-03-1996', '011111111', N'Lạch Tray, Hải Phòng', N'Nhân viên')
insert NhanVien values(4, N'Nguyễn Văn Đức', '03-03-1996', '011111222', N'Kiến Thụy, Hải Phòng', N'Nhân viên')

insert NguoiThan(TenNT,MaNV,NgheNghiep,NgaySinh) values(N'Nguyễn Văn D', 1, N'Giáo viên', '01-01-1970')
insert NguoiThan(TenNT,MaNV,NgheNghiep,NgaySinh) values(N'Nguyễn Văn E', 2, N'Bảo vệ', '01-01-1971')
insert NguoiThan(TenNT,MaNV,NgheNghiep,NgaySinh) values(N'Nguyễn Văn F', 3, N'Nội trợ', '01-01-1972')

insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(1, '12/1/2023', 4)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(1, '12/1/2023', 8)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(2, '12/1/2023', 2)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(2, '12/1/2023', 4)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(3, '12/1/2023', 8)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(4, '12/1/2023', 16)

insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(1, '12/2/2023', 1)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(2, '12/2/2023', 2)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(3, '12/2/2023', 3)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(4, '12/2/2023', 4)

insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(1, '11/1/2023', 20)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(2, '11/1/2023', 25)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(1, '1/1/2024', 20)
insert ChamCong(MaNV, NgayDiLam, SoGioLam) values(2, '1/1/2024', 25)

create function TinhLuongTheoNgay(@NgayDiLam date) returns table as return
(
    select NhanVien.MaNV,NhanVien.TenNV,NgayDiLam,sum(SoGioLam) as 'Tổng số giờ làm',sum(SoGioLam) * 20000 as 'Lương ngày'
    from ChamCong inner join NhanVien on ChamCong.MaNV = NhanVien.MaNV
    where ChamCong.NgayDiLam = @NgayDiLam
	group by NhanVien.MaNV,NhanVien.TenNV,NgayDiLam
);
create function TinhLuongTheoThang(@Thang int, @Nam int) returns table as return
(
	select NhanVien.MaNV,NhanVien.TenNV,@Thang as 'Tháng',@Nam as 'Năm',sum(ChamCong.SoGioLam) as 'Tổng số giờ làm',sum(ChamCong.SoGioLam) * 20000 as 'Lương tháng'
	from ChamCong inner join NhanVien on ChamCong.MaNV = NhanVien.MaNV
	where year(ChamCong.NgayDiLam) = @Nam and month(ChamCong.NgayDiLam) = @Thang
	group by NhanVien.MaNV,NhanVien.TenNV
);
create function TinhLuongTheoNam(@Nam int) returns table as return
(
	select NhanVien.MaNV,NhanVien.TenNV,@Nam as 'Năm',sum(ChamCong.SoGioLam) as 'Tổng số giờ làm',sum(ChamCong.SoGioLam) * 20000 as 'Lương năm'
	from ChamCong inner join NhanVien on ChamCong.MaNV = NhanVien.MaNV
	where year(ChamCong.NgayDiLam) = @Nam
	group by NhanVien.MaNV,NhanVien.TenNV
);
drop function TinhLuongTheoThang
select * from TinhLuongTheoNgay('12/1/2023')
select * from TinhLuongTheoNgay('12/2/2023')
select * from TinhLuongTheoThang(12, 2023)
select * from TinhLuongTheoNam(2023)
select * from TinhLuongTheoNam(2024)

select * from ChamCong

create procedure XoaNhanVien
@MaNV int
as begin
delete from NguoiThan where MaNV=@MaNV
delete from ChamCong where MaNV=@MaNV
delete from NhanVien where MaNV=@MaNV
end