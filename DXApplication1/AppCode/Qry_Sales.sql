  
  --Declare @StartDate Date = Getdate()
  --Declare @EndDate Date = Getdate()

SELECT TrInvoiceHeaders.ProcessCode
, ProcessDescription
, StoreCode
, Qty = SUM(TrInvoiceLines.Qty)
, Amount = SUM(TrInvoiceLines.Amount)
, PosDiscount = SUM(TrInvoiceLines.PosDiscount)
, NetAmount = SUM(TrInvoiceLines.NetAmount)
FROM TrInvoiceLines
JOIN TrInvoiceHeaders ON TrInvoiceLines.InvoiceHeaderId = TrInvoiceHeaders.InvoiceHeaderId
LEFT JOIN DcProcesses ON TrInvoiceHeaders.ProcessCode = DcProcesses.ProcessCode
WHERE DocumentDate BETWEEN @StartDate AND @EndDate
GROUP BY StoreCode
, TrInvoiceHeaders.ProcessCode
, ProcessDescription
ORDER BY MAX(TrInvoiceLines.CreatedDate)

