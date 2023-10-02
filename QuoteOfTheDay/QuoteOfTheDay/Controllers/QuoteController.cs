using Microsoft.AspNetCore.Mvc;

namespace QuoteOfTheDay.Controllers
{
    public class QuoteController : Controller
    {
        public IActionResult QuoteOfTheDay()
        {
            string quoteOfTheDay = GetQuoteOfTheDay();
            ViewData["QuoteOfTheDay"] = quoteOfTheDay;

            return View();
        }

        private string GetQuoteOfTheDay()
        {
            string[] quotesList = System.IO.File.ReadAllLines("quotes.txt");

            if (quotesList.Length > 0)
            {
                Random random = new();
                int randomQuote = random.Next(0, quotesList.Length);

                string quote = quotesList[randomQuote];
                return quote;

            }
            else
            {
                return "No quotes found";
            }

        }

          
     }
}
