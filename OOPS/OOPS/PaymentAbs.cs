using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public abstract class Payment
    {
        public abstract void MakePayment(); // Abstract method

        public void PrintReceipt() // Concrete method
        {
            Console.WriteLine("Payment receipt generated.");
        }
    }

    public class CreditCardPayment : Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine("Processing credit card payment.");
        }
    }

    public class PayPalPayment : Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine("Processing PayPal payment.");
        }
    }

    class PaymentAbs
    {
        static void Main()
        {
            Payment payment1 = new CreditCardPayment();
            payment1.MakePayment(); // Output: Processing credit card payment.
            payment1.PrintReceipt(); // Output: Payment receipt generated.

            Payment payment2 = new PayPalPayment();
            payment2.MakePayment(); // Output: Processing PayPal payment.
            payment2.PrintReceipt(); // Output: Payment receipt generated.
        }
    }

}
