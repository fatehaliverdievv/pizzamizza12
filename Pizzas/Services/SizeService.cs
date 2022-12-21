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
    internal class SizeService : IService<Size>
    {
        public void Add(Size model)
        {
            Sql.ExecCommand($"INSERT INTO Sizes (Name)VALUES('{model.Name}')");
        }
        public void Delete(int Id)
        {
            Sql.ExecCommand($"DELETE Sizes WHERE Id ={Id}");
        }
        public List<Size> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Sizes");
            List<Size> sizes = new List<Size>();
            foreach (DataRow dr in dt.Rows)
            {
                sizes.Add(new Size { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString() });
            }
            return sizes;
        }
        public Size GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Sizes");
            DataRow dr = dt.Rows[0];
            Size sizes = new Size
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString()
            };
            return sizes;
        }
        public void Update(Size model)
        {
            Sql.ExecCommand($"UPDATE Sizes SET Name={model.Name} WHERE ID={model.Id}");
        }
    }
}
