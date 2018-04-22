using System.Collections.Generic;
using System.Linq;

namespace FactoryPattern
{
    public class MeatBundle : IFoodBundle
    {
        private List<Food> _meats;
        private readonly string _name = "Meat Bunlde";

        public MeatBundle()
        {
            _meats = new List<Food>
            {
                new Food(5.5f,"Steak",1),
                new Food(1.1f,"Sausage",10)
            };
        }

        public void Package()
        {
            //packaging all items
        }

        public void Add(Food foodItem)
        {
            _meats.Add(foodItem);
        }

        public float Price
        {
            get { return GetBundlePrice(); }
        }

        public string Name
        {
            get { return _name; }
        }

        private float GetBundlePrice()
        {
            return _meats.Sum(x => x.Price);
        }
    }
}