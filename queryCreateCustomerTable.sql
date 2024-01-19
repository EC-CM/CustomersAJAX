CREATE TABLE [dbo].[Customers] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (MAX) NULL,
    [Age]           INT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

INSERT INTO dbo.Customers(Name, Age) VALUES
    ('Sherry', 37),
    ('Tim', 12),
    ('Charlene', 98),
    ('Dane', 24),
    ('Elijah', 51),
    ('Howard', 64),
    ('Dave', 34);