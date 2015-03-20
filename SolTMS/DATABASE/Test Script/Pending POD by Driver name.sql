SELECT * FROM Consignment

-- Pending POD By Driver
SELECT Consignment.DocketNo,Consignment.DocketDate,
			Consignor.ConsignorName,Consignee.ConsigneeName,
			Dispatch.DispatchNo,Dispatch.DispatchDate,
			Transport.DriverName
			FROM Consignment
				INNER JOIN
					Consignor
						ON Consignment.ConsignorID=Consignor.ConsignorID
							INNER JOIN
								Consignee
									ON Consignment.ConsignorID=Consignee.ConsigneeID
										INNER JOIN
											Dispatch
												ON Consignment.DispatchID=Dispatch.DispatchID
													INNER JOIN
														Transport
															ON Dispatch.TransportID=Transport.TransportID

			WHERE Consignment.IsPODSubmitted=0 and Consignment.DispatchID IN (SELECT Dispatch.DispatchID FROM Dispatch
			WHERE Dispatch.TransportID=(SELECT Transport.TransportID FROM Transport WHERE Transport.DriverName='Harish'))