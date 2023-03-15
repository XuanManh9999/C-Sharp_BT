﻿CREATE DATABASE LAP_9_QUAN_LY_BAN_HANG
USE LAP_9_QUAN_LY_BAN_HANG
CREATE TABLE HANG (
	MAHANG CHAR(10) PRIMARY KEY,
	TENHANG NVARCHAR(50),
	DONGIA FLOAT,
	GHICHU NVARCHAR(100)
)
INSERT INTO HANG (MAHANG, TENHANG, DONGIA, GHICHU) VALUES ('001', N'Bim Bim Nhỏ', 2000, N'Còn 10 Gói Thôi Nhé');
INSERT INTO HANG (MAHANG, TENHANG, DONGIA, GHICHU) VALUES ('002', N'Bim Bim To', 5000, N'Mới Nhập Còn Nhiều Lắm Mua Nhé');
INSERT INTO HANG (MAHANG, TENHANG, DONGIA, GHICHU) VALUES ('003', N'Kẹo Mút', 1000, N'Kẹo Mút Mới Về');
CREATE TABLE KHACHHANG (
	MAKH CHAR(10) PRIMARY KEY,
	TENKHACHHANG NVARCHAR(50),
	SDT CHAR(10),
	GHICHU NVARCHAR(100)
)
INSERT INTO KHACHHANG (MAKH, TENKHACHHANG, SDT, GHICHU) VALUES('KH01', N'Nguyễn Xuân Mạnh', '0352593469', 'Nhà Gần Sân Bay!');
INSERT INTO KHACHHANG (MAKH, TENKHACHHANG, SDT, GHICHU) VALUES('KH02', N'Nguyễn Văn Hải', '0328063079', 'Nhà Gần Ga Tàu!');
INSERT INTO KHACHHANG (MAKH, TENKHACHHANG, SDT, GHICHU) VALUES('KH03', N'Nguyễn Quốc Tuấn', '0328063079', 'Nhà Gần Chợ!');
CREATE TABLE HOADON (
	MAHD CHAR (10) PRIMARY KEY,
	MAKH CHAR (10)  FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	NGAYHD DATE,
	GHICHU NVARCHAR(100),

)
INSERT INTO HOADON (MAHD, MAKH, NGAYHD, GHICHU)VALUES('HD001', 'KH01', '20230929', N'Hóa Đơn 1');
INSERT INTO HOADON (MAHD, MAKH, NGAYHD, GHICHU)VALUES('HD002', 'KH02', '20230503', N'Hóa Đơn 2');
INSERT INTO HOADON (MAHD, MAKH, NGAYHD, GHICHU)VALUES('HD003', 'KH03', '20230406', N'Hóa Đơn 3');
CREATE TABLE HDCT (
	MAHD CHAR(10) FOREIGN KEY REFERENCES HOADON(MAHD),
	MAHANG CHAR(10) FOREIGN KEY REFERENCES HANG(MAHANG),
	SOLUONG INT,
	PRIMARY KEY (MAHD, MAHANG)
)

INSERT INTO HDCT (MAHD, MAHANG, SOLUONG) VALUES('HD001', '001', 2);
INSERT INTO HDCT (MAHD, MAHANG, SOLUONG) VALUES('HD002', '002', 3);
INSERT INTO HDCT (MAHD, MAHANG, SOLUONG) VALUES('HD003', '003', 4);
