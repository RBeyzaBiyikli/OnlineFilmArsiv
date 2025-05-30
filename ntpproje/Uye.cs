namespace FilmArsiviProjesi
{
    public class Uye : Kullanici
    {
        public void PuanlaFilm(Film film, int puan)
        {
            film.Puanla(puan);
        }
        public void YorumYap(Film film, string yorum)
        {
            film.YorumEkle(yorum);
        }
    }
}