using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfTest
{
    static class Test
    {
        static public int score = 0;
        static public bool toStart = false;
        static public bool Exit = false;

        static public string GetResult()
        {
            if (score == 1) return "Очень плохо:_( Пройдите курс Основы программирования на geekbrains.ru";
            if (score == 2) return "Плохо:( Иди на geekbrains.ru и гризи гранит науки!";
            if (score == 3) return "Плохо. Пройдите парочку курсов по С# на geekbrains.ru";
            if (score == 4) return "Нормально. Развивайтесь, потенциал у вас есть!";
            if (score == 5) return "Нормально. Хорошая почва для будуюшего професионала.";
            if (score == 6) return "Хопошо. Нужно еще немного подучить и будет отлично.";
            if (score == 7) return "Хорошо. Работодатель будет рад с вами сотрудничать.";
            if (score == 8) return "Очень хорошо! Вы наверное сотрудник Microsoft.";
            if (score == 9) return "Превосхождно! Евгений Картавец, вы ли это?";
            if (score == 10) return "Идеально! Бил Гейтс, вы ли это?";
            else return "Вы вообще проходили тест?";
        }
    }
}
