using FinalExamMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamMobile.Data
{
   public class QuoteManager
    {
        IRestService restService;
        public QuoteManager(IRestService service)
        {
            restService = service;
        }

        public Task<List<Quote>> GetTasksAsync()
        {
            return restService.RefreshDataAsync();
        }

    }
}
