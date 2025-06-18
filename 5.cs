class Weather
{
    public double Temperature { get; set; }
    public string Description { get; set; }

    public void PrintWeather()
    {
        System.Console.WriteLine($"Температура: {Temperature}°C, {Description}");
    }

    static void Main()
    {
        Weather weather = new Weather
        {
            Temperature = 25.5,
            Description = "Солнечно"
        };
        weather.PrintWeather();
    }
}