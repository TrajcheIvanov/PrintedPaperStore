using PrintedPaperStore.Data.Interfaces;
using PrintedPaperStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintedPaperStore.Data
{
    public class ApplicationsRepository : IApplicationsRepository
    {
        private readonly PrintedPaperStoreDbContext _context;

        public ApplicationsRepository(PrintedPaperStoreDbContext context)
        {
            _context = context;
        }

        public Application GetByApiKey(string apiKey)
        {
            return _context.Applications.FirstOrDefault(x => x.Key == apiKey);
        }
    }
}
