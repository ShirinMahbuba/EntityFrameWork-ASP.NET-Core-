using Microsoft.AspNetCore.Mvc;

namespace WebApp8.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Amardesh(int year,int month,int day)
        {
            if (year<2024)
            {
                return Content($"{year} is invalid for Amardesh news");
            }
            if(month<=0 || month>12)
            {
                return Content($"{month} is invalid ");
            }
            if(day<=0 || day>31)
            {
                return Content($"{day} is invalid ");
            }
            string url_path = @"https://eamardesh.com/";
            url_path += year.ToString() + "-" + month.ToString().Trim().PadLeft(2, '0') + "-" + day.ToString().Trim().PadLeft(2, '0');
            return Redirect(url_path);
        }
        public IActionResult Amadersomoy(int year, int month, int day, int pageno)
        {
            if (year < 2016)
            {
                return Content($"{year} is invalid for Amar desh.");
            }
            if (month <= 0 || month > 12) { return Content($"{month} is invalid."); }
            if (day <= 0 || day > 31) { return Content($"{day} is invalid."); }

            string url_path = @"https://epaper.dainikamadershomoy.com/";
            url_path += year.ToString() + "/" + month.ToString().Trim().PadLeft(2, '0') + "/" + day.ToString().Trim().PadLeft(2, '0') + "/" + "page-" + pageno.ToString();

            return Redirect(url_path);
        }
    }
}
