using System;
using System.Collections;

namespace SortingAndStrategyPattern
{
    public class DataService
    {
        private Random random;

        public DataService()
        {
            random = new Random();
        }
        public int[] GenerateIntArray(int length = 5)
        {
            int[] integerArray = new int[length];
            for(int i = 0; i < length; i++)
            {
                integerArray[i] = random.Next();
            }
            return integerArray;
        }

        public List<int> GenerateIntList(int count = 5)
        {
            var integerList = new List<int>();
            for(int i = 0; i < count; i++)
            {
                integerList.Add(random.Next());
            }
            return integerList;
        }
    }
}