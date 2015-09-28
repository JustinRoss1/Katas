using System;
using Katarai.FizzBuzz.Interfaces;

namespace PlayerFizzBuzz
{
    public class FizzBuzz : IFizzBuzz
    {
        public string GetFizzBuzz(int input)
        {
            if (input % 15 == 0) return "FizzBuzz";
            if (input % 3 == 0) return "Fizz";
            if (input % 5 == 0) return "Buzz";
            return input.ToString();
        }
    }
}
