using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics1CSharp.Services
{
    internal class PrintService<T>
    {
        public T[] Values { get; private set; } = new T[10];
        public int Count { get;private set; } = 0;
        public void AddValue(T value)
        {
            if(Count == 10)
            {
                throw new InvalidOperationException("PrintService is Full");
            }
            Values[Count] = value;
            Count++;
        }
        public T First()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("PrintService is Empty");
            }
            return Values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < Count - 1; i++)
            {
                Console.Write(Values[i] + ", ");
            }
            if(Count > 0)
            {
                Console.Write(Values[Count - 1]);
            }
            Console.Write("]");
        }
    }
}
