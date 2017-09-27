using log4net;
using System;
using System.Collections.Generic;

namespace TCC_Hidracom
{
    /// <summary>
    /// Tabela que vai guardar os registros tanto dos clientes quanto dos funcionarios
    /// </summary>
    public class Pessoas : Databaselist
    {
        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Pessoas()
        {
            ID = 0;
            SetName_ID("id_pessoa");
            SetTable("tcc_pessoas");
            SetFields(new string[] { "nome", "endereco", "bairro", "cep", "telefone", "email", "rg", "cpf", "cidade", "datanasc", "tipo", "observacao", });
        }

        #endregion

        #region Public Properties

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public string Cidade { get; set; }

        public DateTime DataNasc { get; set; } = DateTime.Now;

        public int Tipo { get; set; }

        public string Observacao { get; set; }



        #endregion

        #region Public Methods

        /// <summary>
        /// Vai buscar no banco de dados e retornar uma lista de pessoas
        /// <param name="tipo">Tipo da pessoa</param>
        /// <returns></returns>
        public List<Pessoas> Load(int tipo)
        {
            try
            {
                var list = new List<Pessoas>();
                var sc = OpenConnection();
                var load = Read($"SELECT * FROM tcc_pessoas WHERE tipo = '{tipo}'", sc);

                while (load.Read())
                {
                    list.Add(new Pessoas()
                    {
                        ID = Convert.ToInt32(load["id_pessoa"]),
                        Nome = load["nome"].ToString(),
                        Endereco = load["endereco"].ToString(),
                        Bairro = load["bairro"].ToString(),
                        Cep = load["cep"].ToString(),
                        Telefone = load["telefone"].ToString(),
                        Email = load["email"].ToString(),
                        Rg = load["rg"].ToString(),
                        Cpf = load["cpf"].ToString(),
                        Cidade = load["cidade"].ToString(),
                        DataNasc = Convert.ToDateTime(load["datanasc"]),
                        Tipo = Convert.ToInt32(load["tipo"]),
                        Observacao  = load["observacao"].ToString(),
                    });
                }

                CloseConnection(sc);
                return list;
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return new List<Pessoas>();
            }
        }

        /// <summary>
        /// Faz uma pesquisa na tabela de pessoas
        /// </summary>
        /// <param name="tipo">Tipo da pessoa</param>
        /// <param name="text">Texto que será pesquisado</param>
        /// <returns></returns>
        public List<Pessoas> Search(int tipo, string text)
        {
            try
            {
                var list = new List<Pessoas>();
                var sc = OpenConnection();
                var load = Read($"SELECT * FROM tcc_pessoas WHERE tipo = '{tipo}' AND id = '{text}' AND nome LIKE '%{text}%' AND telefone LIKE '%{text}%' AND rg LIKE '%{text}%' AND cpf LIKE '%{text}%'" , sc);

                while (load.Read())
                {
                    list.Add(new Pessoas()
                    {
                        ID = Convert.ToInt32(load["id_pessoa"]),
                        Nome = load["nome"].ToString(),
                        Endereco = load["endereco"].ToString(),
                        Bairro = load["bairro"].ToString(),
                        Cep = load["cep"].ToString(),
                        Telefone = load["telefone"].ToString(),
                        Email = load["email"].ToString(),
                        Rg = load["rg"].ToString(),
                        Cpf = load["cpf"].ToString(),
                        Cidade = load["cidade"].ToString(),
                        DataNasc = Convert.ToDateTime(load["datanasc"]),
                        Tipo = Convert.ToInt32(load["tipo"]),
                        Observacao = load["observacao"].ToString(),
                    });
                }

                CloseConnection(sc);
                return list;
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return new List<Pessoas>();
            }
        }

        /// <summary>
        /// Passa os valores para o DatabaseList
        /// </summary>
        /// <param name="forceInsert">Força uma inserção no banco de dados</param>
        public void SetValues(bool forceInsert = false)
        {
            if (ID == 0 || forceInsert)
            {
                SetValues(new string[] { Nome, Endereco, Bairro, Cep ?? default(string), Telefone ?? default(string), Email, Rg ?? default(string), Cpf ?? default(string), Cidade, DataNasc.ToShortDateString(), Tipo.ToString(), Observacao });
            }
            else
            {
                SetValues(new string[] { Nome, Endereco, Bairro, Cep ?? default(string), Telefone ?? default(string), Email, Rg ?? default(string), Cpf ?? default(string), Cidade, DataNasc.ToShortDateString(), Tipo.ToString(), Observacao, ID.ToString() });
            }
        }


        #endregion

        #region Private Properties

        /// <summary>
        /// Log do programa
        /// </summary>
        private ILog _log { get; } = LogManager.GetLogger(typeof(HistoricoServicos));

        /// <summary>
        /// Encurta a chamada
        /// </summary>
        private ApplicationViewModel _IoC { get; set; } = IoC.Get<ApplicationViewModel>();

        #endregion
    }
}
