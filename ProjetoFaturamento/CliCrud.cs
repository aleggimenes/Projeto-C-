using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFaturamento
{
    class CliCrud
    {

        static List<CliCrud> listaCli = new List<CliCrud>();
        static int MaxId = 0;

        protected int _cod;
        protected string _nome;
        protected string _telefone;
        protected string _cpf;
        protected string _endereco;
        protected string _dataNasc;
        protected string _uf;
        protected string _cep;

        #region Construtores
        public CliCrud()
        {
            _cod = 0;
            _nome = "";
            _telefone = "";
            _cpf = "";
            _endereco = "";
            _dataNasc = "";
            _uf = "";
            _cep = "";
        }
        public CliCrud(string nome, string telefone, string cpf, string endereco, string dataNasc, string uf, string cep)
        {
            _nome = nome;
            _telefone = telefone;
            _cpf = cpf;
            _endereco = endereco;
            _dataNasc = dataNasc;
            _uf = uf;
            _cep = cep;
        }
        public CliCrud(int cod, string nome, string telefone, string cpf, string endereco, string dataNasc, string uf, string cep)
        {
            _cod = cod;
            _nome = nome;
            _telefone = telefone;
            _cpf = cpf;
            _endereco = endereco;
            _dataNasc = dataNasc;
            _uf = uf;
            _cep = cep;
        }
        public CliCrud(int cod)
        {
           CliCrud aux = listaCli.Find(lc => lc.COD == cod);
            _cod = aux.COD;
            _nome = aux.NOME;
            _telefone = aux.TELEFONE;
            _cpf = aux.CPF;
            _endereco = aux.ENDERECO;
            _dataNasc = aux.DATANASC;
            _uf = aux.UF;
            _cep = aux.CEP;
        }
        #endregion

        #region Propriedades
        public int COD
        {
            set { _cod = value;}
            get { return _cod; }
        }
        public string NOME
        {
            set { _nome = value;}
            get { return _nome; }
        }
        public string TELEFONE
        {
            set { _telefone = value; }
            get { return _telefone; }
        }
        public string CPF
        {
            set { _cpf = value; }
            get { return _cpf; }
        }
        public string ENDERECO
        {
            set { _endereco = value; }
            get { return _endereco; }
        }
        public string DATANASC
        {
            set { _dataNasc = value; }
            get { return _dataNasc; }
        }
        public string UF
        {
            set { _uf = value; }
            get { return _uf; }
        }
        public string CEP
        {
            set { _cep = value; }
            get { return _cep; }
        }
        #endregion

        #region Acessa Dados
        public void Inserir()
        {
            MaxId++;
            _cod = MaxId;
            listaCli.Add(this);
        }
        public static List<CliCrud> Consultar()
        {
            return listaCli;
        }
        public static List<CliCrud> Consultar(string cliente)
        {
            return listaCli.FindAll(ltg => ltg.NOME.Contains(cliente));
        }
        public void Alterar()
        {
            int i;
            i = listaCli.FindIndex(lg => lg.COD == _cod);
            listaCli[i].NOME = _nome;
            listaCli[i].TELEFONE = _telefone;
            listaCli[i].CPF = _cpf;
            listaCli[i].ENDERECO = _endereco;
            listaCli[i].DATANASC = _dataNasc;
            listaCli[i].UF = _uf;
            listaCli[i].CEP = _cep;
        }
        public void Excluir()
        { }
        #endregion
    }


}
