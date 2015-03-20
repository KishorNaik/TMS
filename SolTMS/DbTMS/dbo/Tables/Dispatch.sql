CREATE TABLE [dbo].[Dispatch] (
    [DispatchID]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [DispatchNo]   BIGINT        NOT NULL,
    [Year]         NVARCHAR (50) NULL,
    [DispatchDate] DATE          NULL,
    [TransportID]  BIGINT        NULL,
    [IsDelete]     BIT           NULL,
    [CreationDate] DATE          NULL,
    [ModifiedDate] DATE          NULL,
    CONSTRAINT [PK_Dispatch] PRIMARY KEY CLUSTERED ([DispatchID] ASC)
);

