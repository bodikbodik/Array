using System;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        public static void ChangeElementsInArray(int[] nums)
        {
            for(int i = 0; i < nums.Length / 2; i++)
            {
                int temp = 0;
                if (nums[i] % 2 == 0 && nums[nums.Length - 1 - i] % 2 == 0)
                {
                    temp = nums[i];

                    nums[i] = nums[nums.Length -1 -i];
                    nums [nums.Length -1 -i] = temp;
                }
            }
         
        }

  
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            int indexFirstMax = 0;
            int indexLastMax = 0;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[indexFirstMax] < nums[i] )
                {
                    indexFirstMax = i;
                }
                if (nums[indexLastMax] <= nums[i])
                {
                    indexLastMax = i;
                }
            }
            return indexLastMax - indexFirstMax ;

        }

        public static void ChangeMatrixDiagonally(int[,] matrix)
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    matrix[i, j] = 0;
                    matrix[j, i] = 1;
                }
            }
            
        }
    }
}
