namespace CarRental.Models;

public class WypozyczeniaModel
{
    public int IdWypozyczenia { get; set; }
    public int IdKlient { get; set; }
    public int IdSamochod { get; set; }
    public DateTime DataOd { get; set; }
    public DateTime DataDo { get; set; }
    public int LiczbaDni { get; set; }
    public int Cena { get; set; }
}