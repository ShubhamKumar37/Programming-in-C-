using System;

namespace SimpleException;

internal class Car
{
	public const int Maxspeed = 100;

	private bool _isCarDead = false;

	private readonly Radio _theMusicBox = new Radio();

	public int CurrSped { get; set; } = 0;


	public string PetName { get; set; } = "";


	public Car()
	{
	}

	public Car(int speed, string petName)
	{
		PetName = petName;
		CurrSped = speed;
	}

	public void CrankTunes(bool state)
	{
		_theMusicBox.TurnOn(state);
	}

	public void Accelerate(int delta)
	{
		if (_isCarDead)
		{
			Console.WriteLine("Already dead car");
			return;
		}
		CurrSped += delta;
		if (CurrSped > 100)
		{
			CurrSped = 0;
			_isCarDead = true;
			throw new Exception(PetName + " has been overheated");
		}
		Console.WriteLine("{0} is the current speed", CurrSped);
	}
}
