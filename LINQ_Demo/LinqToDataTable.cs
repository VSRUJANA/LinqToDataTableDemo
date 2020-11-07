using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LINQ_Demo
{
    public class LinqToDataTable
    {
        public void AddToDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("ProductName");

            table.Rows.Add("1", "Chai");
            table.Rows.Add("2", "Coffee");
            table.Rows.Add("3", "Milk");
            DisplayProductsFromTable(table);
        }

        public void DisplayProductsFromTable(DataTable table)
        {
            var productNames = from products in table.AsEnumerable() select products.Field<string>("ProductName");
            Console.WriteLine("Product Names: ");
            foreach (string productName in productNames)
            {
                Console.WriteLine(productName);
            }
        }
    }
}












//var productNames = from products in table.AsEnumerable() select new { ID = products.Field<string>("ID"), Name = products.Field<string>("ProductName") };
//Console.WriteLine("Product Names: ");
//foreach (var productName in productNames)
//{
//    Console.WriteLine(productName.ID + "\t" + productName.Name);
//}
