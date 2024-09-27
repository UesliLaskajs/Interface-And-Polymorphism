using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IProcessPayments//Created an Interface for a void Method Payment Amount Passing
    {
        void PaymentProccessor(decimal amount);
    }

    public class Payments : IProcessPayments//Inerited From Interface
    {
        public void PaymentProccessor(decimal amount)//Used The inherited Method From interface
        {
            Console.WriteLine($"Payment Amount:{amount}$ processed");
        }
    }

    public class CreditPayments : IProcessPayments
    {
        public void PaymentProccessor(decimal amount)
        {
            Console.WriteLine($"Credit Payment Amount:{amount}$ processed");
        }
    }

    public class PaymentService//Created Another Class for Proccessing 2 classed above in the main method
    {
        private readonly IProcessPayments _processPayments;//private readonly field that stores the object proccesor that will be initialized in main Method

        public PaymentService(IProcessPayments processor)//Constructor that calls the passed object from main method into the member field
        {
            _processPayments= processor;    
        }

        public void ProccesOrderPayment(decimal amount)//Class created 
        {
            _processPayments.PaymentProccessor(amount);//From the proccessor object created in the main method used the inherited PaymentProccesor of the Interface
        }

    }
}
