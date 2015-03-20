CREATE TABLE [dbo].[Transport] (
    [TransportID]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [TransportName] NVARCHAR (50) NULL,
    [DriverName]    NVARCHAR (50) NOT NULL,
    [MobileNo]      BIGINT        NULL,
    [VehicalNo]     NVARCHAR (20) NOT NULL,
    [IsDelete]      BIT           NULL,
    [CreationDate]  DATE          NULL,
    [ModifiedDate]  DATE          NULL,
    CONSTRAINT [PK__Transpor__19E9A17D1950F063] PRIMARY KEY CLUSTERED ([TransportID] ASC)
);

