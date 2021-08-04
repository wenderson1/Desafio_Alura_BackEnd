using Desafio_Dev_Alura_BackEnd.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Dev_Alura_BackEnd.Controllers
{
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _dbContext;
        public CategoryController(DataContext dataContext)
        {
            _dbContext = dataContext;
        }


    }
}
