using System;
namespace FactoryMethod
{
    public abstract class CardFactory
    {
        public abstract CreditClass GetCreditCard();
    }
}
