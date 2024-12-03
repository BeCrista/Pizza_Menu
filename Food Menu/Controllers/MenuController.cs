﻿using Microsoft.AspNetCore.Mvc;
using Food_Menu.Data;
using Food_Menu.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace Food_Menu.Controllers
{
    public class MenuController : Controller
    {
        private readonly MenuContext _context;
        public MenuController(MenuContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var dishes = from d in _context.Dishes
                       select d;
            if (!string.IsNullOrEmpty(searchString))
            {
                dishes = dishes.Where(d => d.Name.Contains(searchString));
                return View(await dishes.ToListAsync());
            }
            return View(await dishes.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            var dish = await _context.Dishes
                .Include(di => di.DishIngredients)
                .ThenInclude(i => i.Ingredient)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dish == null)
            {
                return NotFound();
            }

            return View(dish);
        }
    }
}