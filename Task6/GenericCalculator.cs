using System;
namespace Task6
{

    public class Calculator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public T Add(T number1, T number2)
        {
            return (dynamic)number1 + (dynamic)number2;
        }

        public T Subtract(T number1, T number2)
        {
            return (dynamic)number1 - (dynamic)number2;
        }

        public T Multiply(T number1, T number2)
        {
            return (dynamic)number1 * (dynamic)number2;
        }

        public T Divide(T number1, T number2)
        {
            if ((dynamic)number2 == 0)
            {
                Console.WriteLine("Number cannot divided by zero");
            }
            return (dynamic)number1 / (dynamic)number2;
        }
    }
}
