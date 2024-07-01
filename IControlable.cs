using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Интерфейсы_и_обобщения
{
    public interface IControlable
    {
        bool IsOn { get;}

        public void On(); //Методы для контроля состояния подключаемого устройства
        public void Off();
    }
}
