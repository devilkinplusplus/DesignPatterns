using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //Deyək ki,zaman keçdikcə bəzi tələbələr statistika imtahanına ağlamadan girə bilmir,
    //bu durumda öncə ağlayıb sonra imtahana girəcəklər
    //2-ci senaryoda isə ingilis dili imtahanından çıxan bəzi tələbələr "imtahan çox asan idi" demese olmaz
    //İndi metodlara bu xüsusiyyətləri əlavə edək
    //Amma her tələbə belə demediyi kimi,hər metod da belə çalışmayacaq
    public interface IExam
    {
        void StatisticsExam(int point);
        void EnglishExam(int point);
    }
}
