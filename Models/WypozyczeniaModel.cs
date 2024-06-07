namespace CarRental.Models;

public class WypozyczeniaModel
{
    public int IdWypozyczenia { get; set; }
    public int IdKlient { get; set; }
    public int IdSamochod { get; set; }
    public string DataOd { get; set; }
    public string DataDo { get; set; }
    public int LiczbaDni { get; set; }
    public int Cena { get; set; }
    public int Status { get; set; }
}

public enum RentStatus
{
    Nieopłacony,
    Opłacony
}