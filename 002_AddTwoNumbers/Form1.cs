//You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _002_AddTwoNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] intA = new int[] { 1 };
            int[] intB = new int[] { 9, 9 };
            ListNode lnA = PushNodes(intA), lnB = PushNodes(intB);

            ListNode Result = (new Solution()).AddTwoNumbers(lnA, lnB);
        }

        private ListNode PushNodes(int[] DataToPush)
        {
            ListNode InitNode = new ListNode(DataToPush[0]);
            ListNode tempNode = InitNode;
            for (int i = 1; i < DataToPush.Length; i++)
            {
                tempNode.next = new ListNode(DataToPush[i]);
                tempNode = tempNode.next;
            }
            return InitNode;
        }

        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode EmptyNode = new ListNode(0);
                ListNode ReturnLN = new ListNode((l1.val + l2.val) % 10);
                ListNode CurrentNode1 = l1, CurrentNode2 = l2, CurrentNode = ReturnLN;
                bool Carry = l1.val + l2.val > 9;

                while ((CurrentNode1 != null && CurrentNode1.next != null) || (CurrentNode2 != null && CurrentNode2.next != null))
                {
                    int IntA, IntB;
                    if (CurrentNode1 == null || CurrentNode1.next == null) { IntA = 0; } else { IntA = CurrentNode1.next.val; }
                    if (CurrentNode2 == null || CurrentNode2.next == null) { IntB = 0; } else { IntB = CurrentNode2.next.val; }
                    int tempSum = IntA + IntB + (Carry ? 1 : 0);
                    CurrentNode.next = new ListNode(tempSum % 10);
                    Carry = tempSum > 9;
                    CurrentNode = CurrentNode.next == null ? null : CurrentNode.next;
                    CurrentNode1 = CurrentNode1 == null || CurrentNode1.next == null ? null : CurrentNode1.next;
                    CurrentNode2 = CurrentNode2 == null || CurrentNode2.next == null ? null : CurrentNode2.next;
                }

                if (Carry)
                {
                    CurrentNode.next = new ListNode(1);
                }
                return ReturnLN;
            }
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
