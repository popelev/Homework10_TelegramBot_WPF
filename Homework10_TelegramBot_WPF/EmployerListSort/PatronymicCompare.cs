using System;
using System.Collections.Generic;
using System.Text;
using Homework10_TelegramBot_WPF.Model;

namespace Homework10_TelegramBot_WPF.EmployerListSort
{
    public class PatronymicCompare : IComparer<Employer>
    {
        public int Compare(Employer x, Employer y)
        {
            return x.Patronymic.CompareTo(y.Patronymic);
        }
    }
}