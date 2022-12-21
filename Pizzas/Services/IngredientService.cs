using Pizzas.Abstraction;
using Pizzas.Helper;
using Pizzas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Services
{
    internal class IngredientService : IService<Ingredient>
    {
        public void Add(Ingredient model)
        {
            Sql.ExecCommand($"INSERT INTO Ingredients (Name)VALUES('{model.Name}')");
        }

        public void Delete(int Id)
        {
            Sql.ExecCommand($"DELETE Ingredients WHERE Id ={Id}");
        }
        public List<Ingredient> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Ingredients");
            List<Ingredient> ingredients = new List<Ingredient>();
            foreach (DataRow dr in dt.Rows)
            {
                ingredients.Add(new Ingredient { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString()});
            }
            return ingredients;
        }
        public Ingredient GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Ingredients");
            DataRow dr = dt.Rows[0];
            Ingredient ingredient = new Ingredient
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString()
            };
            return ingredient;
        }
        public void Update(Ingredient model)
        {
            Sql.ExecCommand($"UPDATE Ingredients SET Name={model.Name} WHERE ID={model.Id}");
        }
    }
}
