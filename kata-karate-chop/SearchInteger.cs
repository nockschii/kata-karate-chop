using System;

namespace kata_karate_chop
{
    public class SearchInteger
    { 
        public int chop(int target, int[] hayStack)
        {
            if (isEmpty(hayStack))
            {
                return -1;
            }

            return Array.FindIndex(hayStack, element => element == target);
        }

        private bool isEmpty(int[] hayStack)
        {
            return hayStack == null || hayStack.Length == 0;
        }
    }
}