namespace SampleProject
{
    using System;

    public class SampleMathUtility : ISampleMathUtility
    {
        private IMultiplier Multiplier { get; set; }
        public SampleMathUtility(IMultiplier multiplier)
        {
            this.Multiplier = multiplier;
        }

        public long Multiply(int x, int y)
        {
            return this.Multiplier.Multiply(x, y);
        }

        public double Power(int x)
        {
            return Math.Pow(x, x);
        }

        public bool IsFirstGreater(int x, int y)
        {
            if(x > y)
            {
                return true;
            }

            return false;

            //return Math.Max(x, y);
        }

        public int Max(int x, int y, int z)
        {
            var max = x;

            if (y > max)
            {
                max = y;
            }

            if (z > max)
            {
                max = z;
            }

            return max;
        }
    }
}
