using RentCars.Types;

namespace RentCars.Models;

//7 - Faça a classe `Motorcycle` herdar de `Vehicle`
public class Motorcycle : Vehicle
{
    public double SeatHeight {get; set;}
    public BrakeType FrontBrake {get; set;}
    public BrakeType RearBrake {get; set;}
    // SeatHeight que deve ser do tipo double;
    // FrontBrake que deve ser do tipo BrakeType;
    // RearBrake que deve ser do tipo BrakeType;

}