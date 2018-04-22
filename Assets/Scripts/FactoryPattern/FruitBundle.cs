using System.Collections.Generic;
using System.Linq;

namespace FactoryPattern
{
    public class FruitBundle : IFoodBundle
    {
        private List<Food> _fruits;
        private readonly string _name = "Fruit Bundle";

        public FruitBundle()
        {
            _fruits = new List<Food>
            {
                new Food(0.8f,"Apple",1),
                new Food(2f,"Mango",1),
                new Food(1.1f,"Melon",1)
            };
        }

        public void Package()
        {
            //packaging all items
        }

        public void Add(Food foodItem)
        {
            _fruits.Add(foodItem);
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
            return _fruits.Sum(x => x.Price);
        }
    }
}