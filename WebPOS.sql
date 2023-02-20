--create database WebPOS_Inventory
--GO
--create database WebPOS_Sales
--GO
--create database WebPOS_Common

GO

use WebPOS_Common

create table Setting (
Id int not null primary key identity (1, 1),
LayoutName nvarchar(50) not null,
[Language] nvarchar(50) not null,
AppTitle nvarchar(255) not null,
CalendarType tinyint not null,
IsActive bit not null
)

GO

create table OptionType (
Id int not null primary key identity (1, 1),
Name nvarchar(255) not null,
Code nvarchar(10) null,
IsReadOnly bit not null,
IsDeleted bit not null
)

GO

create table OptionValue(
Id int not null primary key identity (1, 1),
TypeId int not null,
Name nvarchar(255) not null,
Code nvarchar(255) null,
Flag nvarchar(50) null,
IsDefault bit not null,
IsReadOnly bit not null,
IsDeleted bit not null
)

GO

use WebPOS_Inventory
GO

create table Product (
Id int not null primary key identity(1, 1),
Code nvarchar(100) null,
Name nvarchar(255) not null,
Cost float not null,
Price float not null,
Profit float not null,
Discount float not null,
InitialQuantity int not null,
CurrentQuantity int not null,
AlerQuantity int not null,
CurrencyId int not null,
CurrencyName nvarchar(255) null,
CurrencyCode nvarchar(10) null,
UnitId int null,
UnitName nvarchar(255) null,
CategoryId int null,
CategoryName nvarchar(255) null,
ExpiryDate date null,
Note nvarchar(max) null,
UpdatedBy int not null,
UpdatedDate datetime2 not null,
IsDeleted bit not null
)

GO

create table Warehouse (
Id int not null primary key identity (1, 1),
Name nvarchar(255) not null,
Note nvarchar(max) null,
IsDefault bit not null,
IsDeleted bit not null
)

GO

use WebPOS_Sales

GO

create table Account (
Id int not null primary key identity (1, 1),
Name nvarchar(255) not null,
Phone nvarchar(50) null,
[Address] nvarchar(50) null,
CurrencyId int not null,
CurrencyCode nvarchar(10) null,
CurrencyName nvarchar(255) null,
CurrentDebit float not null,
CurrentCredit float not null,
CurrentBalance float not null,
AccountTypeId int not null,
AccountTypeName nvarchar(255) null,
UpdatedBy int not null,
UpdatedDate datetime2 not null,
IsDeleted bit not null
)

GO

create table Invoice (
Id int not null primary key identity (1, 1),
SerialNum nvarchar(50) not null,
InvoiceType tinyint not null,
WarehouseId int not null,
WarehouseName nvarchar(255),
TreasuryId int not null,
AccountId int null,
CurrencyId int not null,
CurrencyCode nvarchar(10) null,
CurrencyName nvarchar(255) null,
CurrencyRate float not null,
IssueDate date not null,
PaymentType tinyint not null,
TotalPrice float not null,
ItemsCount int not null,
Note nvarchar(max) null,
UpdatedBy int not null,
UpdatedDate datetime2 not null,
IsDeleted bit not null
)

GO

create table InvoiceItem (
Id int not null primary key identity (1, 1),
InvoiceId int not null,
ProductId int not null,
ProductName nvarchar(255) null,
UnitPrice float not null,
TotalPrice float not null,
Cost float not null,
Profit float not null,
UnitDiscount float not null,
TotalDiscount float not null,
Quantity int not null,
IsDeleted bit not null
)

GO

create table [Transaction] (
Id int not null primary key identity (1, 1),
Amount float not null,
[Date] date not null,
AccountId int not null,
AccountName nvarchar(255),
InvoiceId int null,
TransactionType tinyint not null,
TreasuryId int not null,
CurrncyId int not null,
CurrencyCode nvarchar(10) null,
CurrencyName nvarchar(255) null,
CurrencyRate float not null,
Note nvarchar(max) null,
UpdatedBy int not null,
UpdatedDate datetime2 not null,
IsDeleted bit not null
)

GO

create table Treasury (
Id int not null primary key identity (1, 1),
Name nvarchar(255) not null,
CurrencyId int not null,
CurrencyCode nvarchar(10) null,
CurrencyName nvarchar(255) null,
CurrentBalance float not null,
Note nvarchar(max) null,
IsDefault bit not null,
IsDeleted bit not null
)

GO



