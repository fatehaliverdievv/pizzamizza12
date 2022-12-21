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
    internal class BasketService : IService<Basket>
    {
        public void Add(Basket model)
        {
            Sql.ExecCommand($"INSERT INTO Baskets (TotalPrice)VALUES('{model.TotalPrice}')");
        }
        public void Delete(int Id)
        {
            Sql.ExecCommand($"DELETE Baskets WHERE Id ={Id}");
        }
        public List<Basket> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Baskets");
            List<Basket> baskets = new List<Basket>();
            foreach (DataRow dr in dt.Rows)
            {
                baskets.Add(new Basket { Id = Convert.ToInt32(dr["Id"]), TotalPrice = Convert.ToInt32(dr["TotalPrice"]) });
            }
            return baskets;
        }
        public Basket GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Baskets");
            DataRow dr = dt.Rows[0];
            Basket baskets = new Basket
            {
                Id = Convert.ToInt32(dr["Id"]),
                TotalPrice = Convert.ToInt32(dr["TotalPrice"])
            };
            return baskets;
        }
        public void Update(Basket model)
        {
            Sql.ExecCommand($"UPDATE Baskets SET Name={model.TotalPrice} WHERE ID={model.Id}");
        }
    }
}
