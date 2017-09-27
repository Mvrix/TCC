using log4net;
using System;
using System.Data.SqlClient;

namespace TCC_Hidracom
{
    public class Databaselist : Connection
    {
        #region Private Properties

        /// <summary>
        /// Log do programa
        /// </summary>
        private static readonly ILog _log = log4net.LogManager.GetLogger(typeof(Databaselist));

        #endregion

        #region Public Methods

        /// <summary>
        /// Salva as informações da tabela no banco de dados
        /// </summary>
        /// <param name="forceInsert">Força um comando de insert</param>
        public void Save(bool forceInsert = false)
        {
            try
            {
                ExecuteNonQuery(ID == 0 || forceInsert ? GetInsertString() : GetUpdateString());
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        /// <summary>
        /// Deleta os valores no banco de dados
        /// </summary>
        public void Delete()
        {
            try
            {
                ExecuteNonQuery(GetDeleteString());
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        /// <summary>
        /// Executa uma consulta no banco de dados sem retornar valores
        /// </summary>
        /// <param name="query">String de consulta</param>
        public void ExecuteNonQuery(string query)
        {
            _log.Info(query);

            var sc = OpenConnection();

            if (sc != null)
                new SqlCommand(query, sc).ExecuteNonQuery();

            CloseConnection(sc);
        }

        /// <summary>
        /// Executa uma consulta no banco de dados que retorna um valor
        /// </summary>
        /// <param name="query">String de consulta</param>
        /// <param name="sc">Sql Connection</param>
        /// <returns></returns>
        public SqlDataReader Read(string query, SqlConnection sc)
        {
            _log.Info(query);
            return sc == null ? null : new SqlCommand(query, sc).ExecuteReader();
        }

        /// <summary>
        /// Retorna a string de update
        /// </summary>
        /// <returns></returns>
        public string GetUpdateString()
        {
            var fields = GetFields();
            var values = GetValues();

            var set = string.Empty;
            for (var i = 0; i < fields.Length; i++)
            {
                if ((fields.Length - 1) != i)
                {
                    set += string.Concat(fields[i], " = '", values[i], "', ");
                }
                else
                {
                    set += string.Concat(fields[i], " = '", values[i]);
                }
            }
            return string.Format("UPDATE " + GetTable() + " SET {0}' WHERE id = {1}", set, values[values.Length - 1]);
        }

        /// <summary>
        /// Retorna a string de insert
        /// </summary>
        /// <returns></returns>
        public string GetInsertString()
        {
            return string.Format("INSERT INTO {0} ({1}) VALUES ('{2}')", GetTable(), string.Join(", ", GetFields()), string.Join("','", GetValues()));
        }

        /// <summary>
        /// Retorna a string de delete
        /// </summary>
        /// <returns></returns>
        public string GetDeleteString()
        {
            return string.Format("DELETE FROM {0} WHERE ID = {1}", GetTable(), ID);
        }

        /// <summary>
        /// Retorna a string de select
        /// </summary>
        /// <returns></returns>
        public string GetSelectQuery()
        {
            var haveWhere = !string.IsNullOrEmpty(GetFilter()) ? " WHERE " : string.Empty;
            var fieldsLoad = string.Join(", ", GetFields());
            var filterLoad = !string.IsNullOrEmpty(GetFilter()) ? GetFilter() : string.Empty;
            var orderLoad = !string.IsNullOrEmpty(GetOrder()) ? " ORDER BY " + GetOrder() : string.Empty;

            // TODO: Arrumar o Limit e fazer com que ele funcione!
            var limitLoad = !string.IsNullOrEmpty(GetLimit()) ? " LIMIT " + GetLimit() : string.Empty;

            return "SELECT "+ GetName_ID() + ", " + fieldsLoad + " FROM " + GetTable() + " " + haveWhere + filterLoad + orderLoad + limitLoad;
        }

        /// <summary>
        /// Retorna quantos itens estão cadastrados na tabela
        /// </summary>
        /// <returns></returns>
        public int TotalOfItems()
        {
            try
            {
                var c = OpenConnection();
                var load = Read("SELECT COUNT(*) as Total FROM " + GetTable(), c);

                var total = 0;
                while (load.Read())
                {
                    total = Convert.ToInt32(load["Total"]);
                }
                CloseConnection(c);
                return total;
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return 0;
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Nome da primary key no bd
        /// </summary>
        public string Name_ID { get; set; }

        /// <summary>
        /// Nome da primary key no bd
        /// </summary>
        public string GetName_ID()
        {
            return Name_ID;
        }

        /// <summary>
        /// Nome da primary key no bd
        /// </summary>
        public void SetName_ID(string name_id)
        {
            Name_ID = name_id;
        }

        private string Table { get; set; }

        public string GetTable()
        {
            return Table;
        }

        public void SetTable(string table)
        {
            Table = table;
        }

        private string[] Values { get; set; }

        public string[] GetValues()
        {
            return Values;
        }

        public void SetValues(string[] values)
        {
            Values = values;
        }

        private string[] Fields { get; set; }

        public void SetFields(string[] fields)
        {
            Fields = fields;
        }


        public string[] GetFields()
        {
            return Fields;
        }

        public void SetFilter(string filter)
        {
            Filter += filter;
        }

        public string GetFilter()
        {
            return Filter;
        }

        public void SetOrder(string order)
        {
            Order = order;
        }

        public string GetOrder()
        {
            return Order;
        }

        public void SetLimit(int page, int itemsPerPage)
        {
            Limit = string.Concat(page, ", ", itemsPerPage);
        }

        public string GetLimit()
        {
            return Limit;
        }

        private string Order { get; set; }

        private string Filter { get; set; }

        private string Limit { get; set; }

        public int ID { get; set; }

        #endregion
    }
}
