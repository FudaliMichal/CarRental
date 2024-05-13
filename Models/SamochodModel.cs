namespace CarRental.Models;

public class SamochodModel
{
    public int Id { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Miejsca { get; set; }
    public string TypAuta { get; set; }
    public Paliwo RodzajPaliwa { get; set; }
    public bool CzyZajety { get; set; }
    
    public int IdKlient { get; set; }
    public string PhotoPath { get; set; }

}

public enum Paliwo
{
    Elektryczny = 0,
    Bezyna,
    Diesel
}