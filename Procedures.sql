use master;
go;

create database HireCarManagement

use HireCarManagement

create table Employee(
	Id varchar(100) primary Key,
	Name varchar(100),
	Email varchar(100),
	Password varchar(1000),
	ROLE varchar(10)
)

create table Customer(
	Id varchar(100) primary Key,
	Name varchar(100),
	PhoneNumber varchar(10),
	CCCD varchar(100),
	Address varchar(100)
)

create table Feature(
	Id varchar(100) primary Key,
	HaveCamera Bit,
	HaveMap Bit,
	HaveFlyWindown Bit,
	HaveUSB Bit,
	HaveBluetooth Bit,
	HaveTruckContainer Bit,
	HaveCamera360 Bit,
	HaveSpeedWarning Bit,
	HaveRearCamera Bit
)

create table Car(
	Id varchar(100) primary Key,
	Name varchar(100),
	Fuel varchar(255),
	Type varchar(255),
	Brand varchar(100),
	price int,
	IsFree Bit,
	ImageLink varchar(255),
	FeatureId varchar(100),
	Foreign Key(FeatureId) References Feature(Id)
)

create table Schedule(
	Id varchar(100) primary Key,
	HiredAt date,
	ReturnedAt date,
	price float,
	isPaid bit,
	CustomerId varchar(100),
	CarId varchar(100),
    FOREIGN KEY (CarId) REFERENCES Car(Id)
)
go

-------------------------------------------------------------------------------------------------------------------------Employee
create PROCEDURE loginAccountEmployee
	@email varchar(100), @password varchar(100)
AS
BEGIN
	SELECT Email, name, ROLE FROM Employee WHERE email = @email and Password = @password
END
go

create PROCEDURE registerAccountEmployee
	@ID varchar(255), @Name varchar(255), @Email varchar(255), @Password varchar(255), @ROLE varchar(255)
AS
BEGIN
	INSERT INTO Employee (id, name, Email, password, ROLE) VALUES ( @ID, @Name , @Email , @Password , @ROLE)
END
go

create PROCEDURE checkAccountEmployee
	@Email varchar(255)
AS
BEGIN
	SELECT COUNT(Email) AS 'Tontai' FROM Employee WHERE Email = @Email
END
go

create PROCEDURE updateAccountEmployee
	@ID varchar(255),
	@Name varchar(255),
	@Email varchar(255),
	@Password varchar(255),
	@ROLE varchar(255)
AS
BEGIN
	UPDATE Employee SET Name = @Name, Email = @Email, Password = @Password, ROLE = @ROLE WHERE Id = @ID
END
go

create PROCEDURE getAllEmployee
AS 
BEGIN
	SELECT * FROM Employee
END
GO

-----------------------------------------------------------------------------------------------------------------------------Customer
create PROCEDURE showAllCustomer
AS
BEGIN
	SELECT Id, name as N'Họ tên', phoneNumber as N'Số điện thoại', address as N'Địa chỉ', CCCD FROM Customer
END
go

create PROCEDURE getCustomerByCCCD
	@CCCD varchar(255)
AS
BEGIN
	SELECT Id, phoneNumber as N'Số điện thoại', name as N'Họ tên', address as N'Địa chỉ', CCCD FROM Customer WHERE CCCD = @CCCD
END
go
 
create PROCEDURE registerAccountCustomer
@ID varchar(255), @Name varchar(255), @PhoneNumber varchar(255), @Address varchar(255), @CCCD varchar(255)
AS
BEGIN
	INSERT INTO Customer (id, name, phoneNumber, address, CCCD) VALUES (@ID , @Name , @PhoneNumber, @Address, @CCCD)
END
go

create PROCEDURE loginAccountCustomer
	@PhoneNumber varchar(10)
AS
BEGIN
	SELECT PhoneNumber, name FROM Customer WHERE PhoneNumber = @PhoneNumber
END
go

create PROCEDURE checkAccountCustomer
	@PhoneNumber varchar(255)
AS
BEGIN
	SELECT COUNT(PhoneNumber) AS 'Tontai' FROM Customer WHERE PhoneNumber = @PhoneNumber
END
go

create PROCEDURE updateAccountCustomer
@ID varchar(255), @Name varchar(255), @PhoneNumber varchar(255), @Address varchar(255)
AS
BEGIN
	UPDATE Customer SET phoneNumber = @PhoneNumber , name = @name , address = @address where Id = @ID
END
go

create PROCEDURE deleteAccountCustomer
	@ID varchar(255)
AS
BEGIN
	DELETE FROM Customer WHERE Id = @ID
END
go

-------------------------------------------------------------------------------------------------------------------------------Car
create PROCEDURE usp_ShowAllCars
AS
BEGIN
    SELECT Car.Id,
			Name,
			Fuel,
			Type,
			Brand,
			IsFree,
			Price,
			ImageLink,
			FeatureId,
			HaveCamera,
			HaveMap,
			HaveFlyWindown,
			HaveUSB,
			HaveBluetooth,
			HaveTruckContainer,
			HaveCamera360,
			HaveSpeedWarning,
			HaveRearCamera 
	From Car, Feature WHERE Car.FeatureId = Feature.Id
