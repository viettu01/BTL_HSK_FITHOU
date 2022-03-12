﻿CREATE DATABASE HSK_QuanLyCuaHangBanDienThoai;
USE HSK_QuanLyCuaHangBanDienThoai;

--BẢNG HÃNG---
CREATE TABLE tblProducer
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	name NVARCHAR(50) NOT NULL
);

--BẢNG TÀI KHOẢN
CREATE TABLE tblAccount
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	role NVARCHAR(20) NOT NULL,
	username NVARCHAR(50) NOT NULL,
	password NVARCHAR(8) NOT NULL,
	fullName NVARCHAR(30) NULL,
	phone VARCHAR(12) NULL,
	birthday DATETIME NULL
);

--BẢNG KHÁCH HÀNG--
CREATE TABLE tblCustomer
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	name NVARCHAR(30) NULL,
	phone NVARCHAR(12) NULL
);

--BẢNG SẢN PHẨM---
CREATE TABLE tblPhone
(
	id VARCHAR(255) NOT NULL PRIMARY KEY,
	name NVARCHAR(255) NOT NULL,
	idProducer INT FOREIGN KEY REFERENCES dbo.tblProducer(id) NOT NULL,
	quantity INT NOT NULL DEFAULT 0,
	price FLOAT NULL DEFAULT 0,
	color NVARCHAR(20) NULL,
	rom NVARCHAR(20) NULL,
	ram NVARCHAR(20) NULL,
	timeBH NVARCHAR(20) NULL
);

--BẢNG HÓA ĐƠN NHẬP--
CREATE TABLE tblBillIn
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	accountId INT FOREIGN KEY REFERENCES dbo.tblAccount(id) NOT NULL,
	createdAt DATETIME NOT NULL
);

--BẢNG CHI TIẾT HÓA ĐƠN NHẬP
CREATE TABLE tblDetailBillIn
(
	billInId INT FOREIGN KEY REFERENCES dbo.tblBillIn(id) NOT NULL,
	phoneId VARCHAR(255) FOREIGN KEY REFERENCES dbo.tblPhone(id) NOT NULL,
	price FLOAT DEFAULT 0 NOT NULL,
	quantity INT DEFAULT 0 NOT NULL 
);
ALTER TABLE tblDetailBillIn ADD CONSTRAINT PK_billId_phoneId PRIMARY KEY(billInId, phoneId)

--BẢNG HÓA ĐƠN XUẤT
CREATE TABLE tblBillOut
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	accountId INT FOREIGN KEY REFERENCES dbo.tblAccount(id) NOT NULL,
	customerId INT FOREIGN KEY REFERENCES dbo.tblCustomer(id) NOT NULL,
	createdAt DATETIME NOT NULL DEFAULT(GETDATE())
);

--BẢNG CHI TIẾT XUẤT
CREATE TABLE tblDetailBillOut
(
	billOutId INT FOREIGN KEY REFERENCES dbo.tblBillOut(id) NOT NULL,
	phoneId VARCHAR(255) FOREIGN KEY REFERENCES dbo.tblPhone(id) NOT NULL,
	quantity FLOAT DEFAULT 1 NOT NULL
);
ALTER TABLE tblDetailBillOut ADD CONSTRAINT PK_tblChiTietXuat PRIMARY KEY(billOutId, phoneId)


GO
--View xem danh sách nhà sản xuất
CREATE VIEW showAllProducer
AS
	SELECT id AS [Mã nhà sản xuất], name AS [Tên nhà sản xuất]
	FROM dbo.tblProducer

GO
--Thủ tục thêm nhà sản xuất
CREATE PROC insertProducer (@name NVARCHAR(50))
AS
BEGIN
    INSERT INTO dbo.tblProducer(name) VALUES(@name)
END

GO
--Thủ tục xóa nhà sản xuất theo tên
CREATE PROC deleteProducerByName (@name NVARCHAR(50))
AS
BEGIN
	DELETE FROM dbo.tblPhone WHERE idProducer = (SELECT id FROM dbo.tblProducer WHERE name = @name)
    DELETE FROM dbo.tblProducer WHERE name = @name
END

GO
--Thủ tục sửa tên nhà sản xuất
CREATE PROC updateProducerName (@id INT, @name NVARCHAR(50))
AS
BEGIN
    UPDATE dbo.tblProducer
	SET name = @name
	WHERE id = @id
END

GO
--View xem danh sách điện thoại
ALTER VIEW showAllPhone
AS
	SELECT a.id AS [Mã ĐT], a.name AS [Tên ĐT], b.name AS [Hãng], a.quantity AS [SL], a.price AS [Giá], a.color AS [Màu], a.rom AS [Rom], a.ram AS [Ram], a.timeBH AS [Thời gian BH]
	FROM dbo.tblPhone a JOIN dbo.tblProducer b ON b.id = a.idProducer

