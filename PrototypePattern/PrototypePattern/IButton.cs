using System;
namespace PrototypePattern
{
    interface IButton
    {
        IButton Clone();
        void GetInfo();
    }
}
