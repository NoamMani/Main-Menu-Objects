namespace Ex04.Menus.Test
{
    public class DelegateTestMethods
    {
        // $G$ DSN-999 (-2) m_MethodsCollection should be readonly.

        private MethodsCollection m_MethodsCollection = new MethodsCollection();

        public void MethodsCollection_ShowDate()
        {
            m_MethodsCollection.ShowDate();
        }

        public void MethodsCollection_ShowTime()
        {
            m_MethodsCollection.ShowTime();
        }

        public void MethodsCollection_CountCapital()
        {
            m_MethodsCollection.CountCapital();
        }

        public void MethodsCollection_ShowVerison()
        {
            m_MethodsCollection.ShowVerison();
        }
    }
}
