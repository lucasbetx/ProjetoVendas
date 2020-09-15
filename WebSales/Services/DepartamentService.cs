using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales.Data;
using WebSales.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSales.Services
{
    public class DepartamentService
    {
        private readonly WebSalesContext _context;

        public DepartamentService(WebSalesContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
