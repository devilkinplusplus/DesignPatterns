using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonTest
    {
        //Private edərək bu classdan obyekt yaradılmasına imkan vermirik
        private SingletonTest()
        {
        }

        #region Metod ile
        //Obyekt tələb olunarkən bu property-ni göndərəcəyik
        private static SingletonTest Instance;

        //Yuxarıdakı propertinin null olub olmadığını yoxladıqdan sonra göndəririk
        public static SingletonTest GetInstance() => Instance ?? (Instance = new SingletonTest());
        #endregion

        #region Properti ile
        //null kontroluna ehtiyac yoxdur
        public static SingletonTest GetInstanceProp
        {
            get { return Instance; }
        }

        //Statik constructor sadəcə 1 dəfə obyekt yaradılarkən çalışır,ən birinci işə düşəndir
        static SingletonTest()
        {
            Instance = new SingletonTest();
        }
        #endregion


        //Beləliklə,bu classdan istifadə edən zaman yalnız bir instance ilə istifadə etmək mümkün olacaq
    }
}
