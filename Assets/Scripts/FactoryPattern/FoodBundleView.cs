using UnityEngine;
using UnityEngine.UI;

namespace FactoryPattern
{
    public class FoodBundleView : MonoBehaviour
    {
        [SerializeField] private Text _bundleDisplayName;
        [SerializeField] private Text _bundleDisplayPrice;
        [SerializeField] private Image _bundleDisplayImage;
        [SerializeField] private Sprite[] _foodSprites;

        
        public void Setup(BundleType type)
        {
            var bundleFactory = new FoodBundleFactory();
            var foodBundle = bundleFactory.CreatFoodBundle(type);

            _bundleDisplayImage.sprite = _foodSprites[(int) type];
            _bundleDisplayName.text = foodBundle.Name;
            _bundleDisplayPrice.text = foodBundle.Price.ToString("0.#") + " €";
        }

    }
}