--Thủ tục thêm điện thoại
GO
ALTER PROC insertPhone (@id VARCHAR(255), @name NVARCHAR(255), @idProducer INT, 
						@price FLOAT, @color NVARCHAR(20), @rom NVARCHAR(20), @ram NVARCHAR(20), @timeBH NVARCHAR(20))
AS
BEGIN
	INSERT INTO dbo.tblPhone (id, name, idProducer, quantity, price, color, rom, ram, timeBH)
	VALUES (@id, @name, @idProducer, 0, @price, @color, @rom, @ram, @timeBH)
END

--Thủ tục xóa nhà điện thoại theo id
GO
CREATE PROC deletePhoneById (@id VARCHAR(255))
AS
BEGIN
	DELETE FROM dbo.tblDetailBillIn WHERE phoneId = @id
	DELETE FROM dbo.tblDetailBillOut WHERE phoneId = @id
    DELETE FROM dbo.tblPhone WHERE id = @id
END

--Thủ tục sửa tên điện thoại
GO
ALTER PROC updatePhone (@id VARCHAR(255), @name NVARCHAR(50), @idProducer INT, 
						@price FLOAT, @color NVARCHAR(20), @rom NVARCHAR(20), @ram NVARCHAR(20), @timeBH NVARCHAR(20))
AS
BEGIN
    UPDATE dbo.tblPhone
	SET name = @name, idProducer = @idProducer, price = @price, 
		color = @color, rom = @rom, ram = @ram, timeBH = @timeBH
	WHERE id = @id
END

GO
--View xem danh sách tài khoản
CREATE VIEW showAllAccount
AS
	SELECT id AS [ID], role AS [Quyền], username AS [Tên đăng nhập], password AS [Mật khẩu], fullName AS [Họ tên], phone AS [SĐT], birthday AS [Ngày sinh]
	FROM dbo.tblAccount

GO
--Thủ tục thêm tài khoản
CREATE PROC insertAccount (@role NVARCHAR(20), @username NVARCHAR(50), @password NVARCHAR(8), 
							@fullName NVARCHAR(30), @phone VARCHAR(12), @birthday DATETIME)
AS
BEGIN
	INSERT INTO dbo.tblAccount (role, username, password, fullName, phone, birthday)
	VALUES (@role, @username, @password, @fullName, @phone, @birthday)
END

GO
--Thủ tục xóa tài khoản theo id
CREATE PROC deleteAccountById (@id INT)
AS
BEGIN
	DELETE FROM dbo.tblBillIn WHERE accountId = @id
	DELETE FROM dbo.tblBillOut WHERE accountId = @id
    DELETE FROM dbo.tblAccount WHERE id = @id
END

GO
--Thủ tục sửa thông tin tài khoản
CREATE PROC updateAccount (@id INT, @role NVARCHAR(20), @username NVARCHAR(50), @password NVARCHAR(8), 
							@fullName NVARCHAR(30), @phone VARCHAR(12), @birthday DATETIME)
AS
BEGIN
    UPDATE dbo.tblAccount
	SET role = @role, username = @username, password = @password, 
		fullName = @fullName, phone = @phone, birthday = @birthday
	WHERE id = @id
END

GO
--View xem danh sách tài khoản
CREATE VIEW showAllCustomer
AS
	SELECT id AS [ID], name AS [Họ tên], phone AS [SĐT]
	FROM dbo.tblCustomer

GO
--Thủ tục thêm tài khoản
CREATE PROC insertCustomer (@name NVARCHAR(30), @phone VARCHAR(12))
AS
BEGIN
	INSERT INTO dbo.tblCustomer (name, phone)
	VALUES (@name, @phone)
END

GO
--Thủ tục xóa tài khoản theo id
CREATE PROC deleteCustomerById (@id INT)
AS
BEGIN
	DELETE FROM dbo.tblBillOut WHERE customerId = @id
    DELETE FROM dbo.tblCustomer WHERE id = @id
END

GO
--Thủ tục sửa thông tin tài khoản
CREATE PROC updateCustomer (@id INT, @name NVARCHAR(30), @phone VARCHAR(12))
AS
BEGIN
    UPDATE dbo.tblCustomer
	SET name = @name, phone = @phone
	WHERE id = @id
END

GO
--Thủ tục thêm hóa đơn nhập
CREATE PROC insertBillIn (@accountId INT)
AS
BEGIN
    INSERT dbo.tblBillIn (accountId, createdAt)
    VALUES (@accountId, GETDATE())
