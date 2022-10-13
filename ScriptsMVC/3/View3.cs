using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace._3
{
    public class View3 : MonoBehaviour
    {
        public Text Hp; 
        
        public void UpdateStats(int hp)
        {
            Hp.text = hp.ToString();
        }
    }
}