using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class LesleyController : Controller
    {
        // 
        // GET: /Lesley/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Lesley/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}