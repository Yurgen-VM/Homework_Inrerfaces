using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Интерфейсы_и_обобщения
{
    public class Bits : IGetSetBits
    {
        public long Value { get; set; }
        public int Size { get; set; }


        public Bits(byte value)
        {
            Value = value;
            Size = sizeof(byte);
        }

        public Bits(int value)
        {
            Value = value;
            Size = sizeof(int);
        }

        public Bits(long value)
        {
            Value = value;
            Size = sizeof(long);
        }

        public bool GetBitByIndex(byte index)
        {
            return (Value & (1 << index)) != 0;
        }

        public void SetBitByIndex(byte index, bool value)
        {
            if (value)
            {
                Value |= (byte)(1 << index);
            }
            else
            {
                Value &= (byte)~(1 << index);
            }

        }

        public bool this[byte index]
        {
            get => GetBitByIndex(index);
            set => SetBitByIndex(index, value);
        }

        public void PrintBits()
        {
            Console.WriteLine($"{Value}");
        }

        // Домашнее задание.
        // Задача. Реализовать операторы явного и неявного преобразования byte, int ,long в Bits


        public static implicit operator Bits(byte value) => new Bits(value);  // Неявное приведение типа byte в Bits
        public static implicit operator Bits(int value) => new Bits(value);   // Невное приведение типа int в Bits
        public static implicit operator Bits(long value) => new Bits(value);  // Неявное приведение типа long в Bits          

        public static explicit operator long(Bits bits) => bits.Value;  // Явное приведение типа Bits в long

    }
}
