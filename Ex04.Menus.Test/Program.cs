namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfaceTest interfaceTest = new InterfaceTest();
            DelegateTest  delegateTest = new DelegateTest();

            interfaceTest.Run();
            delegateTest.Run();
        }
    }
}
