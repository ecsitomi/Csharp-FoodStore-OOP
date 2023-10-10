using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ElelmiszerOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Új élelmiszer létrehozása
            Food tej = new Food("tej", 450, "123456", new DateTime(2021, 12, 31), 5);
            Food kenyer = new Food("kenyér", 300, "123123", new DateTime(2023, 10, 15), 10);
            Food tojas = new Food("tojás", 70, "345345", new DateTime(2021, 10, 15), 20);
            Food sajt = new Food("sajt", 800, "456456", new DateTime(2023, 10, 10), 1);
            Food cukor = new Food("cukor", 300, "789789", new DateTime(2024, 12, 31), 10);

            //Új üzlet létrehozása
            Store tesco = new Store();

            //Élelmiszer hozzáadása az üzlethez
            tesco.AddFood(tej);
            tesco.AddFood(kenyer);
            tesco.AddFood(tojas);
            tesco.AddFood(sajt);
            tesco.AddFood(cukor);

            //Összes élelmiszer kilistázása
            tesco.ListFoodItmes();

            Console.WriteLine(tej.IsExp() ? "A tej lejárt":"A tej még jó");

            //Lejárt eltávolítása
            tesco.RemoveExpFood();
            tesco.ListFoodItmes();

            //Össz érték
            int totalValue=tesco.CalcTotal();
            Console.WriteLine($"Összérték: {totalValue}");
        }
    }
}
