using System;

namespace Specials
{
    class Program
    {
        static void Main()
        {
            //double
            Console.WriteLine("max value for double " + double.MaxValue);
            Console.WriteLine("min value for double " + double.MinValue);
            //float
            Console.WriteLine("max value for decimal " + decimal.MaxValue);
            Console.WriteLine("min value for decimal " + decimal.MinValue);
            //decimal
            Console.WriteLine("max value for float " + float.MaxValue);
            Console.WriteLine("min value for float " + float.MinValue);
            //short
            Console.WriteLine("max value for short" + short.MaxValue);
            Console.WriteLine("min value for short" + short.MinValue);
            //ushort
            Console.WriteLine("max value for ushort" + ushort.MaxValue);
            Console.WriteLine("min value for ushort" + ushort.MinValue);
            //sbyte
            Console.WriteLine("max value for sbyte " + sbyte.MaxValue);
            Console.WriteLine("min value for sbyte " + sbyte.MinValue);
            //byte
            Console.WriteLine("max value for byte " + byte.MaxValue);
            Console.WriteLine("min value for byte " + byte.MinValue);
            //ulong
            Console.WriteLine("max value for ulong " + ulong.MaxValue);
            Console.WriteLine("min value for ulong " + ulong.MinValue);
            //long
            Console.WriteLine("max value for long" + long.MaxValue);
            Console.WriteLine("min value for long" + long.MinValue);
            //int
            Console.WriteLine("max value for int " + int.MaxValue);
            Console.WriteLine("min value for int " + int.MinValue);
            //uint
            Console.WriteLine("max value for uint " + uint.MaxValue);
            Console.WriteLine("min value for uint " + uint.MinValue);
            //char
            Console.WriteLine("max value for char " + char.MaxValue);
            Console.WriteLine("min value for char " + char.MinValue);

            //Special values
            Console.WriteLine("double positive infinity " + double.PositiveInfinity);
            Console.WriteLine("double negative infinity " + double.NegativeInfinity);
            Console.WriteLine("float positive infinity " + float.PositiveInfinity);
            Console.WriteLine("float negative infinity " + float.NegativeInfinity);
            Console.WriteLine("double NaN " + double.PositiveInfinity / double.PositiveInfinity);
            Console.WriteLine("float NaN " + float.NaN);

            //overflow
            int i = int.MaxValue;
            Console.WriteLine("overflow int " + (i + (int)1));
            short s = short.MaxValue;
            Console.WriteLine("overflow short " + (s + (int)1));
            long l = long.MaxValue;
            Console.WriteLine("overflow long " + (l + (int)1));
            double d = double.MaxValue;
            Console.WriteLine("overflow double " + (d * 2));
            byte b = byte.MaxValue;
            Console.WriteLine("overflow byte " + (Math.Pow(b, b)));
            float f = float.MaxValue;
            Console.WriteLine("overflow float " + (f * 2));

            //underflow
            double db = double.MinValue;
            Console.WriteLine("underflow double " + (db -= -db * 2));
            float f1 , f2;
            f1 = f2 = 10000.0f;
            Console.WriteLine("underflow float " + (f1 == f2 + 0.0001f));
        }
    }
}