namespace _1
{
    //Supervising Controller
    public class Controller1
    {
        [inject] private View1 _view1;
        [inject] private Model1 _model1;
        
        public void InitWindow()
        {
            _view1.Initialize(_model1);
        }
        
        public void DisableWindow()
        {
            _view1.Disable();
        }
        
        
    }
}