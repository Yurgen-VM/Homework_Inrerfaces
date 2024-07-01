using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Интерфейсы_и_обобщения
{
    internal class Device: IControlable
    {
        public bool IsOn { get; private set; } = false;

        public void Off()
        {
            IsOn = false;            
        }

        public void On()
        {
            IsOn = true;           
        }
    }
}
