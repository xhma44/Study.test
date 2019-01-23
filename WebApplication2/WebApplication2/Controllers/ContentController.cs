using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content _content;
        public ContentController(IOptions<Content> option)
        {
            _content = option.Value;
        }

        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(new ContentViewModel { Contents=new List<Content> { _content } });
        }
    }
}