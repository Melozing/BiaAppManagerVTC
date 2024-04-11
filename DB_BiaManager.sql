IF DB_ID('db_biamanager') IS NULL
BEGIN
    CREATE DATABASE db_biamanager;
END
GO

USE db_biamanager;
GO

CREATE TABLE [dbo].[table_type] (
    [IdTableType] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [TableType_Name] varchar(50) COLLATE Vietnamese_CI_AS NOT NULL,
    [TableType_Price] int NOT NULL DEFAULT '0',
    PRIMARY KEY CLUSTERED ([IdTableType])
);
GO

CREATE TABLE [dbo].[items_category] (
    [IdItemCategory] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [ItemCategory_Name] varchar(50) COLLATE Vietnamese_CI_AS NOT NULL,
    PRIMARY KEY CLUSTERED ([IdItemCategory])
);
GO

CREATE TABLE [dbo].[items_menu] (
    [IdItem] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [item_Name] varchar(50) COLLATE Vietnamese_CI_AS NOT NULL,
    [IdItemCategory] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [item_Price] int NOT NULL,
    [item_image] varchar(50) COLLATE Vietnamese_CI_AS NOT NULL,
    PRIMARY KEY CLUSTERED ([IdItem]),
    CONSTRAINT [FK_items_menu_items_category] FOREIGN KEY ([IdItemCategory]) REFERENCES [dbo].[items_category] ([IdItemCategory])
);
GO

CREATE TABLE [dbo].[restaurant_table] (
    [IdTable] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [TableNumber] int NOT NULL,
    [Status] int NOT NULL DEFAULT '0',
    [IdTableType] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    PRIMARY KEY CLUSTERED ([IdTable]),
    CONSTRAINT [FK_table_tabletype] FOREIGN KEY ([IdTableType]) REFERENCES [dbo].[table_type] ([IdTableType])
);
GO

CREATE TABLE [dbo].[invoice] (
    [IdInvoice] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [TableID] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [Invoice_time] datetime NOT NULL,
    [Invoice_TotalAmount] int NOT NULL,
    [Invoice_Status] int NULL,
    PRIMARY KEY CLUSTERED ([IdInvoice]),
    CONSTRAINT [FK_orders_table] FOREIGN KEY ([TableID]) REFERENCES [dbo].[restaurant_table] ([IdTable])
);
GO

CREATE TABLE [dbo].[invoice_detail] (
    [IdInvoice] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [IdItem] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    CONSTRAINT [FK_invoice_detail_invoice] FOREIGN KEY ([IdInvoice]) REFERENCES [dbo].[invoice] ([IdInvoice]),
    CONSTRAINT [FK_invoice_detail_items_menu] FOREIGN KEY ([IdItem]) REFERENCES [dbo].[items_menu] ([IdItem])
);
GO

CREATE TABLE [dbo].[user_account] (
    [IdUser] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [UserName] varchar(50) COLLATE Vietnamese_CI_AS NOT NULL,
    [UserPassword] varchar(70) COLLATE Vietnamese_CI_AS NOT NULL,
    [UserRole] int NULL,
    PRIMARY KEY CLUSTERED ([IdUser])
);
GO

CREATE TABLE [dbo].[user_info] (
    [idUser] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [User_FullName] varchar(50) COLLATE Vietnamese_CI_AS NOT NULL,
    [User_Phone] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [User_BankAccountNumber] varchar(12) COLLATE Vietnamese_CI_AS NULL,
    [User_Image] varchar(50) COLLATE Vietnamese_CI_AS NULL,
    CONSTRAINT [FK_user_info_user] FOREIGN KEY ([idUser]) REFERENCES [dbo].[user_account] ([IdUser])
);
GO
