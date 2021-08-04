using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Dev_Alura_BackEnd.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; private set; }
        public List<Video> Videos { get; private set; }

        public Category(string name):base()
        {
            Name = name;
            Videos = new List<Video>();
            Active = true;
        }
    }
}
