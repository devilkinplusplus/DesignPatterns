using AbstractFactory;
using AbstractFactory.ConcreteFactory;

Creator create = new Creator(new SqlDatabase());

Console.WriteLine("------------------------");

create = new Creator(new MySqlDatabase());