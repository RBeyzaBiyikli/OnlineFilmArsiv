

namespace FilmArsiviProjesi
{
    public class FilmArsivi
    {
        private List<Film> filmListesi = new List<Film>();

        public void FilmEkle(Film film)
        {
            filmListesi.Add(film);
        }

        public List<Film> EnPopulerFilmleriGetir()
        {
            return filmListesi.OrderByDescending(f => f.OrtalamaPuan()).ToList();
        }

        public void FilmListele()
        {
            foreach (var film in filmListesi)
            {
                Console.WriteLine($"{film.Ad} - Ortalama Puan: {film.OrtalamaPuan()}");
            }
        }
    }

}
