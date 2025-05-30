using FilmArsiviProjesi;
using System;
class Program
{
    static void Main(string[] args)
    {
        FilmArsivi filmArsivi = new FilmArsivi();
        Admin admin = new Admin { KullaniciAdi = "admin" };
        Uye uye = new Uye { KullaniciAdi = "kullanici1" };
        // Film ekleme
        Film film1 = new Film { Ad = "Inception", Yonetmen = "Christopher Nolan", Yil = 2010 };
        admin.FilmEkle(film1, filmArsivi.FilmListesi);
        // Puanlama ve yorum
        uye.PuanlaFilm(film1, 5);
        uye.YorumYap(film1, "Mükemmel film!");
        // Film listele
        Console.WriteLine("Filmler:");
        filmArsivi.FilmListele();
        // En popüler filmler
        Console.WriteLine("\nEn Popüler Filmler:");
        var populerFilmler = filmArsivi.EnPopulerFilmleriGetir();
        foreach (var film in populerFilmler)
        {
            Console.WriteLine($"{film.Ad} - Ortalama Puan: {film.OrtalamaPuan()}");
        }
    }
}


