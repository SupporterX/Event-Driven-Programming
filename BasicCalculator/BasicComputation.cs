using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public static class BasicComputation
    {
        public static float Add(float a, float b) => a + b;

        public static float Subtract(float a, float b) => a - b;

        public static float Multiply(float a, float b) => a * b;

        public static float Divide(float a, float b) => b != 0 ? a / b : 0;

    }
}