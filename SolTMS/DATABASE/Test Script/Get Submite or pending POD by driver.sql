
-- Who Submit Highest POD - Requirement.

-- Display - Driver Name & POD Submit Count

SELECT Dispatch.DispatchID, Transport.DriverName,
(COUNT(Consignment.IsPODSubmitted)) 'POD'
FROM Consignment
	INNER JOIN
		Dispatch
			ON Consignment.DispatchID=Dispatch.DispatchID
				INNER JOIN
					Transport
						ON Dispatch.TransportID=Transport.TransportID
	WHERE Consignment.IsPODSubmitted=1
GROUP BY Dispatch.DispatchID, Transport.DriverName

SELECT Consignment.DispatchID,COUNT(Consignment.IsPODSubmitted) as 'POD' FROM Consignment
WHERE Consignment.IsPODSubmitted=1
GROUP BY Consignment.DispatchID