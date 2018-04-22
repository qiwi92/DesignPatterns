using System;

namespace FactoryPattern
{
    public class FoodBundleFactory
    {
        public IFoodBundle CreatFoodBundle(BundleType type)
        {
            IFoodBundle foodBunlde = null;

            switch (type)
            {
                case BundleType.Fruit:
                    foodBunlde = new FruitBundle();
                    break;
                case BundleType.Vegetable:
                    foodBunlde = new VegetableBundle();
                    break;
                case BundleType.Meat:
                    foodBunlde = new MeatBundle();
                    break;
            }

            return foodBunlde;
        }
    }
}