END

GO
--Thủ tục thêm chi tiết hóa đơn nhập
CREATE PROC insertDetailBillIn (@billInId INT, @phoneId VARCHAR(255), @price FLOAT, @quantity INT)
AS
BEGIN
    INSERT dbo.tblDetailBillIn (billInId, phoneId, price, quantity)
    VALUES (@billInId, @phoneId, @price, @quantity)
END

GO
--Xóa hóa đơn nhập
CREATE PROC deleteBillIn (@billInId INT)
AS
BEGIN
    DELETE FROM dbo.tblDetailBillIn WHERE billInId = @billInId
	DELETE FROM dbo.tblBillIn WHERE id = @billInId
END

GO
--Sửa hóa đơn nhập
CREATE PROC updateBillIn (@billInId INT, @phoneId VARCHAR(255), @quantity INT, @price FLOAT)
AS
BEGIN
    UPDATE dbo.tblDetailBillIn
	SET quantity = @quantity, price = @price
	WHERE billInId = @billInId AND phoneId = @phoneId
END

GO
--View hiển thị danh sách hóa đơn nhập
CREATE VIEW showAllBillIn
AS
	SELECT c.id AS [Mã hóa đơn], d.fullName AS [Người tạo], c.createdAt AS [Ngày tạo], ISNULL(SUM(b.quantity * b.price), 0) AS [Thành tiền]
	FROM dbo.tblPhone a 
			JOIN dbo.tblDetailBillIn b ON b.phoneId = a.id
			RIGHT JOIN dbo.tblBillIn c ON c.id = b.billInId
			JOIN dbo.tblAccount d ON d.id = c.accountId
	GROUP BY c.id,
             d.fullName,
             c.createdAt

GO
--Thủ tục thêm hóa đơn xuất
CREATE PROC insertBillOut (@accountId INT, @customerId INT)
AS
BEGIN
    INSERT dbo.tblBillOut (accountId, customerId, createdAt)
    VALUES (@accountId, @customerId, GETDATE())
END

GO
--Thủ tục thêm chi tiết hóa đơn xuất
CREATE PROC insertDetailBillOut (@billOutId INT, @phoneId VARCHAR(255), @quantity INT)
AS
BEGIN
    INSERT dbo.tblDetailBillOut (billOutId, phoneId, quantity)
    VALUES (@billOutId, @phoneId, @quantity)
END

GO
/* Cập nhật số lượng tồn kho sau khi nhập hàng */
CREATE TRIGGER TrgNhapHang
ON dbo.tblDetailBillIn
AFTER INSERT
AS
BEGIN
	UPDATE dbo.tblPhone
	SET quantity = dbo.tblPhone.quantity + (SELECT Inserted.quantity FROM Inserted WHERE Inserted.phoneId = dbo.tblPhone.id)
	FROM dbo.tblPhone JOIN Inserted ON Inserted.phoneId = dbo.tblPhone.id
END

GO
/* Cập nhật số lượng tồn kho sau khi xuất hàng */
CREATE TRIGGER TrgXuatHang
ON dbo.tblDetailBillOut
AFTER INSERT
AS
BEGIN
	UPDATE dbo.tblPhone
	SET quantity = dbo.tblPhone.quantity - (SELECT Inserted.quantity FROM Inserted WHERE Inserted.phoneId = dbo.tblPhone.id)
	FROM dbo.tblPhone JOIN Inserted ON Inserted.phoneId = tblPhone.id
END

GO
SELECT COUNT(a.id) AS [Tổng số hóa đơn]
FROM dbo.tblBillOut a 
		JOIN dbo.tblCustomer b ON b.id = a.customerId
WHERE b.id = 1

GO
CREATE VIEW showDoanhThuSanPham
AS
	SELECT c.id AS [Mã điện thoại], c.name AS [Tên điện thoại], c.quantity AS [Tồn kho], 
			ISNULL(SUM(b.quantity), 0) AS [Đã bán], ISNULL((c.price * b.quantity), 0) AS [Doanh thu]
	FROM dbo.tblBillOut a 
			JOIN dbo.tblDetailBillOut b ON b.billOutId = a.id
			RIGHT JOIN dbo.tblPhone c ON c.id = b.phoneId
	GROUP BY (c.price * b.quantity),
             c.id,
             c.name,
             c.quantity

GO
CREATE VIEW showDoanhThuSanPhamTheoNgay
AS
	SELECT c.id AS [Mã điện thoại], c.name AS [Tên điện thoại], c.quantity AS [Tồn kho], 
			ISNULL(SUM(b.quantity), 0) AS [Đã bán], ISNULL(SUM(c.price * b.quantity), 0) AS [Doanh thu]
	FROM dbo.tblBillOut a 
			JOIN dbo.tblDetailBillOut b ON b.billOutId = a.id
			RIGHT JOIN dbo.tblPhone c ON c.id = b.phoneId
	GROUP BY c.id,
             c.name,
             c.quantity,
             a.createdAt

