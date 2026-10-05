using System;
using System.Collections.Generic;
using System.Text;

namespace Pr14_WinnieAndTigger
{
    public class JumpHelper
    {
        static public string CalculateMeetingPoint(int tiggerStart, int tiggerSpeed, int winnieStart, int winnieSpeed)
        {
            while (tiggerStart < 10_000 && winnieStart < 10_000)
            {
                if (tiggerStart == winnieStart)
                {
                    return $"{tiggerStart},{winnieStart}";
                }
                tiggerStart += tiggerSpeed;
                winnieStart += winnieSpeed;
            }

            return "NO";
        }
    }
}
