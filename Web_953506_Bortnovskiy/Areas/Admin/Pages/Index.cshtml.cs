using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_953506_Bortnovskiy.Data;
using Web_953506_Bortnovskiy.Entities;

namespace Web_953506_Bortnovskiy.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Web_953506_Bortnovskiy.Data.ApplicationDbContext _context;

        public IndexModel(Web_953506_Bortnovskiy.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; }

        public async Task OnGetAsync()
        {
            Dish = await _context.Dishes
                .Include(d => d.Group).ToListAsync();
        }
    }
}
