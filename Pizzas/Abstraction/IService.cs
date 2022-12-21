using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Abstraction
{
    internal interface IService<T>
    {
        void Add(T model);
        List<T> GetAll();
        void Update(T model);
        void Delete(int Id);
        T GetById(int Id);
    }
}
