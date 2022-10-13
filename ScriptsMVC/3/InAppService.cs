namespace DefaultNamespace._3
{
    public class InAppService
    {
        public RewardController RewardController;
        public InAppController InAppController;

        public void ShowReward()
        {
            RewardController.ShowReward();
        }
    
        public void ShowInApp()
        {
            InAppController.ShowInApp();
        }
    }
}