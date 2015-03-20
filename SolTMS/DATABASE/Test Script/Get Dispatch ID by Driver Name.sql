SELECT * FROM Dispatch
SELECT * FROM Transport


SELECT Dispatch.DispatchNo,Dispatch.DispatchDate,Transport.DriverName
FROM Dispatch
	INNER JOIN
		Transport
			ON Dispatch.TransportID=Transport.TransportID


			SELECT Dispatch.DispatchID,Dispatch.DispatchNo FROM Dispatch
			WHERE Dispatch.TransportID=(SELECT Transport.TransportID FROM Transport WHERE Transport.DriverName='Hasan Bhai')