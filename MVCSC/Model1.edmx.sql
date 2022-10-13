
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/27/2022 10:30:29
-- Generated from EDMX file: E:\MVC\MVCSC1\MVCSC\MVCSC\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SCART];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Cart_PrdId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carts] DROP CONSTRAINT [FK_Cart_PrdId];
GO
IF OBJECT_ID(N'[dbo].[FK_Products_CatgId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_CatgId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Carts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carts];
GO
IF OBJECT_ID(N'[dbo].[Product_Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product_Category];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[UserDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserDetails];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Carts'
CREATE TABLE [dbo].[Carts] (
    [CART_ID] int  NOT NULL,
    [PRODUCT_ID] int  NOT NULL,
    [PRODUCT_NAME] varchar(100)  NOT NULL,
    [PRODUCT_COUNT] int  NOT NULL,
    [PRODUCT_TOTALPRICE] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'Product_Category'
CREATE TABLE [dbo].[Product_Category] (
    [CATEGORY_ID] int  NOT NULL,
    [CATEGORY_NAME] varchar(100)  NOT NULL,
    [FIRSTMODIFIED] datetime  NULL,
    [LASTMODIFIED] datetime  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [PRODUCT_ID] int  NOT NULL,
    [PRODUCT_NAME] varchar(100)  NOT NULL,
    [PRODUCT_DESCRIPTION] varchar(200)  NOT NULL,
    [PRODUCT_PRICE] decimal(19,4)  NOT NULL,
    [PRODUCT_REVIEW] varchar(200)  NOT NULL,
    [PRODUCT_COUNT] int  NOT NULL,
    [FIRSTMODIFIED] datetime  NULL,
    [LASTMODIFIED] datetime  NULL,
    [CATEGORY_NAME] varchar(200)  NOT NULL,
    [CATEGORY_ID] int  NOT NULL,
    [PRODUCTS_SOLD] int  NULL
);
GO

-- Creating table 'UserDetails'
CREATE TABLE [dbo].[UserDetails] (
    [UserDetailId] int  NOT NULL,
    [FirstName] varchar(50)  NOT NULL,
    [LastName] varchar(50)  NOT NULL,
    [UserId] varchar(50)  NOT NULL,
    [Password] varchar(100)  NOT NULL,
    [Phone] varchar(100)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CART_ID] in table 'Carts'
ALTER TABLE [dbo].[Carts]
ADD CONSTRAINT [PK_Carts]
    PRIMARY KEY CLUSTERED ([CART_ID] ASC);
GO

-- Creating primary key on [CATEGORY_ID] in table 'Product_Category'
ALTER TABLE [dbo].[Product_Category]
ADD CONSTRAINT [PK_Product_Category]
    PRIMARY KEY CLUSTERED ([CATEGORY_ID] ASC);
GO

-- Creating primary key on [PRODUCT_ID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([PRODUCT_ID] ASC);
GO

-- Creating primary key on [UserId] in table 'UserDetails'
ALTER TABLE [dbo].[UserDetails]
ADD CONSTRAINT [PK_UserDetails]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PRODUCT_ID] in table 'Carts'
ALTER TABLE [dbo].[Carts]
ADD CONSTRAINT [FK_Cart_PrdId]
    FOREIGN KEY ([PRODUCT_ID])
    REFERENCES [dbo].[Products]
        ([PRODUCT_ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Cart_PrdId'
CREATE INDEX [IX_FK_Cart_PrdId]
ON [dbo].[Carts]
    ([PRODUCT_ID]);
GO

-- Creating foreign key on [CATEGORY_ID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Products_CatgId]
    FOREIGN KEY ([CATEGORY_ID])
    REFERENCES [dbo].[Product_Category]
        ([CATEGORY_ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Products_CatgId'
CREATE INDEX [IX_FK_Products_CatgId]
ON [dbo].[Products]
    ([CATEGORY_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------