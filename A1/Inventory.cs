using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebA1
{
    public class Inventory
    {
        //  public List <Product> inventory { get; set; }
        public void displayProductLines()
        {

            //try
            //{
           // StreamReader r = new StreamReader(@"F:\owners_inventory.json");
            //string json = r.ReadToEnd();
            List<Product> ro = JsonUtility.readJsonFile<List<Product>>(@"F:\owners_inventory.json");
            //string jsondata = @"["{"ID":1,"Name":"Rabbit","StockLevel":4},{"Id":2,"Name":"Rabbit","StockLevel":1}];
            Console.WriteLine("=================");
            Console.WriteLine("Inventory      ||");
            Console.WriteLine("=================");
            Console.WriteLine("ID\tProduct\t\t\t  Current Stock");
            Console.WriteLine("____________________________________________________");
            foreach (Product item in ro)
            {
                Console.WriteLine("{0,-5}\t{1,-8}\t\t{2,3}", item.ID, item.Name, item.CurrentStock);
            }

            Console.WriteLine("\n");
            //Console.Write("Enter Escape Character to return to the Owner menu: ");

           
            //}
            //catch (Exception e)
            //{
            //Console.WriteLine(e.Message);
            // }
        }
    }
}
