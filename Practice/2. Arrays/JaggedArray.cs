using System;

public class jagged
{
    public static void JaggedArray()
    {
        int[][] J_Array = new int[3][];

        J_Array[0] = new int[3] {10, 11, 14};
        J_Array[1] = new int[2] {7, 8};
        J_Array[2] = new int[4] {2, 3, 5, 6};


        for(int i=0; i<J_Array.Length; i++)
        {
            for(int j=0; j < J_Array[i].Length; j++)
            {
                Console.Write(J_Array[i][j] + " ");
            }
        }
    }
}