END
go

create PROCEDURE getCarBy
	@ID varchar(255)
AS
BEGIN
	SELECT Car.Id,
	Name,
	Fuel,
	Type,
	Brand,
	IsFree,
	Price,
	ImageLink,
	FeatureId,
	HaveCamera,
	HaveMap,
	HaveFlyWindown,
	HaveUSB,
	HaveBluetooth,
	HaveTruckContainer,
	HaveCamera360,
	HaveSpeedWarning,
	HaveRearCamera From Car, Feature WHERE Car.Id = @ID and Car.FeatureId = Feature.Id
END
go

create PROCEDURE insertCar
	@ID varchar(255),
	@Name varchar(255),
	@Fuel varchar(255),
	@Type varchar(255),
	@Brand varchar(255),
	@IsFree Bit,
	@Price int,
	@ImageLink varchar(255),
	@FeatureId varchar(255),
	@HaveCamera Bit,
	@HaveMap Bit,
	@HaveFlyWindown Bit,
	@HaveUSB Bit,
	@HaveBluetooth Bit,
	@HaveTruckContainer Bit,
	@HaveCamera360 Bit,
	@HaveSpeedWarning Bit,
	@HaveRearCamera Bit
AS
BEGIN
	INSERT INTO Feature (Id, HaveCamera, HaveMap, HaveFlyWindown, HaveUSB, HaveBluetooth, HaveTruckContainer, HaveCamera360, HaveSpeedWarning, HaveRearCamera)
	VALUES ( @FeatureId , @HaveCamera , @HaveMap , @HaveFlyWindown , @HaveUSB , @HaveBluetooth , @HaveTruckContainer, @HaveCamera360 , @HaveSpeedWarning , @HaveRearCamera)

	INSERT INTO Car (Id, Name, Fuel, Type, Brand, IsFree, Price, ImageLink , FeatureId) 
	VALUES ( @ID , @Name , @Fuel , @Type , @Brand, @IsFree , @Price, @ImageLink , @FeatureId)
END
go

create PROCEDURE returnCar
	@ID varchar(255)
AS
BEGIN
	UPDATE Car SET IsFree = 1 WHERE Id = @ID
END
go

create PROCEDURE getCarByType
AS
BEGIN
	SELECT Type AS 'CAR', COUNT(*) AS 'Amount'
	FROM Car
	GROUP BY Type
END
go

create PROCEDURE updateCar
	@ID varchar(255),
	@Name varchar(255),
	@Fuel varchar(255),
	@Type varchar(255),
	@Brand varchar(255),
	@IsFree Bit,
	@Price int,
	@ImageLink varchar(255),
	@FeatureId varchar(255),
	@HaveCamera Bit,
	@HaveMap Bit,
	@HaveFlyWindown Bit,
	@HaveUSB Bit,
	@HaveBluetooth Bit,
	@HaveTruckContainer Bit,
	@HaveCamera360 Bit,
	@HaveSpeedWarning Bit,
	@HaveRearCamera Bit
AS
BEGIN

	UPDATE Feature  
	SET HaveCamera = @HaveCamera , HaveMap = @HaveMap , HaveFlyWindown = @HaveFlyWindown , 
	HaveUSB = @HaveUSB , HaveBluetooth = @HaveBluetooth , HaveTruckContainer = @HaveTruckContainer, 
	HaveCamera360 = @HaveCamera360 , HaveSpeedWarning = @HaveSpeedWarning , HaveRearCamera = @HaveRearCamera
	WHERE Id = @FeatureId

	UPDATE Car
	SET Name = @Name, Fuel = @Fuel, Type = @Type, Brand = @Brand, IsFree = @IsFree, Price = @Price, ImageLink = @ImageLink
	WHERE Id = @ID
END
go

create PROCEDURE deleteCar
@ID varchar(255)
AS
BEGIN
	DELETE FROM Car WHERE Id = @ID
END
go

--------------------------------------------------------------------------------------------------------------------------------Schedule
create PROCEDURE usp_ShowAllSchedule
AS
BEGIN
    SELECT
        Schedule.Id as 'Mã',
        Customer.Name as 'Họ và tên',
        CCCD,
        Car.Name as 'Car',
        HiredAt as 'Ngày thuê',
        ReturnedAt as 'Ngày trả',
        Schedule.Price as 'Giá tiền'
    FROM
        Schedule
    INNER JOIN
        Car ON Car.Id = Schedule.CarId
    INNER JOIN
        Customer ON Customer.Id = Schedule.CustomerId;
END
go

