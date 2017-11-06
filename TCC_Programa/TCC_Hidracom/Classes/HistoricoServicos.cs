using log4net;
using System;
using System.Linq;
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
            SetName_ID("id_servicos");
            SetTable("tcc_servicos");
            SetFields(new string[] { "tecnico_id", "pessoas_id", "observacao_servico_id", "data_marcada", "observacao" });
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
        public List<HistoricoServicos> LoadHistoricos()
        {
            try
            {
                var list = new List<HistoricoServicos>();
                var sc = OpenConnection();
                var load = Read("select * from get_historico_servicos", sc);

                while (load.Read())
                {
                    var hs = new HistoricoServicos()
                    {
                        ID = Convert.ToInt32(load["id_servicos"]),
                    };

                    string nome_tecnico, nome_cliente, nome_servico, observacao;
                    DateTime data_marcada;
                    
                    if (load["nome_cliente"].IsNotDBNull(out nome_cliente))
                        hs.Cliente = nome_cliente;

                    if (load["nome_tecnico"].IsNotDBNull(out nome_tecnico))
                        hs.Tecnico = nome_tecnico;

                    if (load["nome_servico"].IsNotDBNull(out nome_servico))
                        hs.Servico = nome_servico;

                    if (load["data_marcada"].IsNotDBNull(out data_marcada))
                        hs.DataMarcada = data_marcada;

                    if (load["observacao"].IsNotDBNull(out observacao))
                        hs.Observacao = observacao;

                    list.Add(hs);  
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
        /// Método que carregará as informações relevantes a essa tabela no banco.
        /// Por padrão, ele busca todas as informações no banco, caso queira uma informações diferente
        /// basta passar como parâmetro a query.
        /// Obs: Mesmo os campos sendo com final _id, a query padrão ela retorna o nome do cliente com base no seu ID cadastrado
        /// </summary>
        /// <param name="query">Query de consulta</param>
        /// <returns></returns>
        public List<HistoricoServicos> Load(string query)
        {
            try
            {
                var list = new List<HistoricoServicos>();
                var sc = OpenConnection();
                var load = Read(query, sc);

                while (load.Read())
                {
                    var hs = new HistoricoServicos()
                    {
                        ID = Convert.ToInt32(load["id_servicos"]),
                    };

                    string nome_tecnico, nome_cliente, nome_servico, observacao;
                    DateTime data_marcada;

                    if (load["nome_cliente"].IsNotDBNull(out nome_cliente))
                        hs.Cliente = nome_cliente;

                    if (load["nome_tecnico"].IsNotDBNull(out nome_tecnico))
                        hs.Tecnico = nome_tecnico;

                    if (load["nome_servico"].IsNotDBNull(out nome_servico))
                        hs.Servico = nome_servico;

                    if (load["data_marcada"].IsNotDBNull(out data_marcada))
                        hs.DataMarcada = data_marcada;

                    if (load["observacao"].IsNotDBNull(out observacao))
                        hs.Observacao = observacao;

                    list.Add(hs);
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
