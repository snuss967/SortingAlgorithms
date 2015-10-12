using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        int[] myArray = new int[10];
        Random rand = new Random();
        int tempIndex, tempVal, min, j;
        public void sort()
        {
            createArray();
            printArray();
            Console.ReadLine();
            min = 0;
            tempVal = 0;
            tempIndex = 0;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                min = i;
                // loops through each element of the array
                for (int j = min + 1; j < myArray.Length; j++)
                {
                   //loops through each element of the array a
                    if (myArray[j] < myArray[min])
                    {
                        min = j;

                    }
                }
                tempVal = myArray[i];
                myArray[i] = myArray[min];
                myArray[min] = tempVal;
            }
            printArray();
            Console.ReadLine();
        }

        private void printArray()
        {
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }
        }

        private void createArray()
        {
            for (int i = 0; i < myArray.Length -1; i++)
            {
                myArray[i] = rand.Next(1, 1000);
            }
        }
   }
}
