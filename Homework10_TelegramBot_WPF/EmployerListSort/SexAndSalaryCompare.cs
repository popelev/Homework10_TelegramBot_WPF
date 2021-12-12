using System;
using System.Collections.Generic;
using System.Text;
using Homework10_TelegramBot_WPF.Model;

namespace Homework10_TelegramBot_WPF.EmployerListSort
{
    public class SexAndSalaryCompare : IComparer<Employer>
    {
        public int Compare(Employer x, Employer y)
        {
            if (x.Sex.CompareTo(y.Sex) == 0)
            {
                return x.Salary.CompareTo(y.Salary);
            }
            else
            {
                return x.Sex.CompareTo(y.Sex);
            }
        }
    }
}