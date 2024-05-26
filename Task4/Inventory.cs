using System;
using System.Collections.Generic;

namespace Task4
{
    public class Inventory
    {
        Dictionary<string, int> Products = new();

        public Inventory()
        {
            Products = new Dictionary<string, int>();
        }

        public void AddProduct(string name,int quantity)
        {

            foreach (var product in Products)
            {
                if (name == product.Key)
                {
                    Products[name] += quantity;
                    return;

                }
                
            }

            Products.Add(name, quantity);



        }

        public void RemoveProduct(string name)
        {
            Products.Remove(name);
        }
       

        public void GetQuantityByProduct(string name)
        {


            foreach (var students in Products)
            {
                if (name == students.Key)
                {
                    Console.WriteLine(students.Value);
                    return;

                }

                Console.WriteLine($"Sorry,we dont have product with name {name}");
            }
        }

        public void UpdateQuantity(string name,int quantity)
        {
            if (Products.Any(prop=> prop.Key == name))
            {
                Products[name] = quantity;
            }
            else
            {
                Console.WriteLine("Update ugursuz,bele product yoxdur");
            }

        }

    }
}

