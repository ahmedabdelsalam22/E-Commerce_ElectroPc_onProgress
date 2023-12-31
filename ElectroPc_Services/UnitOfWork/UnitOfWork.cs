﻿using ElectroPc_DataAccess;
using ElectroPc_Services.IRepositories;
using ElectroPc_Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroPc_Services.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            productRepository = new ProductRepository(_context);
        }
        public IProductRepository productRepository { get; private set; }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
