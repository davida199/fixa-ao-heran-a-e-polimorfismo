using fixação_herança_e_polimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;
using System;

namespace fixação_herança_e_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Product {i}");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (op == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (op == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else if (op == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, fee));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in list)
            {
                Console.WriteLine(p.priceTag());
            }            
        }
    }
}
/*Fazer um programa para ler os dados de N
produtos (N fornecido pelo usuário). Ao final,
mostrar a etiqueta de preço de cada produto na
mesma ordem em que foram digitados.
Todo produto possui nome e preço. Produtos
importados possuem uma taxa de alfândega, e
produtos usados possuem data de fabricação.
Estes dados específicos devem ser
acrescentados na etiqueta de preço conforme
exemplo (próxima página). Para produtos
importados, a taxa e alfândega deve ser
acrescentada ao preço final do produto.
Favor implementar o programa conforme
projeto ao lado.
Enter*/