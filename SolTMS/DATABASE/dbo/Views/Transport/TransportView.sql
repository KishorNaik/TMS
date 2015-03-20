CREATE VIEW [dbo].[TransportView]
	AS 
		SELECT t.TransportID,t.TransportName,t.DriverName,t.MobileNo,t.VehicalNo,t.IsDelete FROM Transport T
		WHERE t.IsDelete=0