GO
CREATE VIEW showListHoaDonKhachHang
as
	SELECT a.id AS [Mã hóa đơn], d.name AS [Tên khách hàng], d.phone AS [Số điện thoại], 
			c.name AS [Tên sản phẩm], c.price AS [Giá], b.quantity AS [Số lượng]
	FROM dbo.tblBillOut a 
			JOIN dbo.tblDetailBillOut b ON b.billOutId = a.id
			JOIN dbo.tblPhone c ON c.id = b.phoneId
			JOIN dbo.tblCustomer d ON d.id = a.customerId
	WHERE d.phone = '0456789123'

GO
SELECT * FROM showListHoaDonKhachHang WHERE [Số điện thoại] = '0456789123'


GO
--View doanh thu của hóa đơn
CREATE VIEW showThanhTienHoaDon
AS
	SELECT c.id AS [Mã hóa đơn], d.fullName AS [Nhân viên tạo], c.createdAt AS [Ngày tạo], SUM(b.quantity * b.price) AS [Thành tiền]
	FROM dbo.tblPhone a 
			JOIN dbo.tblDetailBillIn b ON b.phoneId = a.id
			JOIN dbo.tblBillIn c ON c.id = b.billInId
			JOIN dbo.tblAccount d ON d.id = c.accountId
	GROUP BY c.id,
             d.fullName,
             c.createdAt

GO
SELECT c.id AS [Mã hóa đơn], d.fullName AS [Nhân viên tạo], c.createdAt AS [Ngày tạo], 
		a.name AS [Tên sản phẩm], b.quantity AS [Số lượng], b.price AS [Đơn giá], (b.quantity * b.price) AS [Thành tiền]
FROM dbo.tblPhone a 
		JOIN dbo.tblDetailBillIn b ON b.phoneId = a.id
		JOIN dbo.tblBillIn c ON c.id = b.billInId
		JOIN dbo.tblAccount d ON d.id = c.accountId
GROUP BY (b.quantity * b.price),
         c.id,
         d.fullName,
         c.createdAt,
         a.name,
         b.quantity,
         b.price

GO
SELECT MAX([Mã hóa đơn]) AS [Mã hóa đơn] FROM dbo.showAllBillIn

SELECT MAX([Mã hóa đơn]) AS [Mã hóa đơn max] FROM showAllBillIn

SELECT * FROM dbo.showAllBillIn

GO
ALTER VIEW showAllDetailBillOut
AS
	SELECT tblBillOut.id AS [Mã HĐ], dbo.tblPhone.id AS [Mã ĐT], dbo.tblPhone.name AS [Tên ĐT], dbo.tblDetailBillOut.quantity AS [Số lượng], 
			dbo.tblPhone.price AS [Đơn giá], dbo.tblPhone.price * dbo.tblDetailBillOut.quantity AS [Thành tiền], 
			IIF(IIF(RIGHT(tblPhone.timeBH, DATALENGTH(tblPhone.timeBH) / 2 - CHARINDEX(' ', tblPhone.timeBH) - 1 + 1) LIKE N'năm', DATEADD(YEAR, CAST(LEFT(tblPhone.timeBH, CHARINDEX(' ',tblPhone.timeBH) - 1) AS INT), createdAt), DATEADD(MONTH, CAST(LEFT(tblPhone.timeBH, CHARINDEX(' ',tblPhone.timeBH) - 1) AS INT), createdAt)) < GETDATE(), N'Hết', N'Còn') AS [Hạn bảo hành]		
	FROM dbo.tblBillOut 
			JOIN dbo.tblDetailBillOut ON dbo.tblBillOut.id = dbo.tblDetailBillOut.billOutId 
			JOIN dbo.tblPhone ON dbo.tblDetailBillOut.phoneId = dbo.tblPhone.id

GO
CREATE VIEW showAllBillOut
AS
	SELECT a.id AS [Mã HĐ], d.fullName AS [Người tạo], a.createdAt AS [Ngày tạo], ISNULL(SUM(c.price * b.quantity), 0) AS [Thành tiền]
	FROM dbo.tblBillOut a
			JOIN dbo.tblDetailBillOut b ON b.billOutId = a.id
			JOIN dbo.tblPhone c ON c.id = b.phoneId
			JOIN dbo.tblAccount d ON d.id = a.accountId
	GROUP BY a.id,
             d.fullName,
             a.createdAt