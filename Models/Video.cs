using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Dev_Alura_BackEnd.Models
{
    public class Video : BaseEntity
    {
        public Video(string title, string description, string url)
        {
            Title = title;
            Description = description;
            Url = url;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Url { get; private set; }

    }
}
