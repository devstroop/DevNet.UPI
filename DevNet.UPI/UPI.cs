using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNet
{
    public class UPI
    {

        private static string GetPaymentURL(string vpa, string payeeName, string txnId = "", double? amount = null, string currencyCode = "INR", string txnNote = "") 
        {
            if (amount == null)
            {
                return $"upi://pay?cu={currencyCode}&pa={vpa}&pn={payeeName}&tr={txnId}&am=0&mode=01&purpose=10&orgid=-&sign=-&tn={txnNote}";
            }
            return $"upi://pay?cu={currencyCode}&pa={vpa}&pn={payeeName}&tr={txnId}&am={amount}&mode=01&purpose=10&orgid=-&sign=-&tn={txnNote}";
        }
        public static Bitmap Generate(Models.Bank bank)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(GetPaymentURL(
                vpa: $"{bank.AccountNo}@{bank.IfscCode}.ifsc.npci",
                payeeName: bank.PayeeName,
                amount: bank.Amount,
                currencyCode: "INR",
                txnNote: bank.TxnNote
                ), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }

        public static Bitmap Generate(Models.VPA vpa)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(GetPaymentURL(
                vpa: vpa.VpaId,
                payeeName: vpa.PayeeName,
                amount: vpa.Amount,
                currencyCode: "INR",
                txnNote: vpa.TxnNote
                ), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }
    }
}
