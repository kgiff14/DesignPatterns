using BuilderDemo.Builder;
using System;

namespace BuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder MealBuilder = new MealBuilder();

            Meal Vegan = MealBuilder.PrepareVegMeal();
            Console.WriteLine("Vegan Meal:");
            Vegan.ShowItems();
            Console.WriteLine("Total Cost: " + Vegan.GetCost() + "\n");

            Meal Chicken = MealBuilder.PrepareChickenMeal();
            Console.WriteLine("Chicken Meal: ");
            Chicken.ShowItems();
            Console.WriteLine("Total Cost: " + Chicken.GetCost() +"\n");
        }
    }
}
