namespace _api.Utils
{
    public class Escalaconversor
    {
        public Models.Response.EscalaResponse ConvertParaResponse(Models.TbEscalaDeTrabalho escala)
        {
            Models.Response.EscalaResponse escalaceonvert = new Models.Response.EscalaResponse();

            escalaceonvert.funcionario = escala.IdFuncionarioNavigation.NmFuncionario;
            escalaceonvert.domingo = escala.BtDomingo;
            escalaceonvert.segunda = escala.BtSegunda;
            escalaceonvert.terca = escala.BtTerca;
            escalaceonvert.quarta = escala.BtQuarta;
            escalaceonvert.quinta = escala.BtQuinta;
            escalaceonvert.sexta = escala.BtSexta;
            escalaceonvert.sabado = escala.BtSabado;
            escalaceonvert.saida = escala.HrEntrada;
            escalaceonvert.entrada = escala.HrSaida;

            return escalaceonvert;
        }
    }
}