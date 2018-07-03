using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceTest
    {
        public void Run()
        {
            MainMenu      menu = new MainMenu("Main Menu");
            SubMenu       dateTimeMenu = new SubMenu("Show date and time");
            SubMenu       verisonAndCapital = new SubMenu("Verison and Capital");
            ShowTime      showTime = new ShowTime("Show time");
            ShowDate      showDate = new ShowDate("Show date");
            CountCapitals countCapitals = new CountCapitals("Count Capitals");
            ShowVerison   showVerison = new ShowVerison("Show verison");

            menu.AddItem(dateTimeMenu);
            menu.AddItem(verisonAndCapital);
            dateTimeMenu.AddItem(showTime);
            dateTimeMenu.AddItem(showDate);
            verisonAndCapital.AddItem(countCapitals);
            verisonAndCapital.AddItem(showVerison);
            menu.Show();
        }
    }
}
