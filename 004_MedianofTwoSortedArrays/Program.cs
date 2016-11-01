using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_MedianofTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            int[] nums2 = { 0, 6 };
            Console.WriteLine((new Solution()).FindMedianSortedArrays(nums1, nums2).ToString());
            Console.ReadLine();
        }
    }
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double returnvalue = 0.0;

            int Cur1 = 0, Cur2 = 0;
            List<int> listMain = new List<int>();

            while (true)
            {
                if (Cur1 < nums1.Length)
                {
                    if (Cur2 < nums2.Length)
                    {
                        if (nums1[Cur1] < nums2[Cur2])
                        {
                            listMain.Add(nums1[Cur1]);
                            Cur1++;
                        }
                        else if (nums1[Cur1] > nums2[Cur2])
                        {
                            listMain.Add(nums2[Cur2]);
                            Cur2++;
                        }
                        else
                        {
                            listMain.Add(nums1[Cur1]);
                            listMain.Add(nums2[Cur2]);
                            Cur1++; Cur2++;
                        }
                    }
                    else
                    {
                        listMain.Add(nums1[Cur1]);
                        Cur1++;
                    }
                }
                else
                {
                    if (Cur2 < nums2.Length)
                    {
                        listMain.Add(nums2[Cur2]);
                        Cur2++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int counts = listMain.Count;
            if (counts % 2 == 0)
            {
                returnvalue = (listMain[counts / 2] + listMain[counts / 2 - 1]) / 2.0;
            }
            else
            {
                returnvalue = listMain[counts / 2];
            }

            return returnvalue;
        }
    }
}
