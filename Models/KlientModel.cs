namespace CarRental.Models;

public class KlientModel
{
    public int IdKlient { get; set; }
    public int IdKontoUzytownika { get; set; }
    public int IdAdres { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string EMail { get; set; }
}