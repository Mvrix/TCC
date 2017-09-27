using log4net;
using System;
using System.Collections.Generic;

namespace TCC_Hidracom
{
    /// <summary>
    /// HistoricoServicos será uma classe que facilitará o carregamento das informações do banco, além de servir como DataSet para gerar relatórios
    /// </summary>
    public class HistoricoServicos : Databaselist
    {
        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public HistoricoServicos()
        {
            ID = 0;
            SetName_ID("id");
            SetTable("tcc_servicos");
            SetFields(new string[] { "tecnico_id", "cliente_id", "servico_id", "data_marcada", "observacao" });
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Nome do cliente que requisitou o servico
        /// </summary>
        public string Cliente { get; set; }

        /// <summary>
        /// Nome do tecnico responsável pelo serviço
        /// </summary>
        public string Tecnico { get; set; }

        /// <summary>
        /// Descrição do serviço realizado
        /// </summary>
        public string Servico { get; set; }
        
        /// <summary>
        /// Data marcada para a realização do serviço
        /// </summary>
        public DateTime DataMarcada { get; set; }

        /// <summary>
        /// Alguma observação sobre o serviço
        /// </summary>
        public string Observacao { get; set; }

        /// <summary>
        /// Diz quantos resultados retornaram
        /// </summary>
        public int TotalResultados { get; set; } = 0;

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
        public List<HistoricoServicos> Load(string query = null)
        {
            try
            {
                var list = new List<HistoricoServicos>();
                var sc = OpenConnection();
                var load = string.IsNullOrEmpty(query) ? Read("SELECT ths.id, tt.nome as tecnico_id, tc.nome as cliente_id, ts.servico as servico_id, ths.data_marcada, ths.observacao FROM tcc_historico_servicos ths, tcc_clientes tc, tcc_servicos ts, tcc_tecnicos tt WHERE ths.cliente_id = tc.id AND ths.servico_id = ts.id AND ths.tecnico_id = tt.id", sc) : Read(query, sc);

                while (load.Read())
                {
                    list.Add(new HistoricoServicos()
                    {
                        ID = Convert.ToInt32(load["id"]),
                        Tecnico = Convert.IsDBNull(load["tecnico_id"]) ? default(string) : load["tecnico_id"].ToString(),
                        Cliente = Convert.IsDBNull(load["cliente_id"]) ? default(string) : load["cliente_id"].ToString(),
                        Servico = Convert.IsDBNull(load["servico_id"]) ? default(string) : load["servico_id"].ToString(),
                        DataMarcada = Convert.IsDBNull(load["data_marcada"]) ? default(DateTime) : Convert.ToDateTime(load["data_marcada"]),
                        Observacao = Convert.IsDBNull(load["observacao"]) ? default(string) : load["observacao"].ToString(),
                    });
                }

                TotalResultados = list.Count;
                CloseConnection(sc);
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retorna uma instancia
        /// </summary>
        /// <returns></returns>
        public List<HistoricoServicos> GetInstance()
        {
            return new List<HistoricoServicos>()
            {
                new HistoricoServicos()
                {
                    Tecnico = "Fake",
                    Cliente = "João",
                    Servico = "Tester",
                    DataMarcada = DateTime.Now,
                    Observacao = "Funciona ai",
                },
                new HistoricoServicos()
                {
                    Tecnico = "Fake",
                    Cliente = "João",
                    Servico = "Tester",
                    DataMarcada = DateTime.Now,
                    Observacao = "Funciona ai",
                },
                new HistoricoServicos()
                {
                    Tecnico = "Fake",
                    Cliente = "João",
                    Servico = "Tester",
                    DataMarcada = DateTime.Now,
                    Observacao = "Funciona ai",
                },
                new HistoricoServicos()
                {
                    Tecnico = "Fake",
                    Cliente = "João",
                    Servico = "Tester",
                    DataMarcada = DateTime.Now,
                    Observacao = "Funciona ai",
                },
                new HistoricoServicos()
                {
                    Tecnico = "Fake",
                    Cliente = "João",
                    Servico = "Tester",
                    DataMarcada = DateTime.Now,
                    Observacao = "Funciona ai",
                }
            };
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
