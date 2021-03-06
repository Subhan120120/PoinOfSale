  
  --Declare @StartDate Date = '2021-10-20'
  --Declare @EndDate Date = '2021-10-20'

SELECT StoreCode
, TrPaymentLines.PaymentTypeCode
, PaymentTypeDesc
, Payment = SUM(TrPaymentLines.Payment)
, BankId = MAX(TrPaymentLines.BankId)
FROM TrPaymentLines
JOIN TrPaymentHeaders ON TrPaymentLines.PaymentHeaderId = TrPaymentHeaders.PaymentHeaderId
JOIN DcPaymentTypes ON TrPaymentLines.PaymentTypeCode = DcPaymentTypes.PaymentTypeCode
WHERE DocumentDate BETWEEN @StartDate AND @EndDate
GROUP BY StoreCode
, TrPaymentLines.PaymentTypeCode
, PaymentTypeDesc
ORDER BY MAX(TrPaymentLines.CreatedDate)

