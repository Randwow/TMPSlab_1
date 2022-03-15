using System;

namespace FactoryMethod
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.Write("Enter the card type you would like to visit: ");
            string nameOfBank = Console.ReadLine();

            switch (nameOfBank.ToLower())
            {
                case "procredit":
                    factory = new ProCreditBankFactory(50000, 100);
                    break;
                case "maib":
                    factory = new MAIBCreditCardFactory(100000, 500);
                    break;
                case "micb":
                    factory = new MICBCreditCardFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditClass creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();
        }
    }
}
