
namespace FilmArsiviProjesi
{
    public interface IYorumlanabilir
    {
        void YorumEkle(string yorum);
        List<string> YorumlarıGetir();
    }
}
