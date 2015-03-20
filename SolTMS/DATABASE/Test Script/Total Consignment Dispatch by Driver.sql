-- Total Consignment by Driver 

SELECT Dispatch.DispatchID, Transport.DriverName,
(COUNT(Consignment.ConsigneeID)) AS 'Total Consignment'
FROM Consignment
	INNER JOIN
		Dispatch
			ON Consignment.DispatchID=Dispatch.DispatchID
				INNER JOIN
					Transport
						ON Dispatch.TransportID=Transport.TransportID
GROUP BY Dispatch.DispatchID, Transport.DriverName

SELECT Consignment.DispatchID,COUNT(Consignment.DocketNo) as 'Total Consignment' FROM Consignment
GROUP BY Consignment.DispatchID