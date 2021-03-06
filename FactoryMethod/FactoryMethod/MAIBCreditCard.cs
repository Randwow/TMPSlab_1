using System;
namespace FactoryMethod
{
    public class MAIBCreditCard : CreditClass
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public MAIBCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "MAIB credit card";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType
        {
            get { return _cardType; }
        }

        public override int CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

        public override int AnnualCharge
        {
            get { return _annualCharge; }
            set { _annualCharge = value; }
        }
    }
}
