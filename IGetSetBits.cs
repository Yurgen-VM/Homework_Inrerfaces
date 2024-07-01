using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Интерфейсы_и_обобщения
{
    public interface IGetSetBits
    {
        
        public bool GetBitByIndex( byte index);
        public void SetBitByIndex( byte index, bool value);
    }


   





}


