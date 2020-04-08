using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject
{
    public interface ISampleMathUtility
    {
        long Multiply(int x, int y);
        double Power(int x);
        int Max(int x, int y, int z);

        bool IsFirstGreater(int x, int y);
    }
}
