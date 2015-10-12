using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortTry2
{
    class Bubble
    {

        /*
        This is a bubble sort it goes through your array and takes to numbers if the first is greater than the second
        it swaps them if it is not it leaves them be for a video expalning the bubble sort please visit
         https://www.youtube.com/watch?v=P00xJgWzz2c
        */
        int[] myArray; // creates the reference outside of the intializion so that it has class scope
        private void createArray()
        {
            //creates an array with ten elements
            myArray = new int[10];
            {
                myArray[0] = 13;
                myArray[1] = 43;
                myArray[2] = 43;
                myArray[3] = 65;
                myArray[4] = 4;
                myArray[5] = 654;
                myArray[6] = 14;
                myArray[7] = 541;
                myArray[8] = 4341;
                myArray[9] = 143134;
            }
        }

        private void printArray()
        {
            //prints each element of the array
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }
        }
        public void sort()
        {

            createArray();
            //calls the create array method
            printArray(); 
            //prints the elements of the array

            //added for readability
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // added for readability


            for (int i = 0; i < myArray.Length; i++)
            {
                //loop through each element of the array
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    //loops through the all of the possibilites for the one coming after the first element
                    if (myArray[j] > myArray[j + 1])
                    {
                        //compares the first with the one immediatly after
                        int temp = myArray[j + 1];
                        //if the first is greater then the second the second is set equal to a temporary integer
                        myArray[j + 1] = myArray[j];
                        //the second is then set equal to the first
                        myArray[j] = temp;
                        //the first is then set equal to the original value of the 1st
                    }
                }
            }
            printArray();
            Console.ReadLine();
        }
    }
}
