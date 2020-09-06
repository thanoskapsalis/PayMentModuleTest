using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentModulle;
using SimplifyCommerce.Payments;

namespace PaymentModule
{

    public class SimplePay
    {

        //Αυτές οι μεταβλητές δεν υπάρχουν πλέον στο SDK οπότε υπολογίζω οτι δεν χρειάζονται με το Hosted Payments

       // PaymentsApi.PublicApiKey = "YourPublic key";
      //  PaymentsApi.PrivateApiKey = "YOUR_PRIVATE_KEY";

        public string MakePayment(PayModel pay)
        {
            PaymentsApi api = new PaymentsApi();
            Payment payment = new Payment();

            payment.Amount = pay.amount;
            payment.Description = "DESCRIPTION";
            payment.Reference = pay.reference;
            payment.Token = pay.cardToken;
            try
            {
                payment = (Payment) api.Create(payment); //Δεν έχω ελέγξει τι επιστρέφει το Payment
                return "success";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }


}
