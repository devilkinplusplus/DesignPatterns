using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Creator
    {
        private readonly DatabaseFactory _databaseFactory;
        private readonly Connection _connection;
        private readonly Command _command;
        public Creator(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _command = databaseFactory.CreateCommand();
            _connection = databaseFactory.CreateConnection();

            //Call this method when object creating
            Start();
        }

        private void Start()
        {
            if(_connection.State == "Open")
            {
                _connection.Connect();
                _command.Execute("Select * From ...");
                _connection.DisConnect();
            }
        }

    }
}
