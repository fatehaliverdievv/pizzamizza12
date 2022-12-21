using Pizzas.Abstraction;
using Pizzas.Models;
using Pizzas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Contex
{
    internal class Context
    {
        IService<Pizza> _pizza;
        IService<Ingredient> _ingredient;
        IService<Size> _size;
        public IService<Pizza> Pizza
        {
            get
            {
                if (_pizza == null)
                {
                    _pizza = new PizzaService();
                }
                return _pizza;
            }
        }
        public IService<Ingredient> Ingredients
        {
            get
            {
                if (_ingredient == null)
                {
                    _ingredient = new IngredientService();
                }
                return _ingredient;
            }
        }
        public IService<Size> Size
        {
            get
            {
                if (_size == null)
                {
                    _size = new SizeService();
                }
                return _size;
            }
        }
    }
}
