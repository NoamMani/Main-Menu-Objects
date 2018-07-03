using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateTest
    {
        public void Run()
        {
            DelegateTestMethods delegateTestMethods = new DelegateTestMethods();
            MainMenu            mainMenu = new MainMenu("Main Menu");
            SubMenu             dateTimeMenu = new SubMenu("Show date and time");
            SubMenu             verisonAndCapital = new SubMenu("Verison and Capital");
            Command             showDate = new Command("Show date");
            Command             showTime = new Command("Show time");
            Command             countCapital = new Command("Count capital");
            Command             showVerison = new Command("Show verison");

            mainMenu.AddItem(dateTimeMenu, verisonAndCapital);
            dateTimeMenu.AddItem(showTime, showDate);
            verisonAndCapital.AddItem(countCapital, showVerison);
            showDate.CommandChoosen += delegateTestMethods.MethodsCollection_ShowDate;
            showTime.CommandChoosen += delegateTestMethods.MethodsCollection_ShowTime;
            countCapital.CommandChoosen += delegateTestMethods.MethodsCollection_CountCapital;
            showVerison.CommandChoosen += delegateTestMethods.MethodsCollection_ShowVerison;
            mainMenu.Show();
        }
    }
}
