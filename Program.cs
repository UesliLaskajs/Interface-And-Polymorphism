﻿namespace Interface
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            //IAnimal cat = new Cat();
            //cat.MakeSound();

            //IProcessPayments creditPayments = new CreditPayments();//Instantiated the credit Payment class from the Interface that will use later the method of interface
            //PaymentService paymentService = new PaymentService(creditPayments);//Instantiated the Class that will get the processor object creditPayment
            //paymentService.ProccesOrderPayment(20.00m);//Called The method of the object 

            //IProcessPayments bankPayment=new Payments();//Same for BankPayment Class
            //paymentService=new PaymentService(bankPayment);
            //paymentService.ProccesOrderPayment(100.00m);


            //string directoryPath = @"C:\Logs";
            //string filePath = Path.Combine(directoryPath, "log.txt");

            //if (!Directory.Exists(directoryPath))
            //{
            //    Directory.CreateDirectory(directoryPath);
            //}

            //File.AppendAllText(filePath, "Hello Uesli" + "\n");

            

            ILogger simpleLogger = new Logger();
            Application app=new Application(simpleLogger);
            app.DisplayLog();

            ILogger file = new FileLogger();
            app=new Application(file);

        
            app.DisplayLog();






            Console.ReadKey();
        }

        public interface IAnimal
        {
            void MakeSound();
            string Name(string name);
        }


        class Cat : IAnimal
        {
            void IAnimal.MakeSound()
            {
                Console.WriteLine("Meowwww");
            }
            
             string IAnimal.Name(string name)
            {
                Console.WriteLine(name);
                return name;
            }
        }

    }
}
