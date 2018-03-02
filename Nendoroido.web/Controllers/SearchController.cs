using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NendoroidAccessorySearchEngine.Controllers
{
    /// <summary>
    /// Search controller
    /// </summary>
    public class SearchController : Controller
    {
        /// <summary>
        /// this api is use to upload image,
        /// and get result 
        /// return in json type
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
