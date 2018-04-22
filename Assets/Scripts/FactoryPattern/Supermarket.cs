using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPattern
{
    public class Supermarket
    {
        private List<IFoodBundle> _foodBundles;

        public Supermarket()
        {
            _foodBundles = new List<IFoodBundle>();
        }

        public void AddBundle(BundleType type, Action createView)
        {
            var foodBundleFactory = new FoodBundleFactory();
            var newFoodBundle = foodBundleFactory.CreatFoodBundle(type);
            _foodBundles.Add(newFoodBundle);
            createView.Invoke();
        }

        public List<string> GetShoppingCart()
        {
            var shoppingList = new List<string>();

            foreach (var foodBundle in _foodBundles)
            {
                var name = foodBundle.Name;
                var price = foodBundle.Price;
                shoppingList.Add(name + ": " + price.ToString("0.0") + " €");
            }

            var totalPrice = _foodBundles.Sum(x => x.Price);
            shoppingList.Add("Total Price: " + totalPrice.ToString("0.0") + " €");

            return shoppingList;
        }

        public float GetTotal()
        {
            return _foodBundles.Sum(x => x.Price);
        }
 
    }
}