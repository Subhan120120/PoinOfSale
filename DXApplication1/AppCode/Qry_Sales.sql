  
  --Declare @StartDate Date = '2021-10-21'
  --Declare @EndDate Date = '2021-10-21'

SELECT TrInvoiceHeaders.ProcessCode
, ProcessDescription
, StoreCode
, Qty = SUM(TrInvoiceLines.Qty)
, Amount = SUM(TrInvoiceLines.Amount)
, PosDiscount = SUM(TrInvoiceLines.PosDiscount)
, NetAmount = SUM(TrInvoiceLines.NetAmount)
, IsReturn = IsReturn
FROM TrInvoiceLines
JOIN TrInvoiceHeaders ON TrInvoiceLines.InvoiceHeaderId = TrInvoiceHeaders.InvoiceHeaderId
LEFT JOIN DcProcesses ON TrInvoiceHeaders.ProcessCode = DcProcesses.ProcessCode
WHERE DocumentDate BETWEEN @StartDate AND @EndDate AND TrInvoiceHeaders.ProcessCode != 'EX'
GROUP BY StoreCode
, TrInvoiceHeaders.ProcessCode
, ProcessDescription
, IsReturn
ORDER BY MAX(TrInvoiceLines.CreatedDate)

