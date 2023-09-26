using EmptyFinalProject.Models;
using EmptyFinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmptyFinalProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISportsRepo _sportsRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController (ISportsRepo sportsRepo, ShoppingCart shoppingCart)
        {
            _sportsRepo = sportsRepo;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();

            //_shoppingCart.ShoppingCartItems = items;

            _shoppingCart.ShoppingCartItems = items;

            //var shoppingviewmodel = new ShoppingCartViewModel()
            var shoppingviewmodel = new ShoppingCartViewModel()

            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal(),
            };

            return View(shoppingviewmodel);
        }

        public RedirectToActionResult AddToShoppingCart( int SportsId )
        {
            var selectedSports = _sportsRepo.AllSports.First(
                p => p.SportsId == SportsId
                );
            if ( selectedSports != null )
            {
                _shoppingCart.AddToCart(selectedSports, 1);
            }
            return RedirectToAction("Index");
        }

		public RedirectToActionResult RemoveFromShoppingCart(int SportsId)
		{
			var selectedSports = _sportsRepo.AllSports.First(
				p => p.SportsId == SportsId
				);
			if (selectedSports != null)
			{
				_shoppingCart.RemoveItemFromCart (selectedSports);
			}
			return RedirectToAction("Index");
		}

        //public RedirectToActionResult RemoveFromShoppingCart(int SportsId)
        //{
        //    var selectedSports = _sportsRepo.AllSports.First(
        //        p => p.SportsId == SportsId
        //        );
        //    if (selectedSports != null)
        //    {
        //        _shoppingCart.RemoveItemFromCart(selectedSports);
        //    }
        //    return RedirectToAction("Index");
        //}

    }
}
