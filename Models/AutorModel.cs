using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaygroundAPI.Models
{
    public class AutorModel
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public List<LivroModel> Livros { get; set; }
    }
}