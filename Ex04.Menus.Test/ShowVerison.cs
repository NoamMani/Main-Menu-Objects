using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVerison : MenuItem, IExecuteable
    {
        private MethodsCollection m_MethodsCollection = new MethodsCollection();

        public ShowVerison(string i_InstructName) : base(i_InstructName)
        {
        }

        public void Execute()
        {
            m_MethodsCollection.ShowVerison();
        }
    }
}
