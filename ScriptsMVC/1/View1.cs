using System.Collections.Generic;
using _2;
using UnityEngine;
using UnityEngine.UI;

namespace _1
{
    public class View1 : MonoBehaviour
    {
        [SerializeField] 
        private Text _text;

        [inject]
        private List<Iunit> models;

        public void Initialize(Model1 model)
        {
            this.model = model;
        }

        public void UpgradeUnit()
        {
            
        }
    }
} 