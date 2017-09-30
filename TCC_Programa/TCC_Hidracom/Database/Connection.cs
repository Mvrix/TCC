using System;
using System.Data.SqlClient;
using System.Text;

namespace TCC_Hidracom
{
    public class Connection
    {
        #region Private Properties

        /// <summary>
        /// Log do programa
        /// </summary>
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(Connection));
        
        #endregion

        #region Public methods

        /// <summary>
        /// Retorna a conexão
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {

            //string stringConnection = string.Format("Data Source=DESKTOP-GFEUDM5;Initial Catalog=Unidente;Integrated Security=True");
            var stringConnection = "Data Source=172.168.255.252;Initial Catalog=db_01359_14_A_1_2015;User ID=01359_14_A_1_2015;Password=123456Alfa";
            return new SqlConnection(stringConnection.ToString());
        }

        /// <summary>
        /// Abre a conexão com o banco de dados
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenConnection()
        {
            var connection = GetConnection();

            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Testa para ver se há conexão com o banco de dados
        /// </summary>
        /// <returns></returns>
        public bool TestConnection()
        {
            var connection = GetConnection();

            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
            return false;
        }

        /// <summary>
        /// Testa para ver se há conexão com o banco de dados
        /// </summary>
        /// <param name="noShowMain">Diz se é para exibir uma mensagem na parte inferior da tela</param>
        /// <returns></returns>
        public static bool TestStaticConnection(bool noShowMain = false)
        {
            var connection = new Connection().GetConnection();

            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
            return false;
        }

        /// <summary>
        /// Fecha a conexão com o banco de dados
        /// </summary>
        /// <param name="connection">A conexão aberta</param>
        public void CloseConnection(SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                throw e;
            }
        } 

        #endregion
    }
}
