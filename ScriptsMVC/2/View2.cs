using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace _2
{
    public class View2 : MonoBehaviour
    {
        [SerializeField]
        private Text _text;
        
        
        [SerializeField]
        private Image skin;

        public UnityEvent<Vector3> StartMove { get; set; } = new();
        public UnityEvent HittingUnit { get; set; } = new();

        public void ChangeSkin(Image newSkin)
        {
            skin = newSkin;
        }

        public void ShowHealth(int value)
        {
            _text.text = value.ToString();
        }

    }
}