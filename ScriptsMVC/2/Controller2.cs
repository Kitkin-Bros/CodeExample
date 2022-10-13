using _1;
using UnityEngine;

namespace _2
{
    //Passive View
    public class Controller2
    {
        private Model2 _model2;
        private View2 view2;
        private GameObject _unitPrefab;
        private GameObject _unitInstance;
        
        [SerializeField]
        private Joystick _joystick;
        
        
        private void OnTriggerEnter(Collider other)
        {
            
        }

        [inject]
        private void Initialize(View2 view, Model2 model2, GameObject unit)
        {
            _model2 = model2;
            _unit = unit;


            Start();
        }

        private void Start()
        {
            // game logic
        }
        
        
        public int UpdateHealthValue()
        {
            return _model2.HealthValue;
        }
        
        public void MoveUnit(Vector3 direct)
        {
            _unit.transform.Translate(direct);
        }
        
        public void ChangeHealthValue(int value)
        {
            _model2.HealthValue -= value;
        }
    }
}