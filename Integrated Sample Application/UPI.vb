Imports QRCoder

Public Class UPI
    Private Shared Function GetPaymentURL(ByVal vpa As String, ByVal payeeName As String, ByVal Optional txnId As String = "", ByVal Optional amount As Double? = Nothing, ByVal Optional currencyCode As String = "INR", ByVal Optional txnNote As String = "") As String
        If amount Is Nothing Then
            Return $"upi://pay?cu={currencyCode}&pa={vpa}&pn={payeeName}&tr={txnId}&am=0&mode=01&purpose=10&orgid=-&sign=-&tn={txnNote}"
        End If

        Return $"upi://pay?cu={currencyCode}&pa={vpa}&pn={payeeName}&tr={txnId}&am={amount}&mode=01&purpose=10&orgid=-&sign=-&tn={txnNote}"
    End Function

    Public Shared Function Generate(ByVal bank As Bank) As Bitmap
        Dim qrGenerator As QRCodeGenerator = New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(GetPaymentURL(vpa:=$"{bank.AccountNo}@{bank.IfscCode}.ifsc.npci", payeeName:=bank.PayeeName, amount:=bank.Amount, currencyCode:="INR", txnNote:=bank.TxnNote), QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As QRCode = New QRCode(qrCodeData)
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(20)
        Return qrCodeImage
    End Function

    Public Shared Function Generate(ByVal vpa As VPA) As Bitmap
        Dim qrGenerator As QRCodeGenerator = New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(GetPaymentURL(vpa:=vpa.VpaId, payeeName:=vpa.PayeeName, amount:=vpa.Amount, currencyCode:="INR", txnNote:=vpa.TxnNote), QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As QRCode = New QRCode(qrCodeData)
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(20)
        Return qrCodeImage
    End Function
End Class
