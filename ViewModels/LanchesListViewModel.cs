using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WS_Lanches.Models;

namespace WS_Lanches.ViewModels
{
    public class LanchesListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
