using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateChart_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller ctrl = new Controller();
            while (!ctrl.IsFinalState())
            {
                string line = Console.ReadLine();
                switch (line[0])
                {
                    case 'A': ctrl.eventA(); break;
                    case 'B': ctrl.eventB(); break;
                    case 'C': ctrl.eventC(); break;
                    case 'D': ctrl.eventE(); break;
                    case 'E': ctrl.eventE(); break;
                    default:
                        Console.WriteLine("Input not an event: " + line);
                        break;
                }
                Console.WriteLine("STATUS: " + ctrl.ToString());
            }
        }
    }
    class Controller
    {
        private int stateOfA = 1;
        private int stateOfB = 4;
        private int stateOfC = 7;
        private int stateOfD = 9;
        private int stateOfE = 11;
        private int stateOfF = 13;
        private bool finalState = false;

        public Controller()
        {
            goState1();
            goState4();
        }

        override public string ToString()
        {
            return "state of A = " + stateOfA + "  state of B = " + stateOfB + "  state of C = " + stateOfC 
                + "  state of D = " + stateOfD + "  state of E = " + stateOfE + "  state of F = " + stateOfF;
        }

        private void goState1()
        {
            stateOfA = 1;
            Console.WriteLine("Entering State 1\n");
        }
        private void goState2()
        {
            stateOfA = 2;
            Console.WriteLine("Entering State 2\n");
        }
        private void goState3()
        {
            stateOfA = 3;
            Console.WriteLine("Entering State 3\n");
        }
        private void goState4()
        {
            stateOfB = 4;
            Console.WriteLine("Entering State 4\n");
        }
        private void goState5()
        {
            stateOfB = 5;
            Console.WriteLine("Entering State 5\n");
        }
        private void goState6()
        {
            stateOfC = 6;
            Console.WriteLine("Entering State 6\n");
        }
        private void goState7()
        {
            stateOfC = 7;
            Console.WriteLine("Entering State 7\n");
        }
        private void goState8()
        {
            stateOfD = 8;
            Console.WriteLine("Entering State 8\n");
        }
        private void goState9()
        {
            stateOfD = 9;
            Console.WriteLine("Entering State 9\n");
        }
        private void goState10()
        {
            stateOfE = 10;
            Console.WriteLine("Entering State 10\n");
        }
        private void goState11()
        {
            stateOfE = 11;
            Console.WriteLine("Entering State 11\n");
        }
        private void goState12()
        {
            stateOfF = 12;
            Console.WriteLine("Entering State 12\n");
        }
        private void goState13()
        {
            stateOfF = 13;
            Console.WriteLine("Entering State 13\n");
        }


        public bool IsFinalState()
        {
            return finalState;
        }

        public void eventA()
        {
            if (stateOfA == 1 && stateOfB == 5)
            {
                goState4();
            }
            else if (stateOfA == 2 && stateOfC == 6 && stateOfF == 12)
            {
                goState13();
            }
        }
        public void eventB()
        {
        }
        public void eventC()
        {
        }
        public void eventD()
        {
        }
        public void eventE()
        {
        }

    }
}
