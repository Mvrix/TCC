using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TCC_Hidracom
{
    public class CadClienteViewModel : BaseViewModel
    {

        #region Construtors

        public CadClienteViewModel(int tipo)
        {
            Pessoa = new Pessoas() { Tipo = tipo };
            Title = tipo == 0 ? "Cadastro de cliente" : "Cadastro de Funcionario";
            CadastrarCommand = new RelayCommand(CadastraPessoa);
        }

        #endregion

        #region Commands

        /// <summary>
        /// Comando de voltar para o menu
        /// </summary>
        public ICommand BackCommand { get; set; }

        /// <summary>
        /// Comando que cadastra a pessoa
        /// </summary>
        public ICommand CadastrarCommand { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// Contexto da pessoa
        /// </summary>
        public Pessoas Pessoa { get; set; }

        /// <summary>
        /// Titulo da página
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Diz se o dialog está aberto
        /// </summary>
        public bool IsOpen { get; set; } = false;


        /// <summary>
        /// Flag do método de cadastrar, diz se ele está executando ou não
        /// </summary>
        private bool CadastraIsRunning { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Cadastra a pessoa no banco de dados
        /// </summary>
        public async void CadastraPessoa()
        {
            await RunSimpleDBCommandAsync(() => CadastraIsRunning, async () =>
            {
                await Task.Delay(1);
                Pessoa.SetValues();
                Pessoa.Save();

                DialogHost.Show(new Cadastrado("Parabens"), "ContentDialog");
                await Task.Delay(1000);
                IsOpen = false;
            });
        }

        #endregion

    }
}
