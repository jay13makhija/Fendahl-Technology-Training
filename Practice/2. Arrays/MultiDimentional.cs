using System;

class multiDimenstional
{
	public static void MultiDimentional()
    {
        int[,] MultiDArray = new int[3,3];
        for(int i=0; i< 3; i++)
        {
            for(int j=0; j < 3; j++)
            {
                Console.WriteLine("Enter elements for the array");
                MultiDArray[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(MultiDArray[i, j]); 
            }
        }

    }
}