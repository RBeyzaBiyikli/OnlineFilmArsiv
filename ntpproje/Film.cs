namespace FilmArsiviProjesi
{
    public class Film : IPuanlanabilir, IYorumlanabilir
    {
        public string Ad { get; set; }
        public string Yönetmen { get; set; }
        public int Yıl { get; set; }
        private List<int> puanlar = new List<int>();
        private List<string> yorumlar = new List<string>();
        public void Puanla(int puan)
        {
            puanlar.Add(puan);
        }
        public double OrtalamaPuan()
        {
            return puanlar.Count > 0 ? puanlar.Average() : 0;
        }
        public void YorumEkle(string yorum)
        {
            yorumlar.Add(yorum);
        }
        public List<string> YorumlarıGetir()
        {
            return yorumlar;
        }
    }
}