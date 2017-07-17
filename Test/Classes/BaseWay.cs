using Test.Interfaces;

namespace Test.Classes
{
    public abstract class BaseWay<T> : IWay<T>
    {
        public abstract T GetWaysNumber();
    }
}
