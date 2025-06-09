using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ChilomoniBusinessDirectory.Data;
using ChilomoniBusinessDirectory.Models;

namespace ChilomoniBusinessDirectory.Pages.Businesses
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Business> Businesses { get; set; } = new List<Business>();

        public async Task OnGetAsync()
        {
            Businesses = await _context.Businesses.ToListAsync();
        }
    }
}