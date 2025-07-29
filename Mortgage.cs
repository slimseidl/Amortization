using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Amortization
{
    internal class Mortgage
    {
        public double MonthlyPayment(int principal, double rate, int numPayments)
        {
            double payment = Math.Round(principal * ((rate * Math.Pow((1 + rate), numPayments)) / (Math.Pow((1 + rate), numPayments) - 1)), 2);
            return payment;
        }

        public double MonthlyPayment(int principal, double rate, int numPayments, double taxRate, double annualInsurance)
        {
            double basePayment = MonthlyPayment(principal, rate, numPayments);
            double monthlyTax = (principal * (taxRate / 100)) / 12;
            double monthlyInsurance = annualInsurance / 12;

            return Math.Round(basePayment + monthlyTax + monthlyInsurance, 2);
            
        }
    }
}
