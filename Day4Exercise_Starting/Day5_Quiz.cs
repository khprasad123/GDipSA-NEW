using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise_Starting
{
    class Day5_Quiz
    {
        //these arrays is visible in all the static method,
        //so you can use them in your method implementation
        static int[] minIncomeArray = new int[]
                            { 20000, 30000, 40000, 80000,120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
                            { 0.02, 0.035, 0.07, 0.115,0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
                            { 0, 200, 550, 3350,7950, 13950, 20750, 42350 };
        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable =
            CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }
      static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income: ");
            int income = int.Parse(Console.ReadLine());
            return income;
        }
        static int GetTaxBracket(double anualIncome)
        {
            int index = 0;
            if (anualIncome < 20000)
                return -1;
            for (int i = minIncomeArray.Length-1; i>=0;i--)
            {
                if (anualIncome > minIncomeArray[i])
                {
                    return i;
                } 
            }
            return 1;
        }
        static double CalculateIncomeTax(int anualIncome ,int TaxBracket)
        {
            if (TaxBracket == -1)
                return 0;
            double payableTax = basePayableAmountArray[TaxBracket] + (taxRateArray[TaxBracket] * (anualIncome- minIncomeArray[TaxBracket]));
            return payableTax;
        }
        static void PrintResult(int anualIncome,double taxPayable)
        {
            Console.WriteLine("For taxable annual income of $" + anualIncome + " " + "  the tax payable amount is $" + taxPayable);
        }
    }
}
