using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymnasticRegister.DataAccessLayer;

namespace GymnasticRegister.BusinessLogicLayer
{
    internal class QuoteBLL
    {
        public static DataTable LoadQuotes()
        {
            return QuoteDAL.LoadQuotes();
        }

        public static void AddQuotes(String Quote)
        {
            QuoteDAL.AddQuotes(Quote);
        }

        public static string GetRandomQuote()
        {
            return QuoteDAL.GetRandomQuote();
        }
    }
}
