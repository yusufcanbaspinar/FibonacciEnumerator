using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FibonacciEnumerator1
{
    class Program
    {
        static void Main(string[] args)
        {
                FibonacciNumbers f = new FibonacciNumbers(200000);
                foreach (int n in f)
                {
                    Console.WriteLine(n);
                }
                Console.ReadKey();
        }
    }
    }
    class FibonacciNumbers : IEnumerable
    {
        private FibonacciEnumerator iter;
        public FibonacciNumbers(int max)
        {
            iter = new FibonacciEnumerator(max);
        }
        public IEnumerator GetEnumerator()
        {
            return iter;
        }
    }
    class FibonacciEnumerator : IEnumerator
    {
        private int currentNumber, nextNumber, maxNumber;
        public FibonacciEnumerator(int max)
        {
            maxNumber = max;
            Reset();
        }
        public object Current { get { return currentNumber; } }
        public bool MoveNext()
        {
            int newNextNumber = currentNumber + nextNumber;
            currentNumber = nextNumber;
            nextNumber = newNextNumber;

            return currentNumber <= maxNumber;
        }
        public void Reset()
        {
            currentNumber = 0;
            nextNumber = 1;
        }
    }

