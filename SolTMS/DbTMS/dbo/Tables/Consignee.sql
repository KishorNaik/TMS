CREATE TABLE [dbo].[Consignee] (
    [ConsigneeID]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [ConsigneeName] NVARCHAR (50) NULL,
    [ShortName]     NVARCHAR (50) NULL,
    [Destination]   NVARCHAR (20) NULL,
    [ContactPerson] NVARCHAR (50) NULL,
    [Phone]         BIGINT        NULL,
    [IsDelete]      BIT           NULL,
    [CreationDate]  DATE          NULL,
    [ModifiedDate]  DATE          NULL,
    CONSTRAINT [PK_ConsigneeID] PRIMARY KEY CLUSTERED ([ConsigneeID] ASC)
);

