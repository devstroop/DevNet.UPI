<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tBoxIFSC = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label14 = New System.Windows.Forms.Label()
        Me.pBoxQR = New System.Windows.Forms.PictureBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.tBoxBankTxnNote = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.tBoxBankAmt = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.tBoxBankPayee = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnGenByBank = New System.Windows.Forms.Button()
        Me.tBoxAccNo = New System.Windows.Forms.TextBox()
        Me.tBoxTxnNote = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tBoxAmt = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tBoxVPAPayee = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnGenByUPI = New System.Windows.Forms.Button()
        Me.tBoxVPA = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        CType(Me.pBoxQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tBoxIFSC
        '
        Me.tBoxIFSC.Location = New System.Drawing.Point(488, 100)
        Me.tBoxIFSC.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxIFSC.Name = "tBoxIFSC"
        Me.tBoxIFSC.Size = New System.Drawing.Size(211, 20)
        Me.tBoxIFSC.TabIndex = 74
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(403, 103)
        Me.label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(51, 13)
        Me.label13.TabIndex = 73
        Me.label13.Text = "Ifsc code"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.IndianRed
        Me.panel1.Controls.Add(Me.label14)
        Me.panel1.Controls.Add(Me.pBoxQR)
        Me.panel1.Location = New System.Drawing.Point(37, 298)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(662, 345)
        Me.panel1.TabIndex = 72
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.ForeColor = System.Drawing.Color.White
        Me.label14.Location = New System.Drawing.Point(359, 96)
        Me.label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(138, 165)
        Me.label14.TabIndex = 52
        Me.label14.Text = "Scan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pay"
        '
        'pBoxQR
        '
        Me.pBoxQR.BackColor = System.Drawing.Color.Snow
        Me.pBoxQR.Location = New System.Drawing.Point(26, 27)
        Me.pBoxQR.Name = "pBoxQR"
        Me.pBoxQR.Size = New System.Drawing.Size(290, 290)
        Me.pBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pBoxQR.TabIndex = 53
        Me.pBoxQR.TabStop = False
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(402, 41)
        Me.label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(56, 20)
        Me.label12.TabIndex = 71
        Me.label12.Text = "BANK"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(33, 41)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(39, 20)
        Me.label11.TabIndex = 70
        Me.label11.Text = "UPI"
        '
        'tBoxBankTxnNote
        '
        Me.tBoxBankTxnNote.Location = New System.Drawing.Point(488, 190)
        Me.tBoxBankTxnNote.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxBankTxnNote.Name = "tBoxBankTxnNote"
        Me.tBoxBankTxnNote.Size = New System.Drawing.Size(211, 20)
        Me.tBoxBankTxnNote.TabIndex = 69
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(403, 193)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(51, 13)
        Me.label6.TabIndex = 68
        Me.label6.Text = "Txn Note"
        '
        'tBoxBankAmt
        '
        Me.tBoxBankAmt.Location = New System.Drawing.Point(488, 160)
        Me.tBoxBankAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxBankAmt.Name = "tBoxBankAmt"
        Me.tBoxBankAmt.Size = New System.Drawing.Size(211, 20)
        Me.tBoxBankAmt.TabIndex = 67
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(403, 163)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(43, 13)
        Me.label8.TabIndex = 66
        Me.label8.Text = "Amount"
        '
        'tBoxBankPayee
        '
        Me.tBoxBankPayee.Location = New System.Drawing.Point(488, 130)
        Me.tBoxBankPayee.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxBankPayee.Name = "tBoxBankPayee"
        Me.tBoxBankPayee.Size = New System.Drawing.Size(211, 20)
        Me.tBoxBankPayee.TabIndex = 65
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(403, 133)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(37, 13)
        Me.label9.TabIndex = 64
        Me.label9.Text = "Payee"
        '
        'btnGenByBank
        '
        Me.btnGenByBank.Location = New System.Drawing.Point(599, 220)
        Me.btnGenByBank.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenByBank.Name = "btnGenByBank"
        Me.btnGenByBank.Size = New System.Drawing.Size(100, 28)
        Me.btnGenByBank.TabIndex = 63
        Me.btnGenByBank.Text = "Generate"
        Me.btnGenByBank.UseVisualStyleBackColor = True
        '
        'tBoxAccNo
        '
        Me.tBoxAccNo.Location = New System.Drawing.Point(488, 67)
        Me.tBoxAccNo.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxAccNo.Name = "tBoxAccNo"
        Me.tBoxAccNo.Size = New System.Drawing.Size(211, 20)
        Me.tBoxAccNo.TabIndex = 62
        '
        'tBoxTxnNote
        '
        Me.tBoxTxnNote.Location = New System.Drawing.Point(119, 157)
        Me.tBoxTxnNote.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxTxnNote.Name = "tBoxTxnNote"
        Me.tBoxTxnNote.Size = New System.Drawing.Size(211, 20)
        Me.tBoxTxnNote.TabIndex = 60
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(34, 160)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(51, 13)
        Me.label5.TabIndex = 59
        Me.label5.Text = "Txn Note"
        '
        'tBoxAmt
        '
        Me.tBoxAmt.Location = New System.Drawing.Point(119, 127)
        Me.tBoxAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxAmt.Name = "tBoxAmt"
        Me.tBoxAmt.Size = New System.Drawing.Size(211, 20)
        Me.tBoxAmt.TabIndex = 58
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(34, 130)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(43, 13)
        Me.label3.TabIndex = 57
        Me.label3.Text = "Amount"
        '
        'tBoxVPAPayee
        '
        Me.tBoxVPAPayee.Location = New System.Drawing.Point(119, 97)
        Me.tBoxVPAPayee.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxVPAPayee.Name = "tBoxVPAPayee"
        Me.tBoxVPAPayee.Size = New System.Drawing.Size(211, 20)
        Me.tBoxVPAPayee.TabIndex = 56
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(34, 100)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(37, 13)
        Me.label2.TabIndex = 55
        Me.label2.Text = "Payee"
        '
        'btnGenByUPI
        '
        Me.btnGenByUPI.Location = New System.Drawing.Point(230, 187)
        Me.btnGenByUPI.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenByUPI.Name = "btnGenByUPI"
        Me.btnGenByUPI.Size = New System.Drawing.Size(100, 28)
        Me.btnGenByUPI.TabIndex = 54
        Me.btnGenByUPI.Text = "Generate"
        Me.btnGenByUPI.UseVisualStyleBackColor = True
        '
        'tBoxVPA
        '
        Me.tBoxVPA.Location = New System.Drawing.Point(119, 67)
        Me.tBoxVPA.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxVPA.Name = "tBoxVPA"
        Me.tBoxVPA.Size = New System.Drawing.Size(211, 20)
        Me.tBoxVPA.TabIndex = 53
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(34, 70)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 13)
        Me.label1.TabIndex = 52
        Me.label1.Text = "UPI/VPA ID"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(403, 70)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(42, 13)
        Me.label10.TabIndex = 61
        Me.label10.Text = "A/c No"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 684)
        Me.Controls.Add(Me.tBoxIFSC)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.tBoxBankTxnNote)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.tBoxBankAmt)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.tBoxBankPayee)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.btnGenByBank)
        Me.Controls.Add(Me.tBoxAccNo)
        Me.Controls.Add(Me.tBoxTxnNote)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.tBoxAmt)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.tBoxVPAPayee)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnGenByUPI)
        Me.Controls.Add(Me.tBoxVPA)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label10)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pBoxQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tBoxIFSC As TextBox
    Private WithEvents label13 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents label14 As Label
    Private WithEvents pBoxQR As PictureBox
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents tBoxBankTxnNote As TextBox
    Private WithEvents label6 As Label
    Private WithEvents tBoxBankAmt As TextBox
    Private WithEvents label8 As Label
    Private WithEvents tBoxBankPayee As TextBox
    Private WithEvents label9 As Label
    Private WithEvents btnGenByBank As Button
    Private WithEvents tBoxAccNo As TextBox
    Private WithEvents tBoxTxnNote As TextBox
    Private WithEvents label5 As Label
    Private WithEvents tBoxAmt As TextBox
    Private WithEvents label3 As Label
    Private WithEvents tBoxVPAPayee As TextBox
    Private WithEvents label2 As Label
    Private WithEvents btnGenByUPI As Button
    Private WithEvents tBoxVPA As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label10 As Label
End Class
