namespace FilmArsiviProjesi
{
    public class Admin : Kullanici
    {
        public void FilmEkle(Film film, List<Film> filmListesi)
        {
            filmListesi.Add(film);
        }
    }

}