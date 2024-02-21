using System;

public class Display
{
	public void Run()
	{
	string[] number = {"1", "2", "3", "4", "5", "6", "7", "8","9", "10", "11", "12", "13", "14", "15",};
		int[] cube = new int[15];
		//Start(cube);
		//Display(number, cube);
	}
	public void DisplayA(string[] number, int[] cube) 
	{
		
		//Визуална репрезентация за Пъзел 15
		
		Console.WriteLine("---------------------------");
		Start(cube);
		Console.WriteLine("|  " + number[cube[0]] + "  |  " + number[cube[1]] + "  |  " + number[cube[2]] + "  |  " + number[cube[3]] + "  |");
		Console.WriteLine("---------------------------");
		Start(cube); 
		Console.WriteLine("|  " + number[cube[4]] + "  |  " + number[cube[5]] + "  |  " + number[cube[6]] + "  |  " + number[cube[7]] + "  |");
		Console.WriteLine("---------------------------");
		Console.WriteLine("|  " + number[cube[8]] + "  |  " + number[cube[9]] + "  |  " + number[cube[10]] + "  |  " + number[cube[11]] + "  |");
		Console.WriteLine("---------------------------");
		Start(cube);
		Console.WriteLine("|  " + number[cube[12]] + "  |  " + number[cube[13]] + "  |  " + number[cube[14]] + "  |  " + " " + "  |");
		Console.WriteLine("---------------------------");
	}
	
	public static void DisplayB(string[] number, int[] cube) 
	{
		
		//Визуална репрезентация за Пъзел 15
		
		Console.WriteLine("-----------------------------------");
		Start(cube);
		Console.WriteLine("|  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + "  |");
		Console.WriteLine("|  " + " " + number[cube[0]] + " " + "  |  " + " " + number[cube[1]] + " " + "  |  " + " " + number[cube[2]] + " " + "  |  " + number[cube[3]] + " " + "  |");
		Console.WriteLine("|  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + "  |");
		Console.WriteLine("-----------------------------------");
		Start(cube); 
		Console.WriteLine("|  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + "  |");
		Console.WriteLine("|  " + " " + number[cube[4]] + " " + "  |  " + " " + number[cube[5]] + " " + "  |  " + " " + number[cube[6]] + " " + "  |  " + number[cube[7]] + " " + "  |");
		Console.WriteLine("|  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + "  |");
		Console.WriteLine("-----------------------------------");
		Console.WriteLine("|  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + "  |");
		Console.WriteLine("|  " + " " + number[cube[8]] + " " + "  |  " + " " + number[cube[9]] + " " + "  |  " + " " + number[cube[10]] + " " + "  |  " + number[cube[11]] + " " + "  |");
		Console.WriteLine("|  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + "  |");
		Console.WriteLine("-----------------------------------");
		Start(cube);
		Console.WriteLine("|  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + "  |");
		Console.WriteLine("|  " + " " + number[cube[12]] + " " + "  |  " + " " + number[cube[13]] + " " + "  |  " + " " + number[cube[14]] + " " + "  |  " + " " + "  |");
		Console.WriteLine("|  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + " " + "  |  " + " " + " " + "  |");
		Console.WriteLine("-----------------------------------");
	}

	public void Start(int[] chisla)
	{
		Random rnd = new Random();
		for (int i = 0; i < 15; i++)
		{
			chisla[i] = rnd.Next(0, 15);
		//Console.WriteLine(chisla); 
		}
	}
}
