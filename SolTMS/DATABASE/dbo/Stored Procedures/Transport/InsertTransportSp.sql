CREATE PROCEDURE [dbo].[InsertTransportSp]
	@TransportName Nvarchar(50),
	@DriverName Nvarchar(50),
	@MobileNo bigint,
	@VehicalNo Nvarchar(20),

	@Status Nvarchar(100) OUTPUT
AS

	DECLARE @ErrorMessage NVARCHAR(MAX)

	BEGIN TRY
		
		BEGIN TRANSACTION 

			INSERT INTO Transport
			(TransportName,DriverName,MobileNo,VehicalNo,IsDelete,CreationDate,ModifiedDate)
			VALUES
			(@TransportName,@DriverName,@MobileNo,@VehicalNo,0,Getdate(),getdate())

		COMMIT TRANSACTION

	END TRY

	BEGIN CATCH 
		ROLLBACK TRANSACTION

		SET @ErrorMessage=ERROR_MESSAGE()
		RAISERROR(@ErrorMessage,16,1)
	
	END CATCH
	
RETURN 0