# CyberSource.Model.Ptsv2paymentsidrefundsPaymentInformationPaymentType
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit. Possible values: - &#x60;CARD&#x60; (use this for a PIN debit transaction) - &#x60;CHECK&#x60; (use this for all eCheck payment transactions - ECP Debit, ECP Follow-on Credit, ECP StandAlone Credit) - &#x60;bankTransfer&#x60; (use for Online Bank Transafer for methods such as P24, iDeal, Estonia Bank, KCP) - &#x60;localCard&#x60; (KCP Local card via Altpay) - &#x60;carrierBilling&#x60; (KCP Carrier Billing via Altpay)  | [optional] 
**SubTypeName** | **string** | Detailed information about the Payment Type. Possible values: - &#x60;DEBIT&#x60;: Use this value to indicate a PIN debit transaction.  Examples: For Card, if Credit or Debit or PrePaid. For Bank Transfer, if Online Bank Transfer or Wire Transfers.  | [optional] 
**Method** | [**Ptsv2paymentsidrefundsPaymentInformationPaymentTypeMethod**](Ptsv2paymentsidrefundsPaymentInformationPaymentTypeMethod.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

