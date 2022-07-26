using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace WebHomeDay.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string[] nameRestaurant = { "Grusha", "PLITA", "Meat Line", "BarBaris", "Beergarten", "Crab Story", "Probka", "The Repa",
            "Vino di Vino","ObedBufet","Tequila-Boom","Vinograd","Zeppelin","JEROME","Vincent","Maximilian","OTTO Pizza","Fujiyama",
            "Matisov","Hanoi City","SunDay Ginza","Volga-Volga","Duderhoff","Douglas","FERN","GRAS","IL MILASE","Jager","Jet Set Sport",
            "Jai Hind","Korovabar","Kwakker","Las Torres","La Presse"};
        public void OnGet()
        {
            //Текущий день и номер дня
            var dayOfYear = DateTime.Now.DayOfYear.ToString("d", new CultureInfo("en-US"));
            var currentDay = DateTime.Now.Day.ToString("d", new CultureInfo("en-US"));

            ViewData["NumberDay"] = dayOfYear;
            ViewData["CurrentDay"] = currentDay;

            //Вывод случайной буквы
            Random rand = new Random();
            char letter;
            

            do
            {
                letter = (char)rand.Next('A', 'z' + 1);

            } while (!char.IsLetter(letter));

            ViewData["RandomLetter"] = letter;
        }
    }
}