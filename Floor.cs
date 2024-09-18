using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp
{
    class Floor
    {
        public int Elevator1Floor { get; private set; }
        public string Elevator1State { get; private set; }

        public int Elevator2Floor { get; private set; }
        public string Elevator2State { get; private set; }

        public bool CallButtonPressed { get; private set; }

        public Floor()
        {
            Elevator1Floor = 1;
            Elevator1State = "Стоит с открытыми дверьми";

            Elevator2Floor = 1;
            Elevator2State = "Стоит с открытыми дверьми";

            CallButtonPressed = false;
        }

        // Метод для нажатия кнопки вызова лифта
        public void PressCallButton()
        {
            Console.WriteLine("Кнопка вызова лифта нажата.");
            CallButtonPressed = true;
        }
    }
}
