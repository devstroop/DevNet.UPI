Public Class Form1
    Private Sub btnGenByUPI_Click(sender As Object, e As EventArgs) Handles btnGenByUPI.Click
        Dim vpa As DevNet.Models.VPA = New DevNet.Models.VPA()
        vpa.VpaId = Me.tBoxVPA.Text
        vpa.PayeeName = Me.tBoxVPAPayee.Text
        Try
            vpa.Amount = Double.Parse(Me.tBoxAmt.Text)
        Catch ex As Exception
            vpa.Amount = Nothing
        End Try
        vpa.TxnNote = Me.tBoxTxnNote.Text
        Dim img = DevNet.UPI.Generate(vpa)
        Me.pBoxQR.Image = img
    End Sub

    Private Sub btnGenByBank_Click(sender As Object, e As EventArgs) Handles btnGenByBank.Click
        Dim bank As DevNet.Models.Bank = New DevNet.Models.Bank()
        bank.AccountNo = Me.tBoxAccNo.Text
        bank.IfscCode = Me.tBoxIFSC.Text
        bank.PayeeName = Me.tBoxBankPayee.Text
        Try
            bank.Amount = Double.Parse(Me.tBoxBankAmt.Text)
        Catch ex As Exception
            bank.Amount = Nothing
        End Try
        bank.TxnNote = Me.tBoxBankTxnNote.Text
        Dim img = DevNet.UPI.Generate(bank)
        Me.pBoxQR.Image = img
    End Sub
End Class
