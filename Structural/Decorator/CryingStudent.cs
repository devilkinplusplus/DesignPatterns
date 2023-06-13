using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CryingStudent : DecoratorExam
    {
        private readonly IExam exam;
        public CryingStudent(IExam exam) : base(exam) => this.exam = exam;

        public override void StatisticsExam(int point)
        {
            Console.WriteLine("Ühühühü kesilecem.");
            base.StatisticsExam(point);
        }

    }
}
