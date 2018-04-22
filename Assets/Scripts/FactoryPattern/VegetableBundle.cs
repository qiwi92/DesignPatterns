using System.Collections.Generic;
using System.Linq;

namespace FactoryPattern
{
    public class VegetableBundle : IFoodBundle
    {
        private List<Food> _vegetables;
        private readonly string _name = "Vegetable Bundle";

        public VegetableBundle()
        {
            _vegetables = new List<Food>
            {
                new Food(1.3f,"Peper",1),
                new Food(0.5f,"Salad",4)
            };
        }

        public void Package()
        {
            //packaging all items
        }

        public void Add(Food foodItem)
        {
            _vegetables.Add(foodItem);
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
            return _vegetables.Sum(x => x.Price);
        }
    }
}