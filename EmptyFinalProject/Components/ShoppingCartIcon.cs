using EmptyFinalProject.Models;
using EmptyFinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmptyFinalProject.Components
{
	public class ShoppingCartIcon : ViewComponent
	{
		private readonly ShoppingCart _shoppingCart;

		public ShoppingCartIcon(ShoppingCart shoppingCart)
		{
			_shoppingCart = shoppingCart;
		}

		public IViewComponentResult Invoke()
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

	}
}