create PROCEDURE showBill
AS
BEGIN
    SELECT Schedule.Id as N'Mã', Customer.Name as N'Họ và tên', CCCD, Car.Name as N'Car', HiredAt as N'Ngày thuê', ReturnedAt as N'Ngày trả', Schedule.Price as N'Giá tiền'
	FROM
        Schedule
    INNER JOIN
        Car ON Car.Id = Schedule.CarId
    INNER JOIN
        Customer ON Customer.Id = Schedule.CustomerId
    WHERE
        Schedule.isPaid = 1;
END
go

create PROCEDURE getScheduleFromTo
	@From date,
	@To date
AS
BEGIN
    SELECT
        ReturnedAt as 'Date',
        Schedule.Price as 'Turnover'
    FROM
        Schedule
    INNER JOIN
        Car ON Car.Id = Schedule.CarId
    INNER JOIN
        Customer ON Customer.Id = Schedule.CustomerId
    WHERE
        Schedule.IsPaid = 1
        AND ReturnedAt BETWEEN @From AND @To
    ORDER BY
        ReturnedAt;
END
GO

create PROCEDURE getScheduleByCustomer
	@CCCD varchar(255)
AS
BEGIN
    SELECT Schedule.Id as N'Mã', Customer.Name as N'Họ và tên', CCCD, Car.Name as N'Car', HiredAt as N'Ngày thuê', ReturnedAt as N'Ngày trả', Schedule.Price as N'Giá tiền', CarId
	FROM
        Schedule
    INNER JOIN
        Car ON Car.Id = Schedule.CarId
    INNER JOIN
        Customer ON Customer.Id = Schedule.CustomerId
    WHERE
        Customer.CCCD = @CCCD;
END
go

create PROCEDURE insertSchedule 
	@ID varchar(255),
	@HiredAt date,
	@ReturnedAt date,
	@Price float,
	@IsPaid bit,
	@CustomerId varchar(255),
	@CarId varchar(255)
AS 
BEGIN
	INSERT INTO Schedule (Id, HiredAt, ReturnedAt, price, isPaid, CustomerId, CarId)
	VALUES (@ID, @HiredAt, @ReturnedAt, @Price, @IsPaid, @CustomerId, @CarId)

	UPDATE Car SET IsFree = 0 WHERE Id = @CarId
END
go

create PROCEDURE updateSchedule
	@ID varchar(255),
	@HiredAt date,
	@ReturnedAt date,
	@Price float,
	@IsPaid bit
AS
BEGIN
	UPDATE Schedule 
	SET HiredAt = @HiredAt, ReturnedAt = @ReturnedAt, price = @Price, isPaid = @IsPaid
	WHERE Id = @ID
END
go

create PROCEDURE deleteSchedule
	@ID varchar(255)
AS
BEGIN
	DELETE FROM Schedule WHERE Id = @ID
END
go

insert into Employee (Id, Name, Email, Password, ROLE) 
values ('550e8400-e29b-41d4-a716-446655440000', 'Nguyen Huu Tin', 'nguyenhuutin124@gmail.com', '123456', 'ROLE_ADMIN')

select * from employee

exec loginAccountEmployee 'nguyenhuutin124@gmail.com', '123456'

EXEC insertCar '550e8400-e29b-41d4-a716-446655440056',
    'Misubishi',
    'Electric',
    'SUV',
    'Misubishi',
    1,
    30000,
    'https://example.com/car_image.jpg',
    '550e8400-e29b-41d4-a716-446655440087',
    1,
    1,
    0,
    1,
    1,
    1,
    0,
    1,
    0
exec usp_ShowAllCars
select * from car, feature where car.FeatureId = feature.Id

select * from Feature

exec usp_ShowAllCars
exec updateCar '550e8400-e29b-41d4-a716-446655440010',
    'MAZDA',
    'Gasoline', 
    'SUV',
    'MAZDA',
    1,
    30000,
    'https://example.com/car_image.jpg',
    '550e8400-e29b-41d4-a716-446655440010',
    1,
    1,
    0,
    1,
    1,
    1,
    0,
    1,
    0

exec getCarBy '550e8400-e29b-41d4-a716-446655440010'
select * from feature
select * from schedule

exec registerAccountCustomer '550e8400-e29b-41d4-a716-446655440010', 'Nguyen van A', '0987654321', 'TP HO CHI MINH', '111222333'
exec getCustomerByCCCD '111222444'
select * from Customer

exec usp_ShowAllSchedule

exec insertSchedule '550e8400-e29b-41d4-a716-446655440015', '2000-1-1', '2000-1-1', 12000, '550e8400-e29b-41d4-a716-446655440010', '550e8400-e29b-41d4-a716-446655440010'
exec getScheduleFromTo '2023-1-1', '2024-11-28'

exec showBill

exec registerAccountEmployee '550e8400-e29b-41d4-a716-446655440017', 'Doan Thai Tu', 'doanthaitu@gmail.com', '123456' , 'ROLE_EMP'
