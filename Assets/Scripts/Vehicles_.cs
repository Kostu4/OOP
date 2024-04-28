using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicles_ : MonoBehaviour
{
    [ContextMenu(nameof(Show))]
    private void Show()
    {
        var vehicle = new Car();
        var vehicle1 = new Ship();
        var vehicle2 = new Plane();

        Vehicles[] vehicles_value = { vehicle, vehicle1, vehicle2 };

        foreach (var _vehicle_value in vehicles_value)
        {
            _vehicle_value.Go();

            if (_vehicle_value is Car)
            { 
                var car = (Car) _vehicle_value;

                car.Lights();
            }
        }
    }
}
public abstract class Vehicles : IMove
{
    public abstract void Go();

    public virtual void Lights()
    {
        Debug.Log("Turning on the lights");
    }
}
public class Car : Vehicles
{
    private readonly bool islight = false;
    public override void Go() => Debug.Log("Trrrr...");
    public override void Lights()
    {

        if (islight)
        {
            Debug.Log("The lights are broken");
        }
        else
        {
            base.Lights();
        }
    }
}

public class Ship : Vehicles
{
    public override void Go() => Debug.Log("PUUUUUUUUU");

}

public class Plane : Vehicles
{
    public override void Go() => Debug.Log("SHHHHH");

}

public interface IMove
{
    void Move()
    {
        Debug.Log("Moving");
    }
}

