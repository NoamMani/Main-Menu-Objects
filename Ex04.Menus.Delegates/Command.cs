namespace Ex04.Menus.Delegates
{
    public delegate void ChooseCommandEventHandler();

    public class Command : MenuItem
    {
        public event ChooseCommandEventHandler CommandChoosen;

        public Command(string i_NameItem) : base(i_NameItem)
        {
        }

        protected virtual void OnCommandChoosen()
        {
            if (CommandChoosen != null)
            {
                CommandChoosen.Invoke();
            }
        }

        public void RunChosenAction()
        {
            OnCommandChoosen();
        }
    }
}
