using System;

class Computer
{
    public string Model { get; set; }
    public int RAM { get; set; }

    static void Main()
    {
        Computer[] computers = new Computer[]
        {
            new Computer { Model = "Dell XPS", RAM = 16 },
            new Computer { Model = "HP Pavilion", RAM = 8 },
            new Computer { Model = "Lenovo ThinkPad", RAM = 32 }
        };

        foreach (var computer in computers)
        {
            System.Console.WriteLine($"Модель: {computer.Model}, ОЗУ: {computer.RAM}ГБ");
        }
    }
}
