using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class LastYearTaxCalculator : ITaxCalculator
    {
        public decimal FindTaxAmount(decimal income)
        {
            //there could be a typo in here!
            decimal taxAmount;
            decimal stDedSingle = 6300;
            decimal persDedSingle = 4000;
            income = income - stDedSingle - persDedSingle;
            if (income < 9226)
            {
                taxAmount = income * .1M;
            }
            else if (income < 37451)
            {
                taxAmount = 922.50M + (income - 9225) * .15M;
            }
            else if (income < 90751)
            {
                taxAmount = 5156.25M + (income - 37450) * .25M;
            }
            else if (income < 189301)
            {
                taxAmount = 18481.25M + (income - 90750) * .28M;
            }


            else if (income < 411501)
            {
                taxAmount = 46075.25M + (income - 189300) * .33M;
            }

            else if (income < 413201)
            {
                taxAmount = 119401.25M + (income - 413200) * .35M;
            }
            else
            {
                taxAmount = 119996.25M + (income - 415050) * .396M;
            }



            return taxAmount;
        }
    }
}