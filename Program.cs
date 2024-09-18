using ElevatorApp;

class Program
{
    static void Main(string[] args)
    {
        ElevatorCabin elevator1 = new ElevatorCabin(1); 
        ElevatorCabin elevator2 = new ElevatorCabin(2); 

        simulatePassengers(elevator1, 14, 1);
        simulatePassengers(elevator2, 1, 15);
    }
    static void simulatePassengers(ElevatorCabin cabine, int endFloor, int startFloor)
    {
        Console.WriteLine("Пассажир вызывает лифт на " + startFloor + " этаже и поднимается на " + endFloor + " этаж.");
        cabine.PressFloorButton(startFloor);
        cabine.CloseDoors();
        cabine.PressFloorButton(endFloor); 
    }
}
