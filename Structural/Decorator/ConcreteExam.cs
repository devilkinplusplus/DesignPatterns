using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //Normal tələbələr:
    public class ConcreteExam : IExam
    {
        public void EnglishExam(int point) => Console.WriteLine($"İngilis dilinden {point} aldim");

        public void StatisticsExam(int point) => Console.WriteLine($"Statistikadan {point} aldim");
    }
}
