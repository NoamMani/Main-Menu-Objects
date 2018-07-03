using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitals : MenuItem, IExecuteable
    {
        private MethodsCollection m_MethohdsCollection = new MethodsCollection();

        public CountCapitals(string i_InstructName) : base(i_InstructName)
        {
        }

        public void Execute()
        {
            m_MethohdsCollection.CountCapital();
        }
    }
}
