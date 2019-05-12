using Microsoft.EntityFrameworkCore;
using TaskTranning.Models;

namespace TaskTranning.Seed
{
    public static class DbContext
    {
        public static void Initialize(CodeFirstDataContext _context)
        {
            _context.Database.Migrate();
        }
    }
}