using PrintedPaperStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedPaperStore.Data.Interfaces
{
    public interface IApplicationsRepository
    {
        Application GetByApiKey(string apiKey);
    }
}
