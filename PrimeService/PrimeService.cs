﻿using System;

namespace Prime.Services
{
    public class PrimeService
    {
        
        // Fail test code block
        public bool IsPrime(int candidate)
        {
            throw new NotImplementedException("Not implemented.");
        }
        // error out darnit
        
        // Pass test code block
        /* public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        } */
    }
}
