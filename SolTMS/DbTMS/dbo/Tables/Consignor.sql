CREATE TABLE [dbo].[Consignor] (
    [ConsignorID]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50)  NULL,
    [ConsignorName] NVARCHAR (50)  NULL,
    [ShortName]     NVARCHAR (50)  NULL,
    [Address]       NVARCHAR (MAX) NULL,
    [ContactPerson] NVARCHAR (50)  NULL,
    [PhoneNo]       BIGINT         NULL,
    [IsDelete]      BIT            NULL,
    [CreationDate]  DATE           NULL,
    [ModifiedDate]  DATE           NULL,
    CONSTRAINT [PK_Consignor] PRIMARY KEY CLUSTERED ([ConsignorID] ASC)
);

