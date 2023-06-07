using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
