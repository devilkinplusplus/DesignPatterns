using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SelfishStudent : DecoratorExam
    {
        private readonly IExam exam;
        public SelfishStudent(IExam exam) : base(exam) => this.exam = exam;

        public override void EnglishExam(int point)
        {
            base.EnglishExam(point);
            Console.WriteLine("Çox asan idi ee");
        }
    }
}
