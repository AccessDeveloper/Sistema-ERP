using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _api.Business
{
    public class FuncionarioBusiness
    {
        DataBase.FuncionarioDataBase funcaobd = new DataBase.FuncionarioDataBase();
        public Models.TbFuncionario ConsultarCodigoFuncionario(string codigo)
        {
            if(string.IsNullOrEmpty(codigo))
                throw new ArgumentException ("Nescessario inserir o código do funcionario para que possamos realzar a consulta.");

            return funcaobd.ConsultarFuncionario(codigo);
        }

        public Models.TbFuncionario InserirFuncionario (Models.TbFuncionario novo)
        {
            if(funcaobd.ListarFuncionarios().Any(x => x.DsCodigo == novo.DsCodigo))
                throw new ArgumentException("Codigo do funcionario já é fadastrado.");
            if(string.IsNullOrEmpty(novo.NmFuncionario))
                throw new ArgumentException("Campo nome do funcionario não foi preenchido.");
            if(string.IsNullOrEmpty(novo.DsCpf) && string.IsNullOrEmpty(novo.DsRg))
                throw new ArgumentException("Documentos de identificação são obrigatórios (RG, CPF e Carteira de Trabalho.)");
            if(novo.DtNascimento > DateTime.Now.AddYears(-16))
                throw new ArgumentException ("Funcionario deve ter no minino 16 anos de idade.");
            if(string.IsNullOrEmpty(novo.DsCargo))
               throw new ArgumentException("Para cadastra o funcionario é nescessario o cargo que assumira.");
            if(string.IsNullOrEmpty(novo.DsSenha))
                throw new ArgumentException("Senha é obrigatória para realizar o cadastro de funcionario.");
            
            return funcaobd.InserirFuncionario(novo);
        }
    }
}