  
SELECT ProcessCode
, StoreCode
, MAX(TrInvoiceLines.Qty)
, MAX(TrInvoiceLines.Amount)
, MAX(TrInvoiceLines.PosDiscount)
, MAX(TrInvoiceLines.NetAmount)
FROM TrInvoiceLines
JOIN TrInvoiceHeaders ON TrInvoiceLines.InvoiceHeaderId = TrInvoiceHeaders.InvoiceHeaderId
--where DocumentDate BETWEEN @StartDate and @EndDate
GROUP BY StoreCode
, ProcessCode
ORDER BY MAX(TrInvoiceLines.CreatedDate)

