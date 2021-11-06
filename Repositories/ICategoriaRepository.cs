using System.Collections.Generic;
using WS_Lanches.Models;

namespace WS_Lanches.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
