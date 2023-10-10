using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Üzlet
    internal class Store
    {
        public List<Food> foodItems;

        public Store() 
        {
            foodItems = new List<Food>();
        }

        //Metódus a listához adáshoz 
        //Élelmiszer az üzlethez adás
        public void AddFood(Food food)
        {
            foodItems.Add(food);
        }

        //mi található az üzletben
        public void ListFoodItmes()
        {
            Console.WriteLine("Az üzletben található élelmiszerek");
            foreach (var food in foodItems)
            {
                Console.WriteLine(food);
            }
        }

        //Lejárt ételek eltávolítása
        public void RemoveExpFood()
        {
            foodItems.RemoveAll(food => food.IsExp());
        }

        //összes termék értéke
        public int CalcTotal()
        {
            int total=0;
            foreach (var food in foodItems) 
            {
                total += food.Price * food.Quantity;
            }
            return total;
        }
    }
}
