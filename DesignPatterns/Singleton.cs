using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Singleton
    {
        //Private edərək bu classdan obyekt yaradılmasına imkan vermirik
        private Singleton()
        {
        }

        #region Metod ile
        //Obyekt tələb olunarkən bu property-ni göndərəcəyik
        private static Singleton Instance;

        //Yuxarıdakı propertinin null olub olmadığını yoxladıqdan sonra göndəririk
        public static Singleton GetInstance() => Instance ?? (Instance = new Singleton());
        #endregion

        #region Properti ile
        //null kontroluna ehtiyac yoxdur
        public static Singleton GetInstanceProp
        {
            get { return Instance; }
        }

        //Statik constructor sadəcə 1 dəfə obyekt yaradılarkən çalışır,ən birinci işə düşəndir
        static Singleton()
        {
            Instance = new Singleton();
        }
        #endregion


        //Beləliklə,bu classdan istifadə edən zaman yalnız bir instance ilə istifadə etmək mümkün olacaq
    }
}
