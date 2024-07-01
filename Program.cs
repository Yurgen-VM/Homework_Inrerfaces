using Lesson_2_Интерфейсы_и_обобщения;

namespace Task_1

{
    /*
      
     Спроектируйте интерфейс для класса способного устанавливать и получать значения отдельных бит в заданном числе.
    
     */
       

    internal class Program
    {
        static void Main(string[] args)
        {
            Bits bits = new Bits(4);

            bits.SetBitByIndex(0, true); // Устанавливаем 1 по указанному индексу
            //Console.WriteLine(bits.GetBitByIndex(1)); // Проверяем (запрашиваем) значение бита по указанному индексу 
            //Console.WriteLine(bits);
            //Console.WriteLine();


            // Вывод информации после переопределения операторов
            
            Bits bits_2 = new Bits(5);
            long val = bits_2.Value;
            //Console.WriteLine(val);
            //Console.WriteLine();


            // Задача 2. Предположим, у вас есть некоторый набор устройств, каждое из которых может быть включено или выключено,
            // и вы хотите иметь возможность выполнять операции над этими устройствами через битовые операторы.

            // По умолчанию все устройства отключены
            
            Devices devices = new Devices();
            Bits bits_3 = new Bits(6); // создаем управляющий байт 
            //Console.WriteLine(devices);
            devices.TurnOnOff(bits_3); // пердаем управляющий байт 
            //Console.WriteLine(devices);


            Bits bit = new Bits(100);                 
            Bits bitByte = new Bits((byte)10);
            Bits bitInt = new Bits((int)11);
            Bits bitLong = new Bits((long)12);


           
            
            
            // Домашнее задание.
            // Задача. Реализовать операторы явного и неявного преобразования byte, int ,long в Bits


            // Реализация выполнена в классе Bits 

            Console.WriteLine("\nНеявные преобразования\n");

            byte byteNum = 255;
            Bits byteToBits = byteNum; // Неявное преобразование byte в Bits
            byteToBits.PrintBits();

            int intNum = 256256;
            Bits intToBits = intNum; // Неявное преобразование int в Bits
            intToBits.PrintBits();

            long longNum = 123456789123456789;
            Bits longToBits = longNum; // Неявное преобразование int в Bits
            longToBits.PrintBits();

            Console.WriteLine("\nЯвные преобразования\n");

            byte byteNumEx = 128;
            Bits byteToBitsEx = (Bits)byteNumEx; // Явное преобразование byte в Bits
            byteToBitsEx.PrintBits();

            int intNumEx = 12356789;
            Bits intToBitsEx = (Bits)intNumEx; // Явное преобразование int в Bits
            intToBitsEx.PrintBits();

            long longNumEx = 123456789123456789;
            Bits longToBitsEx = (Bits)longNumEx; // Явное преобразование int в Bits
            longToBitsEx.PrintBits();

           

            Console.ReadLine();
        }
    }
}
