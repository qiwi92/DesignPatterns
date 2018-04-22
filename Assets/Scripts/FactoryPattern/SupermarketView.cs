using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FactoryPattern
{
    public class SupermarketView : MonoBehaviour
    {
        private Supermarket _supermarket;
        [SerializeField] private Button _button;

        [SerializeField] private RectTransform _scrollViewRectTransform;
        [SerializeField] private FoodBundleView _foodBundlePrefab;
        private List<FoodBundleView> _foodBundleViews;

        [SerializeField] private Dropdown _bundleDropdown;
        private BundleType _nextType = BundleType.Fruit;

        [SerializeField]private Text _totalCostDisplay;

        private void Awake()
        {
            _foodBundleViews = new List<FoodBundleView>();
            
            _bundleDropdown.ClearOptions();
            var opntions = new List<string>
            {
                "Fruit", "Vegetable", "Meat"
            };
            _bundleDropdown.AddOptions(opntions);
            _bundleDropdown.onValueChanged.AddListener(delegate { _nextType = (BundleType)_bundleDropdown.value; });


            _supermarket = new Supermarket();


            _supermarket.AddBundle(_nextType, () => { CreateView(_nextType); });
            _totalCostDisplay.text = "Total: " + _supermarket.GetTotal().ToString("0.0") + " €";

            _button.onClick.AddListener(() =>
            {
                _supermarket.AddBundle(_nextType, () => { CreateView(_nextType); });
                _totalCostDisplay.text = "Total: " + _supermarket.GetTotal().ToString("0.0") + " €";
            });
        }

        private void CreateView(BundleType type)
        {
            var newFoodBundle = Instantiate(_foodBundlePrefab, _scrollViewRectTransform);
            newFoodBundle.Setup(type);
            _foodBundleViews.Add(newFoodBundle);
        }
    }
}