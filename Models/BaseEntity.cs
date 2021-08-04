using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Dev_Alura_BackEnd.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
        public bool Active { get; protected set; }
       
        public void Deactive()
        {
            Active = false;
        }
    }
}
