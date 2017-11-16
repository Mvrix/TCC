using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Hidracom
{
    public class Selects
    {
        public const string SELECT_HISTORICO_BY_PESSOA_ID = "SELECT ths.id_servicos, tt.nome as nome_tecnico, tc.nome as nome_cliente, tos.nome_servico as nome_servico, ths.data_marcada, ths.observacao FROM tcc_servicos ths, tcc_pessoas tc, dbo.tcc_observacao_servicos tos, tcc_pessoas tt WHERE ths.pessoas_id = tc.id_pessoa AND ths.observacao_servico_id = tos.id_observacao_servicos AND ths.tecnico_id = tt.id_pessoa AND ths.pessoas_id = {0}";

		public const string SELECT_HISTORICO_BY_TECNICO_ID = "SELECT ths.id_servicos, tt.nome as nome_tecnico, tc.nome as nome_cliente, tos.nome_servico as nome_servico, ths.data_marcada, ths.observacao FROM tcc_servicos ths, tcc_pessoas tc, dbo.tcc_observacao_servicos tos, tcc_pessoas tt WHERE ths.pessoas_id = tc.id_pessoa AND ths.observacao_servico_id = tos.id_observacao_servicos AND ths.tecnico_id = tt.id_pessoa AND ths.tecnico_id = {0}";

        public const string SELECT_HISTORICO_BY_SERVICO_ID = "SELECT ths.id_servicos, tt.nome as nome_tecnico, tc.nome as nome_cliente, tos.nome_servico as nome_servico, ths.data_marcada, ths.observacao FROM tcc_servicos ths, tcc_pessoas tc, dbo.tcc_observacao_servicos tos, tcc_pessoas tt WHERE ths.pessoas_id = tc.id_pessoa AND ths.observacao_servico_id = tos.id_observacao_servicos AND ths.tecnico_id = tt.id_pessoa AND ths.observacao_servico_id = {0}";

        /// <summary>
        /// {0} = Página
        /// {1} = Quantidade por página
        /// {2} = Tipo da pessoa
        /// </summary>
        public const string SELECT_TCC_PESSOAS_PAGINACAO = ";WITH Results_CTE AS ( SELECT *, ROW_NUMBER() OVER (ORDER BY id_pessoa) AS RowNum FROM tcc_pessoas WHERE tipo = {2}) SELECT * FROM Results_CTE WHERE RowNum >= {0} * {1} AND RowNum < ({0} * {1}) + {1};";

        public const string SELECT_TCC_SERVICOS_PAGINACAO = ";WITH Results_CTE AS ( SELECT *, ROW_NUMBER() OVER (ORDER BY id_servicos) AS RowNum FROM tcc_historico_servicos) SELECT * FROM Results_CTE WHERE RowNum >= {0} * {1} AND RowNum < ({0} * {1}) + {1};";
    }
}
