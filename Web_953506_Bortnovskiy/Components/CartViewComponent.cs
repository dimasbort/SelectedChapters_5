using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_953506_Bortnovskiy.Extensions;
using Web_953506_Bortnovskiy.Models;

namespace Web_953506_Bortnovskiy.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart; 
        public CartViewComponent(Cart cart) 
        { 
            _cart = cart; 
        }
        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
