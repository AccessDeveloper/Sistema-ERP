namespace _api.Utils
{
    public class FuncionarioConversor
    {
        public Models.TbFuncionario ConvertparaTbFuncionario (Models.Request.FuncionarioRequest funci){
            Models.TbFuncionario atual = new Models.TbFuncionario();

            atual.NmFuncionario = funci.funcionario;
            atual.DsCpf = funci.cpf;
            atual.DsRg = funci.rg;
            atual.DtNascimento = funci.nascimento;
            atual.TpSexo = funci.sexo;
            atual.DsEndereco = funci.endereco;
            atual.DsComplemento = funci.complemento;
            atual.DsCep = funci.cep;
            atual.DsEmail = funci.email;
            atual.DsTelefone = funci.telefone;
            atual.DsCargo = funci.cargo;
            atual.DsCurriculo = funci.curriculo;
            atual.DsFoto = funci.foto;
            atual.NmUsuario = funci.usuario;
            atual.DsSenha = funci.senha;

            return atual;
        }
        public Models.Response.FuncionarioResponse ConvertparaResponse (Models.TbFuncionario funci){
            Models.Response.FuncionarioResponse atual = new Models.Response.FuncionarioResponse();

            atual.id = funci.IdFuncionario;
            atual.codigo = funci.DsCodigo;
            atual.funcionario = funci.NmFuncionario;
            atual.cpf = funci.DsCpf;
            atual.rg = funci.DsRg;
            atual.nascimento = funci.DtNascimento;
            atual.sexo = funci.TpSexo;
            atual.endereco = funci.DsEndereco;
            atual.complemento = funci.DsComplemento;
            atual.cep = funci.DsCep;
            atual.email = funci.DsEmail;
            atual.telefone = funci.DsTelefone;
            atual.cargo = funci.DsCargo;
            atual.curriculo = funci.DsCurriculo;
            atual.foto = funci.DsFoto;

            return atual;
        }
    }
}