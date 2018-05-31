
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server Compact Edition
-- --------------------------------------------------
-- Date Created: 05/30/2018 23:50:16
-- Generated from EDMX file: C:\Users\rykerrumsey\source\repos\tallyho\tallyho.edmx
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- NOTE: if the table does not exist, an ignorable error will be reported.
-- --------------------------------------------------

    DROP TABLE [casing];
GO
    DROP TABLE [string];
GO
    DROP TABLE [well];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'casings'
CREATE TABLE [casings] (
    [CasingId] int IDENTITY(1,1) NOT NULL,
    [StringId] int  NOT NULL,
    [JointNumber] int  NOT NULL,
    [Length] float  NOT NULL
);
GO

-- Creating table 'strings'
CREATE TABLE [strings] (
    [StringId] int IDENTITY(1,1) NOT NULL,
    [WellId] int  NOT NULL,
    [CasingType] nvarchar(128)  NOT NULL,
    [Weight] float  NOT NULL,
    [Size] float  NOT NULL,
    [MeasuredBy] nvarchar(128)  NOT NULL,
    [DateMeasured] datetime  NOT NULL,
    [RunType] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'wells'
CREATE TABLE [wells] (
    [WellId] int IDENTITY(1,1) NOT NULL,
    [CompanyName] nvarchar(128)  NOT NULL,
    [Location] nvarchar(128)  NOT NULL,
    [ServiceProvider] nvarchar(128)  NOT NULL,
    [RigNumber] int  NOT NULL,
    [RigCompany] nvarchar(128)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CasingId] in table 'casings'
ALTER TABLE [casings]
ADD CONSTRAINT [PK_casings]
    PRIMARY KEY ([CasingId] );
GO

-- Creating primary key on [StringId] in table 'strings'
ALTER TABLE [strings]
ADD CONSTRAINT [PK_strings]
    PRIMARY KEY ([StringId] );
GO

-- Creating primary key on [WellId] in table 'wells'
ALTER TABLE [wells]
ADD CONSTRAINT [PK_wells]
    PRIMARY KEY ([WellId] );
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StringId] in table 'casings'
ALTER TABLE [casings]
ADD CONSTRAINT [FK_stringcasing1]
    FOREIGN KEY ([StringId])
    REFERENCES [strings]
        ([StringId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_stringcasing1'
CREATE INDEX [IX_FK_stringcasing1]
ON [casings]
    ([StringId]);
GO

-- Creating foreign key on [WellId] in table 'strings'
ALTER TABLE [strings]
ADD CONSTRAINT [FK_wellstring1]
    FOREIGN KEY ([WellId])
    REFERENCES [wells]
        ([WellId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_wellstring1'
CREATE INDEX [IX_FK_wellstring1]
ON [strings]
    ([WellId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------