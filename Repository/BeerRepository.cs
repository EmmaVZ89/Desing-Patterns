using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BeerRepository : IBeerRepository
    {
        private DesignPatternsContext _context;

        public BeerRepository(DesignPatternsContext context)
        {
            _context = context;
        }

        public void Add(Beer data)
        {
            _context.Beer.Add(data);
        }

        public void Delete(int id)
        {
            var beer = _context.Beer.Find(id);
            _context.Beer.Remove(beer);
        }

        public Beer Get(int id)
        {
            return _context.Beer.Find(id);
        }

        public IEnumerable<Beer> Get()
        {
            return _context.Beer.ToList();
        }

        public void Update(Beer data)
        {
            _context.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
