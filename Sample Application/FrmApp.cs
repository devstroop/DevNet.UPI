using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Application
{
    public partial class FrmApp : Form
    {
        public FrmApp()
        {
            InitializeComponent();
        }

        private void btnGenByUPI_Click(object sender, EventArgs e)
        {
            DevNet.Models.VPA vpa = new DevNet.Models.VPA();
            vpa.VpaId = this.tBoxVPA.Text;
            vpa.PayeeName = this.tBoxVPAPayee.Text;
            try
            {
                vpa.Amount = double.Parse(this.tBoxAmt.Text);
            }
            catch 
            {
                vpa.Amount = null;
            }
            vpa.TxnNote = this.tBoxTxnNote.Text;
            var img = DevNet.UPI.Generate(vpa);
            this.pBoxQR.Image = img;
        }

        private void btnGenByBank_Click(object sender, EventArgs e)
        {
            DevNet.Models.Bank bank = new DevNet.Models.Bank();
            bank.AccountNo = this.tBoxAccNo.Text;
            bank.IfscCode = this.tBoxIFSC.Text;
            bank.PayeeName = this.tBoxBankPayee.Text;
            try
            {
                bank.Amount = double.Parse(this.tBoxBankAmt.Text);
            }
            catch
            {
                bank.Amount = null;
            }
            bank.TxnNote = this.tBoxBankTxnNote.Text;
            var img = DevNet.UPI.Generate(bank);
            this.pBoxQR.Image = img;
        }
    }
}
