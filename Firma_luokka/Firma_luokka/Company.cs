using System;
using System.Collections.Generic;
using System.Text;

namespace Firma_luokka
{
    class Company
    {
        public string Title;
        public string Address;
        public string Phone;
        public double Outcome;
        public double Expense;

        public Company()
        {

        }

        public Company(string title, string address, string phone, double outcome, double expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Outcome = outcome;
            Expense = expense;
            ShowCompany();
            Profit();
        }

        public Company(Company previousCompany)
        {
            Title = previousCompany.Title;
            Address = previousCompany.Address;
            Phone = previousCompany.Phone;
            Outcome = previousCompany.Outcome;
            Expense = previousCompany.Expense;
            ShowCompany();
            Profit();
        }

        public void ShowCompany()
        {
            Console.WriteLine($"Yritys: {Title}\nOsoite: {Address}\nPuhelin: {Phone}\nTulot: {Outcome} euroa\nMenot: {Expense} euroa");
        }

        public void Profit()
        {
            double profit = Math.Round((Outcome - Expense) / Expense * 100);

            if (profit >= 300)
            {
                Console.WriteLine($"Yrityksen voitto on {profit}% suurempi kuin menot. Firmalla menee hyvin.\n");
            }
            else if (profit >= 200)
            {
                Console.WriteLine($"Firman voitto on {profit}% suurempi kuin menot. Firmalla menee tyydyttävästi.\n");
            }
            else if (profit < 100)
            {
                Console.WriteLine($"Firman voitto on {profit}% suurempi kuin menot. Firmalla menee kehnosti.\n");
            }
        }
    }
}
