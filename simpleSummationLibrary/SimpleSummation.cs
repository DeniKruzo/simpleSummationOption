using System.Runtime.InteropServices;

namespace simpleSummationLibrary
{
    public class SimpleSummation
    {

        private static bool CheckMemory<T>(T[] mass, long memoryLimiter)
        {

            long memoryBefore = GC.GetTotalMemory(false);

            long memorySize = GetArrayMemoryUsage<T>(mass.Length);

            if (memoryBefore + memorySize > memoryLimiter)
            {
                return false;
            }

            return true;
        }

        private static long GetArrayMemoryUsage<T>(int size)
        {

            long elementSize = Marshal.SizeOf(typeof(T));

            return elementSize * size;
        }

        private static (int, int) FindTwoMin(int[] arr)
        {
            long memoryLimiter = 1024 * 1024 * 1024;

            if (arr == null || arr.Length == 0)
                return (0, 0);

            if (arr.Length == 1)
                return (arr[0], 0);

            if (!CheckMemory(arr, memoryLimiter))
                throw new ArgumentException("Ошибка: Memory");
            

            int min1 = int.MaxValue;
            int min2 = int.MaxValue;

            foreach (int num in arr)
            {
                if (num < min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else if (num < min2 && num != min1)
                {
                    min2 = num;
                }
            }

            return (min1, min2);
        }

        public int SumTwoMin(int[] arr)
        {
    
            (int min1, int min2) = FindTwoMin(arr);

            return min1+ min2;
        }

    }
}