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
    internal class PizzaService : IService<Pizza>
    {
        public void Add(Pizza model)
        {
            Sql.ExecCommand($"INSERT INTO Pizzas (Name,Img) VALUES ('{model.Name}','{model.Img}')");
        }
        public void Delete(int Id)
        {
            Sql.ExecCommand($"DELETE Pizzas WHERE Id ={Id}");
        }
        public List<Pizza> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Pizzas");
            List<Pizza> pizzas = new List<Pizza>();
            foreach (DataRow dr in dt.Rows)
            {
                pizzas.Add(new Pizza { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), Img = dr["Img"].ToString()});
            }
            return pizzas;
        }
        public Pizza GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Pizzas");
            DataRow dr = dt.Rows[0];
            Pizza pizzas = new Pizza()
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString(),
                Img= dr["Img"].ToString()  
            };
            return pizzas;
        }
        public void Update(Pizza model)
        {
            Sql.ExecCommand($"UPDATE Pizzas SET Name={model.Name}, Img={model.Img }WHERE ID={model.Id}");
        }
    }
}
