using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp
{
    // Кабина лифта
    class ElevatorCabin
    {
        public int CurrentFloor { get; private set; }
        public string State { get; private set; }
        public int ElevatorId { get; }

        public ElevatorCabin(int id)
        {
            CurrentFloor = 1;
            State = "Стоит с открытыми дверьми";
            ElevatorId = id;
        }

        // Метод для нажатия кнопки этажа
        public void PressFloorButton(int floor)
        {

            if (floor > CurrentFloor)
            {
                Console.WriteLine($"Лифт {ElevatorId}: Едем вверх на {floor}-й этаж.");
                State = "Едет вверх";
            }
            else
            {
                Console.WriteLine($"Лифт {ElevatorId}: Едем вниз на {floor}-й этаж.");
                State = "Едет вниз";
            }

            // Симуляция прибытия на этаж
            CurrentFloor = floor;
            OpenDoors();
        }

        // Метод для открытия дверей
        public void OpenDoors()
        {
            Console.WriteLine($"Лифт {ElevatorId}: Двери открываются");
            State = "Стоит с открытыми дверьми";
        }

        // Метод для закрытия дверей
        public void CloseDoors()
        {
            Console.WriteLine($"Лифт {ElevatorId}: Двери закрываются");
            State = "Двери закрыты";
        }

        // Метод для вызова диспетчера
        public void CallDispatcher()
        {
            Console.WriteLine($"Лифт {ElevatorId}: Вызов диспетчера");
        }

        // Метод для фиксации движения между дверьми
        public void DetectMovementBetweenDoors()
        {
            Console.WriteLine($"Лифт {ElevatorId}: Движение между дверьми зафиксировано. Остановите двери.");
            OpenDoors();
        }

        // Метод для фиксации отсутствия движения между дверьми
        public void DetectNoMovement()
        {
            Console.WriteLine($"Лифт {ElevatorId}: Движение между дверьми отсутствует. Закрытие дверей.");
            CloseDoors();
        }
    }
}