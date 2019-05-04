using System;

class BinaryGap
{
    public int BinaryGap(int N)
    {
        int binaryGap = 0;
        bool firstTime = true;
        int prevBit = 0, currentBit = 0, i = 0;
        if ((N & N - 1) == 0 || N == 0)
            return binaryGap;
        while (N > 0)
        {
            if ((N & 1 << i) != 0)
            {
                prevBit = firstTime ? i : currentBit;
                firstTime = false;
                currentBit = i;
                N = N & (N - 1);
            }
            i++;
            int diffBit = currentBit - prevBit;
            binaryGap = diffBit > binaryGap ? diffBit - 1 : binaryGap;
        }
        return binaryGap;
    }
}