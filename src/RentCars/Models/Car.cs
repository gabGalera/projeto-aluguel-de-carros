using RentCars.Types;
namespace RentCars.Models;

//6 - Faça a classe `Car` herdar de `Vehicle`
public class Car : Vehicle
{
    public int Seats {get; set;}
    public int Doors {get; set;}
    public TractionType Traction {get; set;}
    public BrakeType FrontBrake {get; set;}
    public BrakeType RearBrake {get; set;}
    // Seats que deve ser do tipo Int;
    // Doors que deve ser do tipo Int;
    // Traction que deve ser do tipo TractionType;
    // FrontBrake que deve ser do tipo BrakeType;
    // RearBrake que deve ser do tipo BrakeType;

}