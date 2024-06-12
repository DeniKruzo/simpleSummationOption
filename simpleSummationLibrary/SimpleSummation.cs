using System.Runtime.InteropServices;

namespace simpleSummationLibrary
{
    public class SimpleSummation
    {
        /// <summary>
        /// Сумма двух минимальных элементов
        /// </summary>
        /// <returns>Возвращает double</returns>
        public double SumOfTwoSmallest<T>(T[] mass) where T : IComparable
        {

            long memoryLimiter = 1024 * 1024 * 1024;

            if (mass == null || mass.Length == 0)
            {
                throw new ArgumentException("Ошибка: EmptyOrNull");
            }

            if (mass.Length < 2)
            {
                throw new ArgumentException("Ошибка: LessThanTwo");
            }

            if (!mass.All(x => x is int || x is double))
            {
                throw new ArgumentException("Ошибка: Type");
            }

            if (!CheckMemory(mass, memoryLimiter))
            {
                throw new ArgumentException("Ошибка: Memory");
            }


            Array.Sort(mass);

            return Convert.ToDouble(mass[0]) + Convert.ToDouble(mass[1]);

        }

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

    }
}