
public class MyShell {
	int[] numArray;
	private void createArray()
	{
		numArray = new int[10];
		numArray[0] = 55;
		numArray[1] = 768735;
		numArray[2] = 545434;
		numArray[3] = 2425;
		numArray[4] = 77573;
		numArray[5] = 2424;
		numArray[6] = 545;
		numArray[7] = 552;
		numArray[8] = 555;
		numArray[9] = 42;
	}
	public void sort()
	{
		/* The benefit that an shell sort provides is that it pre-sorts the data for the insertion sort so that the insertion
		 * sort can run more effectively upon its implementation. This is a big deal as as we discussed last week in class when a number gets 
		 * inserted into the front of an array everything has to be shifted down. The shell sort minimizes the number of shifts. Helped with implementation from 
		 * RosettaCode, Wikipedia, and  New Think Tank*/
		createArray();
		int gap = (numArray.length) / 2;
		while( gap > 0)
		{
		for (int i = gap; i < numArray.length; i++)
		{
		   
			int j = i; // j serves as the number on which we do computations as using I would mess up the for loop
			int temp = numArray[i]; //stores the original value of the i index which will be overwritten
			//this is our modified insertion sort We will make sure that j is greatet then gap which is effectively our 0 and will run as long as
			//we need to move numbers down due to the nature of array shifts
			while(j >= gap && numArray[j - gap] > temp)
			{
				numArray[j] = numArray[j - gap];
				j = j -gap;
			}
			numArray[j] = temp;
		}
		if(gap == 2)
		{
			gap =1;
		}
		else
		{
			gap *= (5.0 / 11);
		}
		}
		printArray();
	}
	
	private void printArray()
	{
		for(int number: numArray)
		{
			System.out.println(number);
		}
	}

}
