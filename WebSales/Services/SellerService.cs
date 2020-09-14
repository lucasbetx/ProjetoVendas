﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales.Models;
using WebSales.Data;


namespace WebSales.Services
{
    public class SellerService
    {
        private readonly WebSalesContext _context;
        
        public SellerService(WebSalesContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}