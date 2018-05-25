using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        StringBuilder[] data = new StringBuilder[n];

        for (int i = 0; i < n; i++)
        {
            data[i] = new StringBuilder();
        }
        for (int nItr = 0; nItr < n; nItr++)
        {
            string[] xs = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xs[0]);
            
            string s = xs[1];
            if (nItr < n / 2)
            {
                data[x].Append("- ");
            }
            else {
                data[x].Append(s + " ");
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(data[i]);            
        }
    }
}
