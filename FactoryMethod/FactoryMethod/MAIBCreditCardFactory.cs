using System;
namespace FactoryMethod
{
    public class MAIBCreditCardFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public MAIBCreditCardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditClass GetCreditCard()
        {
            return new MAIBCreditCard(_creditLimit, _annualCharge);
        }
    }
}
