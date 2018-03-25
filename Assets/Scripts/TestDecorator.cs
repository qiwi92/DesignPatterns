using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class TestDecorator : MonoBehaviour
    {
        public Dropdown TypeDropdown;
        public Dropdown Extra1Dropdown;
        public Dropdown Extra2Dropdown;

        public Text Description;
        public Text Cost;

        private AutoMobile _car;

        private AutoMobile _autoMobile;



        private void Start()
        {
            var typeData = new List<Dropdown.OptionData>();

            typeData.Add(new Dropdown.OptionData("Car"));
            typeData.Add(new Dropdown.OptionData("Truck"));


            TypeDropdown.options = typeData;


            TypeSelect(0);
            TypeDropdown.onValueChanged.AddListener(delegate
            {
                TypeSelect(TypeDropdown.value);
            });

            var extraData = new List<Dropdown.OptionData>();

            extraData.Add(new Dropdown.OptionData("Radio"));
            extraData.Add(new Dropdown.OptionData("Climatization"));


            Extra1Dropdown.options = extraData;

            ExtraSelect(0);
            Extra1Dropdown.onValueChanged.AddListener(delegate
            {
                ExtraSelect(Extra1Dropdown.value);
            });
 
        }

        private void TypeSelect(int value)
        {
            if (value == 0)
            {
                _autoMobile = new Car();
                Description.text = _autoMobile.GetDescription();
                Cost.text = _autoMobile.Cost().ToString("0");
            }

            if (value == 1)
            {
                _autoMobile = new Truck();
                Description.text = _autoMobile.GetDescription();
                Cost.text = _autoMobile.Cost().ToString("0");
            }
        }


        private void ExtraSelect(int value)
        {
            if (value == 0)
            {
                _autoMobile = new Radio(_autoMobile);
                Description.text = _autoMobile.GetDescription();
                Cost.text = _autoMobile.Cost().ToString("0");
            }

            if (value == 1)
            {
                _autoMobile = new Climatization(_autoMobile);
                Description.text = _autoMobile.GetDescription();
                Cost.text = _autoMobile.Cost().ToString("0");
            }
        }

    }
}