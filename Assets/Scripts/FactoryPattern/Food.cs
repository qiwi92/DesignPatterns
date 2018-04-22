namespace FactoryPattern
{
    public class Food
    {
        private readonly float _price;

        public int Amount { get; private set; }
        public string Name { get; private set; }

        public float Price
        {
            get { return GetTotalPrice(); }
        }

        public Food(float price,string name, int amount)
        {
            _price = price;
            Name = name;
            Amount = amount;
        }

        private float GetTotalPrice()
        {
            return _price * Amount;
        }
    }
}