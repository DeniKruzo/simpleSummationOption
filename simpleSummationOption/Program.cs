using System.Linq.Expressions;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System;
using System.Transactions;
using simpleSummationLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        var wtf = new SimpleSummation();

        int[] wtfArray = {int.MaxValue, int.MaxValue};

        Console.WriteLine(wtf.SumTwoMin(wtfArray));
    }
}