using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stable_matching
{
    class Program
    {
        static bool wPrefersM1OverM(int[,] prefer, int w, int m, int m1)
        {            
            for (int i = 0; i < 4; i++)
            {
                if (prefer[w,i] == m1)
                    return true;
                if (prefer[w,i] == m)
                   return false;
            }
            return false;
        }
        static void stableMarriage(int[,] prefer)
        {
            int[] wPartner = {-1,-1,-1,-1};
            bool[] mFree = {false, false, false, false};

            int freeCount = 4;
            while (freeCount > 0)
            {
                int m;
                for ( m = 0; m < 4; m++)
                    if (mFree[m] == false)
                        break;
                for (int i = 0; i < 4 && mFree[m] == false; i++)
                {
                    int w = prefer[m,i];
                    if (wPartner[w - 4] == -1)
                    {
                        wPartner[w - 4] = m;
                        mFree[m] = true;
                        freeCount--;
                    }
                    else
                    {
                        int m1 = wPartner[w-4];
                        if (wPrefersM1OverM(prefer, w, m, m1) == false)
                        {
                            wPartner[w-4] = m;
                            mFree[m] = true;
                            mFree[m1] = false;
                        }
                    }
                }
            }
            Console.WriteLine("Woman   Man");
            for (int i = 0; i < 4; i++)
                Console.WriteLine(" " +( i + 4 )+ "\t" + wPartner[i]);
        }
        static void Main(string[] args)
        {
            int[,] prefer = {  
                            {7, 5, 6, 4},
                            {5, 4, 6, 7},
                            {4, 5, 6, 7},
                            {4, 5, 6, 7},
                            {0, 1, 2, 3},
                            {0, 1, 2, 3},
                            {0, 1, 2, 3},
                            {0, 1, 2, 3},
                            };
            stableMarriage(prefer);
        }
    }
}