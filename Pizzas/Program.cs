using Pizzas.Contex;
using Pizzas.Models;
using Pizzas.Services;

namespace Pizzas
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //---------------------------------------------------------------------------------------Pizza
            PizzaService pizzaService = new PizzaService();
            //Pizza margari= new Pizza {Name="Margarita", Img="heleki yoxumuzdu qaqas" };
            //pizzaService.Add(margari);
            //foreach (var item in pizzaService.GetAll())
            //{
            //    Console.WriteLine(item.Id + " "+ item.Name+" "+item.Img);
            //}

            //-------------------GETBYIDPIZZA
            //Console.WriteLine(pizzaService.GetById(1).Id+ ". " + pizzaService.GetById(1).Name+" "+pizzaService.GetById(1).Img);





            //---------------------------------------------------------------------------------------Ingredient
            IngredientService ingredientService = new IngredientService();
            //Ingredient sos = new Ingredient { Name = "Sos" };
            //ingredientService.Add(sos);
            //foreach (var item in ingredientService.GetAll())
            //{
            //    Console.WriteLine(item.Id+ " "+item.Name);
            //}
            //-------------------GETBYIDPIZZA
            //Console.WriteLine(ingredientService.GetById(1).Id+". "+ ingredientService.GetById(1).Name);

            //----------------------------------------------------------------------------------------Size
            SizeService sizeService=new SizeService();
            Size largere = new Size { Name = "Large" };
            //sizeService.Add(largere);
            foreach (var item in sizeService.GetAll())
            {
                Console.WriteLine(item.Id + ". " + item.Name);
            }
        }
    }
}