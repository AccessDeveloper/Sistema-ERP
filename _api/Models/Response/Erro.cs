namespace _api.Models.Response
{
    public class Erro
    {
        public int Codigo { get; set; }
        public string Msn { get; set; }

        public Erro(int codigo, string msn)
        {
            this.Codigo = codigo;
            this.Msn = msn;
        }
    }
}