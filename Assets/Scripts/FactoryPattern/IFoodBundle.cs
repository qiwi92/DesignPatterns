namespace FactoryPattern
{
    public interface IFoodBundle
    {
        void Package();
        void Add(Food foodItem);
        float Price { get; }
        string Name { get; }
    }
}