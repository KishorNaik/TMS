CREATE TABLE [dbo].[Consignment] (
    [ConsignmentID]      BIGINT         IDENTITY (1, 1) NOT NULL,
    [DocketNo]           BIGINT         NULL,
    [DocketDate]         DATE           NULL,
    [ConsignorID]        BIGINT         NULL,
    [InvoiceNo]          NVARCHAR (MAX) NULL,
    [InvoiceDate]        DATE           NULL,
    [ConsigneeID]        BIGINT         NULL,
    [ExpectedDate]       DATE           NULL,
    [DeliveryDate]       DATE           NULL,
    [DispatchID]         BIGINT         NOT NULL,
    [IsDispatch]         BIT            NULL,
    [IsPODSubmitted]     BIT            NULL,
    [ISPODIncludeInBill] BIT            NULL,
    [IsAudit]            BIT            NULL,
    [Status]             NVARCHAR (50)  NULL,
    [Remark]             NVARCHAR (MAX) NULL,
    [IsDelete]           BIT            NULL,
    [CreationDate]       DATE           NULL,
    [ModifiedDate]       DATE           NULL,
    CONSTRAINT [PK_Consignment] PRIMARY KEY CLUSTERED ([ConsignmentID] ASC)
);

