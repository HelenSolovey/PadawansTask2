﻿using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static void Expression()
        {
            Console.Write("Erorr");
        }
        public static long Calculate(int number, int add, int count)
        {
          if(count< 1)
            {
                throw new ArgumentException();
            }
            int sum = 0;
            for (int i = 0; i < count; i++)
                sum += number + i * add;
              
            return (long)sum ;
        } }

}
