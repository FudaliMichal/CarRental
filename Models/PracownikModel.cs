namespace CarRental.Models;

public class PracownikModel
{
    public int Id { get; set; }
    public int IdKontoUzytkownika { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public int PESEL { get; set; }
    public string Stanowisko { get; set; }
    public string EMail { get; set; }
}