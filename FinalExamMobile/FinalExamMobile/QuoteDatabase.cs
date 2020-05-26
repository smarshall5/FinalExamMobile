using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExamMobile.Models;

namespace FinalExamMobile
{
    public class QuoteDatabase
    {
        private static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        public static SQLiteAsyncConnection Database => lazyInitializer.Value;
        public static bool initialized = false;

        public QuoteDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        private async Task InitializeAsync()
        {
            if (!initialized)
            {
               
                if (!Database.TableMappings.Any(m => m.MappedType.Name != nameof(Quote)))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Quote)).ConfigureAwait(false);
                    initialized = true;
                }
            }

        }
        public Task<List<Quote>> GetQuoteAsync()
        {
            return Database.Table<Quote>().ToListAsync();
        }

        public Task<int> SaveQuoteAsync(Quote quote)
        {
            return Database.InsertAsync(quote);
        }
        public Task<int> DeleteQuoteAsync(Quote quote) {


            return Database.DeleteAsync(quote);
        }

        //...
    }
}