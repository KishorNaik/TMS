
SELECT TotalConsignmentSet.DriverName,TotalConsignmentSet.[Total Consignment Dispatch],TotalPODSet.[Total Acknowledgement POD Received] FROM 
(
	(
	
		SELECT Dispatch.DispatchID, Transport.DriverName,
			(COUNT(Consignment.ConsigneeID)) AS 'Total Consignment Dispatch'
				FROM Consignment
					INNER JOIN
						Dispatch
							ON Consignment.DispatchID=Dispatch.DispatchID
								INNER JOIN
									Transport
										ON Dispatch.TransportID=Transport.TransportID
											GROUP BY Dispatch.DispatchID, Transport.DriverName

	) AS TotalConsignmentSet
	INNER JOIN
	(
			SELECT Dispatch.DispatchID, Transport.DriverName,
				(COUNT(Consignment.IsPODSubmitted)) AS 'Total Acknowledgement POD Received'
					FROM Consignment
						INNER JOIN
							Dispatch
								ON Consignment.DispatchID=Dispatch.DispatchID
									INNER JOIN
										Transport
											ON Dispatch.TransportID=Transport.TransportID
												WHERE Consignment.IsPODSubmitted=1
													GROUP BY Dispatch.DispatchID, Transport.DriverName
	) AS TotalPODSet
	ON TotalConsignmentSet.DispatchID=TotalPODSet.DispatchID
	
) 


SELECT Transport.DriverName,
COUNT(Consignment.ConsignmentID) as 'Total Consignment Dispatch',
SUM(CASE WHEN Consignment.IsPODSubmitted=1 THEN 1 ELSE 0 END)as 'Total Acknowledgement POD Received'
		FROM Consignment
				INNER JOIN
							Dispatch
								ON Consignment.DispatchID=Dispatch.DispatchID
									INNER JOIN
										Transport
											ON Dispatch.TransportID=Transport.TransportID
GROUP BY Transport.DriverName

GO