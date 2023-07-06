using System;
namespace _07_razor.Models
{
    public class Expenditure
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public Expenditure(string name, DateTime date, decimal price)
        {
            Name = name;
            Date = date;
            Price = price;
        }
    }

}

