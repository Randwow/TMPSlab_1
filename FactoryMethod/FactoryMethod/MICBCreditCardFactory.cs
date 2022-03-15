using System;
namespace FactoryMethod
{
    public class MICBCreditCardFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public MICBCreditCardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditClass GetCreditCard()
        {
            return new MICBCreditCard(_creditLimit, _annualCharge);
        }
    }
}
