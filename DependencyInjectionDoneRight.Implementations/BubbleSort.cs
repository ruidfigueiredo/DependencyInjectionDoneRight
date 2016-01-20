using System;
using DependencyInjectionDoneRight.Abstractions;

namespace DependencyInjectionDoneRight.Implementations
{
    public class BubbleSort : ISorter
    {
        public int[] Sort(int[] numbers)
        {
            if (numbers == null) throw new ArgumentNullException("numbers");
            if (numbers.Length < 1) return numbers;
            bool wereThereAnySwaps;
            do
            {
                wereThereAnySwaps = false;
                for (var i = 0; i < numbers.Length - 1; i++)
                    if (numbers[i + 1] < numbers[i])
                    {
                        int numberBeingSwapped = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = numberBeingSwapped;
                        wereThereAnySwaps = true;
                    }
            } while (wereThereAnySwaps);

            return numbers;

        }
    }
}
