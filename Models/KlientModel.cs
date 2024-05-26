namespace CarRental.Models;

public class KlientModel
{
    public int IdKontoUzytownika { get; set; }
    public int IdAdres { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string EMail { get; set; }
    public int IdWypozyczenia { get; set; }
}