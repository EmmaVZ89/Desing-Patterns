﻿using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepository<Beer> Beers { get; }
        public IRepository<Brand> Brands { get; }

        public void Save();
    }
}
