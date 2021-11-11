using System.Collections.Generic;
using WS_Lanches.Models;

namespace WS_Lanches.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
