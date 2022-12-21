using Pizzas.Abstraction;
using Pizzas.Helper;
using Pizzas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Services
{
    internal class BasketItemService : IService<BasketItem>
    {
        public void Add(BasketItem model)
        {
            Sql.ExecCommand($"INSERT INTO BasketItem(PizzaId,BasketId,Count,SalePrice) VALUES (N'{model.PizzaId}',N'{model.BasketId}','{model.Count}','{model.SalePrice}'");
        }
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }
        public List<BasketItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public BasketItem GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(BasketItem model)
        {
            throw new NotImplementedException();
        }
    }
}
