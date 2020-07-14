namespace _api.Models.Response
{
    public class Erro
    {
        public int Cod { get; set; }
        public string Msn { get; set; }

        public Erro (int cod, string msn)
        {
            this.Cod = cod;
            this.Msn = msn;
        }
    }
}