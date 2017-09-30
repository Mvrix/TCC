using System;
using System.Windows.Input;

namespace TCC_Hidracom
{
    public class ApplicationViewModel : BaseViewModel
    {
        #region Public Properties



        #endregion

        #region Public Methods

        /// <summary>
        /// Pega os parametros previamente setados
        /// </summary>
        /// <returns></returns>
        public object[] GetCurrentParameters()
        {
            return CurrentParameter;
        }

        /// <summary>
        /// Seta novos parametros
        /// </summary>
        /// <param name="value">Os parametros</param>
        public void SetCurrentParameters(object[] value)
        {
            CurrentParameter = value;
        }

        /// <summary>
        /// Limpa os parametros atuais
        /// </summary>
        public void CleanCurrentParameters()
        {
            CurrentParameter = null;
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Parametros que podem ser usados para alguma finalidade
        /// </summary>
        private object[] CurrentParameter { get; set; }

        #endregion
    }
}
