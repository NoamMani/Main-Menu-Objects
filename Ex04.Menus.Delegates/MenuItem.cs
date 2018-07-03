namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private string m_NameItem;

        public MenuItem(string i_ItemName)
        {
            m_NameItem = i_ItemName;
        }

        public override string ToString()
        {
            return m_NameItem;
        }
    }
}
