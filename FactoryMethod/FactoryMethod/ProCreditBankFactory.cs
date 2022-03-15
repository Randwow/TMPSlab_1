using System;
namespace FactoryMethod
{
    public class ProCreditBankFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public ProCreditBankFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditClass GetCreditCard()
        {
            return new ProCreditBankCreditCard(_creditLimit, _annualCharge);
        }
    }
}
