using FinalExamMobile.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalExamMobile.Data
{
    public interface IRestService
    {
        Task<List<Quote>> RefreshDataAsync();

        Task SaveTodoCatFactAsync(Quote item, bool isNewItem);

        Task DeleteCatFactAsync(string id);


    }
}
