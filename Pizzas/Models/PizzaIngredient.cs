﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Models
{
    internal class PizzaIngredient
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public int IngredientId { get; set; }
    }
}
