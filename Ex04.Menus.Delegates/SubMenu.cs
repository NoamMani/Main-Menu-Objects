using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private const int k_BackOrExit = 0;

        private readonly Dictionary<int, MenuItem> m_MenuOptionsList = new Dictionary<int, MenuItem>();
        private int                                m_NumberOfInstruct = 1;

        public SubMenu(string i_HeadLine) : base(i_HeadLine)
        {
            m_MenuOptionsList.Add(k_BackOrExit, null);
        }

        public void AddItem(params MenuItem[] i_NewItems)
        {
            foreach (MenuItem newItem in i_NewItems)
            {
                m_MenuOptionsList.Add(m_NumberOfInstruct++, newItem);
            }
        }

        public void Show(int i_CurrectLevel)
        {
            int     inputChoice;
            SubMenu subMenu;

            do
            {
                printMenu(i_CurrectLevel);
                inputChoice = getChoiceFromUser();
                Console.Clear();

                // $G$ DSN-008 (-5) You should have used polymorphism to implement the 
                // different behavior between a sub menu and action item.

                subMenu = m_MenuOptionsList[inputChoice] as SubMenu;
                if (subMenu != null)
                {
                    subMenu.Show(i_CurrectLevel + 1);
                }
                else if (m_MenuOptionsList[inputChoice] is Command)
                {
                    ((Command)m_MenuOptionsList[inputChoice]).RunChosenAction();
                }
            }
            while (inputChoice != k_BackOrExit);
        }

        private void printHeadline(int i_CurrectLevel)
        {
            Console.WriteLine("You are in level {0}", i_CurrectLevel);
            Console.WriteLine(ToString());
            for (int i = 0; i < ToString().Length; i++)
            {
                Console.Write("=");
            }

            Console.Write(Environment.NewLine);
        }

        private void printMenu(int i_CurrectLevel)
        {
            printHeadline(i_CurrectLevel);
            foreach (int numberOfOption in m_MenuOptionsList.Keys)
            {
                // $G$ DSN-999 (-2)  You should have used polymorphism to implement the difference between 'back' and 'exit'
                if (numberOfOption == k_BackOrExit)
                {
                    Console.WriteLine("0. {0}", i_CurrectLevel == MainMenu.k_FirstLevel ? "Exit" : "Back");
                }
                else
                {
                    Console.WriteLine("{0}. {1}", numberOfOption.ToString(), m_MenuOptionsList[numberOfOption].ToString());
                }
            }

            Console.WriteLine("Please choose from the options.");
        }

        private int getChoiceFromUser()
        {
            string inputFromUser;
            int    userChoice;

            inputFromUser = Console.ReadLine();

            while (!int.TryParse(inputFromUser, out userChoice) || !m_MenuOptionsList.ContainsKey(userChoice))
            {
                Console.WriteLine("Invalid. Plaese choose from the options.");
                inputFromUser = Console.ReadLine();
            }

            return userChoice;
        }
    }
}
