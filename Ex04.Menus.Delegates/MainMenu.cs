namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        internal const int k_FirstLevel = 1;

        private readonly SubMenu m_menu;

        public MainMenu(string i_HeadLine)
        {
            m_menu = new SubMenu(i_HeadLine);
        }

        public void Show()
        {
            m_menu.Show(k_FirstLevel);
        }

        public void AddItem(params MenuItem[] i_NewItems)
        {
            m_menu.AddItem(i_NewItems);
        }
    }
}
