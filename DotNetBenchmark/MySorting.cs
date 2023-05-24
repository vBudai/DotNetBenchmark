﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortingClass
{
    public class MySorting
    {
        private const int arraySize = 65536; //2^16
        private int[] unsortedArray1 = new int[arraySize];
        private int[] unsortedArray2 = new int[arraySize];

        public MySorting()
        {
            Random rnd = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                int value = rnd.Next(256);
                unsortedArray1[i] = value;
                unsortedArray2[i] = value;
            }
        }


        public void BubbleSort()
        {

            int[] _array = unsortedArray1;

            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array.Length - 1 - i; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        Swap(ref _array[j], ref _array[j + 1]);
                    }
                }
            }
        }

        public void InsertionSort()
        {
            int x;
            int j;

            int[] inArray = unsortedArray1;

            for (int i = 1; i < inArray.Length; i++)
            {
                x = inArray[i];
                j = i;
                while (j > 0 && inArray[j - 1] > x)
                {
                    Swap(inArray, j, j - 1);
                    j -= 1;
                }
                inArray[j] = x;
            }
        }


        public static void Swap(ref int firstArg, ref int secondArg)
        {
            int tmpParam = firstArg;
            firstArg = secondArg;
            secondArg = tmpParam;
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

}
