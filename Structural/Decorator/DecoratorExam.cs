using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DecoratorExam : IExam
    {
        private readonly IExam _exam;
        public DecoratorExam(IExam exam) => _exam = exam;

        public virtual void EnglishExam(int point) => _exam.EnglishExam(point);

        public virtual void StatisticsExam(int point) => _exam.StatisticsExam(point);
    }
}
