namespace CarRental.Models;

public class SamochodModel
{
    public int Id { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Miejsce { get; set; }
    public string TypAuta { get; set; }
    public int RodzajPaliwa { get; set; }
    public bool CzyZajety { get; set; }
    public int IdKlient { get; set; }
    public string URL { get; set; }

}

public enum Paliwo
{
    Elektryczny = 0,
    Bezyna,
    Diesel
}