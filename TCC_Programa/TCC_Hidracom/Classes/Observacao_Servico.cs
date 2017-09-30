using log4net;
using System;
using System.Collections.Generic;

namespace TCC_Hidracom
{
    public class Observacao_Servico : Databaselist
    {
        #region Construtor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Observacao_Servico()
        {
            ID = 0;
            SetName_ID("id_observacao_servicos");
            SetTable("tcc_observacao_servicos");
            SetFields(new string[] { "nome_servico", "observacao" });
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Nome do servico
        /// </summary>
        public string Nome_Servico { get; set; }

        public string Observacao { get; set; }

        #endregion

        #region Public Methods


        /// <summary>
        /// Método que carregará as informações relevantes a essa tabela no banco.
        /// Por padrão, ele busca todas as informações no banco, caso queira uma informações diferente
        /// basta passar como parâmetro a query.
        /// Obs: Mesmo os campos sendo com final _id, a query padrão ela retorna o nome do cliente com base no seu ID cadastrado
        /// </summary>
        /// <param name="query">Query de consulta</param>
        /// <returns></returns>
        public List<Observacao_Servico> Load(string query = null)
        {
            try
            {
                var list = new List<Observacao_Servico>();
                var sc = OpenConnection();
                var load = string.IsNullOrEmpty(query) ? Read(GetSelectQuery(), sc) : Read(query, sc);

                while (load.Read())
                {
                    var ob = new Observacao_Servico()
                    {
                        ID = Convert.ToInt32(load["id_observacao_servicos"]),
                    };

                    string nome_servico, observacao;

                    if (load["nome_servico"].IsNotDBNull(out nome_servico))
                        ob.Nome_Servico = nome_servico;

                    if (load["observacao"].IsNotDBNull(out observacao))
                        ob.Observacao = observacao;

                    list.Add(ob);
                }
                
                CloseConnection(sc);
                return list;
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return new List<Observacao_Servico>();
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
                SetValues(new string[] { Nome_Servico, Observacao });
            }
            else
            {
                SetValues(new string[] { Nome_Servico, Observacao, ID.ToString() });
            }
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Flag do método de cadastrar
        /// </summary>
        private bool SaveIsRunning { get; set; }

        /// <summary>
        /// Log do programa
        /// </summary>
        private ILog _log { get; } = LogManager.GetLogger(typeof(Observacao_Servico));


        #endregion
    }
}
