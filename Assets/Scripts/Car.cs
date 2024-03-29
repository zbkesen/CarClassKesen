//////////////////////////////////////////////
//Assignment/Lab/Project: Car Class
//Name: Zarek Kesen
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 2/18/2024
/////////////////////////////////////////////

public class Car
{
    private int year;
    private string make;
    private int maxSpeed = 100;
    private int currentSpeed = 0;

    public void ChangeYearOfCar(int newYear)
    {
        if (newYear <= 2024 && newYear >= 1886)
        {
            year = newYear;
        }
    }

    public int GetYear()
    {
        return year;
    }

    public void ChangeMakeOfCar(string newMake)
    {
        if (newMake == "" || newMake == null)
        {
            return;
        }
        else
        {
            make = newMake;
        }
    }

    public string GetMake()
    {
        return make;
    }

    public void Accelerate(int playerSpeed)
    {
        currentSpeed = playerSpeed;
        if (currentSpeed < maxSpeed)
        {
            currentSpeed++;
        }
    }
    public void Decelerate(int playerSpeed)
    {
        currentSpeed = playerSpeed;
        if (currentSpeed > 0 && currentSpeed <= maxSpeed)
        {
           currentSpeed--;
        }
    }

    public int GetSpeed()
    {
        return currentSpeed;
    }
}
