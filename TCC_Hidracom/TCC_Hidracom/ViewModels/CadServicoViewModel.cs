using MaterialDesignThemes.Wpf;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TCC_Hidracom
{
    public class CadServicoViewModel : BaseViewModel
    {
        #region Construtor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public CadServicoViewModel()
        {
            CadastrarCommand = new RelayCommand(CadastraServico);
            Obs_Servico = new Observacao_Servico();
        }

        #endregion

        #region Public Properties

        public bool IsOpen { get; set; }

        public Observacao_Servico Obs_Servico { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Comando de voltar para o menu
        /// </summary>
        public ICommand BackCommand { get; set; }

        /// <summary>
        /// Comando que cadastra o serviço
        /// </summary>
        public ICommand CadastrarCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Cadastra a servico no banco de dados
        /// </summary>
        public async void CadastraServico()
        {
            await RunSimpleDBCommandAsync(() => CadastraIsRunning, async () =>
            {
                await Task.Delay(1);
                Obs_Servico.SetValues();
                Obs_Servico.Save();

                Obs_Servico = new Observacao_Servico();

                DialogHost.Show(new Cadastrado("Cadastrado!"), "CadServicoDialog");
                await Task.Delay(1000);
                IsOpen = false;
            });
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Flag do método de cadastrar
        /// </summary>
        private bool CadastraIsRunning { get; set; }

        #endregion
    }
}
