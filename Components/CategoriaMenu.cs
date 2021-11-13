﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WS_Lanches.Repositories;

namespace WS_Lanches.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaRepository) {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke() {
            var categorias = _categoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);

            return View(categorias);
        }
    }
}
