using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Models
{
    public class IsButikItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public IsButikItem(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
