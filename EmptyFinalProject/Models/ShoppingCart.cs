using Microsoft.EntityFrameworkCore;

namespace EmptyFinalProject.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public decimal total { get; set; }

        private readonly SportsDbContext _sportsDbContext;

        public ShoppingCart(SportsDbContext sportsDbContext)
        {

            _sportsDbContext = sportsDbContext;
        }

        //Get Cart/AddtoCart/ Remove Cart/ Get Shopping Items/ Clear cart / total

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
            var context = services.GetService<SportsDbContext>();
            string cartid = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartid);
            return new ShoppingCart(context) { ShoppingCartId = cartid };
        }

        public void AddToCart(Sports sports, int qty)
        {
            var ShoppingCartItem = _sportsDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Sports.SportsId == sports.SportsId && s.ShoppingCartId == ShoppingCartId);

            if (ShoppingCartItem == null)
            {
                ShoppingCartItem = new ShoppingCartItem()
                {
                    Sports = sports,
                    ShoppingCartId = ShoppingCartId,
                    Quantity = 1,

                };
                _sportsDbContext.ShoppingCartItems.Add(ShoppingCartItem);
            }
            else
            {
                ShoppingCartItem.Quantity++;
            }
            _sportsDbContext.SaveChanges();

        }

        //public void RemoveFromCart(Sports sports, int qty)
        //{

        //}

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            //return ShoppingCartItems ?? (
            //    ShoppingCartItems = 
            //    //ShoppingCartItems = 
            //    _sportsDbContext.ShoppingCartItems.Where(c=>c.ShoppingCartId==ShoppingCartId)
            //    .Include(s=> s.Sports)
            //    .ToList());

            return ShoppingCartItems ?? (ShoppingCartItems=_sportsDbContext.ShoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId).Include(s => s.Sports).ToList());
        }



        public decimal GetShoppingCartTotal()
        {
            var total = GetShoppingCartItems().Where(c => ShoppingCartId == ShoppingCartId)
                .Select(c => c.Sports.playersReq).Sum();

            return total;
        }


        //public void AddToCart(Sports sports, int qty)
        //{
        //    var ShoppingCartItem = _sportsDbContext.ShoppingCartItems.SingleOrDefault(
        //        s => s.Sports.SportsId == sports.SportsId && s.ShoppingCartId == ShoppingCartId);

        //    if (ShoppingCartItem == null)
        //    {
        //        ShoppingCartItem = new ShoppingCartItem()
        //        {
        //            Sports = sports,
        //            ShoppingCartId = ShoppingCartId,
        //            Quantity = 1,

        //        };
        //        _sportsDbContext.ShoppingCartItems.Add(ShoppingCartItem);
        //    }
        //    else
        //    {
        //        ShoppingCartItem.Quantity++;
        //    }
        //    _sportsDbContext.SaveChanges();

        //}

        public void RemoveItemFromCart(Sports sports)
        {
            var ShoppingCartItem = _sportsDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Sports.SportsId == sports.SportsId && s.ShoppingCartId == ShoppingCartId);

            if (ShoppingCartItem != null)
            {
                if (ShoppingCartItem.Quantity > 1)
                {
                    ShoppingCartItem.Quantity--;
                }
                else
                {
                    _sportsDbContext.ShoppingCartItems.Remove(ShoppingCartItem);
                }

                _sportsDbContext.SaveChanges();
            }
        }

        public void ClearCart()
        {

        }


    }
}
