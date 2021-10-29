using System;

namespace Lab2
{
    class Program
    {
        static void WR(int[] outputData)
        {
            Console.WriteLine(string.Join(',', outputData));
        }

        static void Squ(int[] inputData)
        {
            for (int k = 0; k < inputData.Length; k++)
            {
                inputData[k] = inputData[k] * inputData[k];
            }
        }

        static void QuickSort(int[] data, int first, int last)
        {
            if (first < last)
            {
                int left = first;
                int right = last;
                int middle = data[(left + right) / 2];
                do
                {
                    while (data[left] < middle) left++;
                    while (data[right] > middle) right--;
                    if (left <= right)
                    {
                        (data[left], data[right]) = (data[right], data[left]);
                        left++;
                        right--;
                    }
                } while (left < right);

                QuickSort(data, first, right);
                QuickSort(data, left, last);
            }

            return;
        }

        static void Main()
        {
            int[] inputData = new int[] {-2, 45, 5, -12, 10};

            WR(inputData);
            Squ(inputData);
            WR(inputData);
            QuickSort(inputData, 0, inputData.Length - 1);
            WR(inputData);
        }
    }
}