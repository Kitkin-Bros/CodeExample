using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace._3
{
    //https://github.com/Kitkin-Bros/CodeExample
    public class Controller3 : MonoBehaviour
    {
        public Button _upgradeButton;
        public InAppService InAppService;
        
        public Model3 _Model3;
        public View3 _View3;

        private void Awake()
        {
            _upgradeButton.onClick.AddListener(Upgrade);
        }

        private void Upgrade()
        {
            var data = _Model3.UpdateUnit();
            
            _View3.UpdateStats(data);
        }
    }
}