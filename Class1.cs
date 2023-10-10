using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Food
    {
        //ADATTAGOK

        //Élelmiszer neve
        public string Name { get; set; }
        
        //Élelmiszer értéke
        public int Price { get; set; }
        
        //Élelmiszer vonalkódja
        public string Barcode { get; set; }

        //Élelmiszer dátuma
        public DateTime ExpDate { get; set; }

        //Mennyiség
        public int Quantity {  get; set; }

        //konstruktor létrehozása
        //ÉRTÉKEK HOZZÁADÁSA
        public Food(string name, int price, string barcode, DateTime expdate, int quantity) 
        {
            this.Name = name;
            this.Price = price;
            this.Barcode = barcode;
            this.ExpDate = expdate;
            this.Quantity = quantity;

        }
        //kiíratás
        public override string ToString()
        {
            return $"Név: {Name}, Ár: {Price}, Vonalkód: {Barcode}" +
                $" Lejárati dátum: {ExpDate}, Mennyiség: {Quantity}";
        }

        //Érvényes-e még az élelmiszer
        public bool IsExp()
        {
            return ExpDate < DateTime.Now;
        }
        
        //Mennyiség növelés-csökkentés
        public void IncQuantity(int amount)
        {
            Quantity += amount;
        }
        public void DecQuantity(int amount)
        {
            if (Quantity >= amount)
            { 
                Quantity -= amount; 
            }
            else
            {
                Console.WriteLine("Nincs elegendő");
            }
        }
    }   
}
