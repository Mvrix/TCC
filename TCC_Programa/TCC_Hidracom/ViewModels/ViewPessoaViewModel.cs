using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TCC_Hidracom
{
    public class ViewPessoaViewModel : BaseViewModel
    {
        #region Construtor

        public ViewPessoaViewModel(int tipo)
        {
            Tipo = tipo;
            Page = 1;
            Data = new Pessoas().Load(tipo);
            ListPessoas = GetReorganizePessoas();

            SearchPessoaCommand = new RelayParametizedCommand(o => Search((string)o));
            PreviusPageCommand = new RelayCommand(PreviusPage);
            NextPageCommand = new RelayCommand(NextPage);
            FirstPageCommand = new RelayCommand(GoToFirstPage);
            LastPageCommand = new RelayCommand(GoToLastPage);
        }

        #endregion

        #region Propriedades da pesquisa

        /// <summary>
        /// Tipo da pessoa
        /// </summary>
        public int Tipo { get; set; }

        /// <summary>
        /// Lista com as pessoas que serão exibidas
        /// </summary>
        public List<Pessoas> ListPessoas { get; set; }

        #region Paginnation Properties

        /// <summary>
        /// A quantidade de itens por página.
        /// </summary>
        private int mItemsPerPage = 15;

        public int ItemsPerPage
        {
            get { return mItemsPerPage; }
            set
            {
                mItemsPerPage = value;
                ListPessoas = GetReorganizePessoas();
            }
        }

        /// <summary>
        /// Index usado para auxiliar a seleção de horário
        /// </summary>
        private int mItensPerPageIndex;

        public int ItemsPerPageIndex
        {
            get { return mItensPerPageIndex; }
            set
            {
                mItensPerPageIndex = value;
                if (value.Equals(0))
                    ItemsPerPage = 15;
                else if (value.Equals(1))
                    ItemsPerPage = 20;
                else if (value.Equals(2))
                    ItemsPerPage = 25;

                PageOfItems = (int)Math.Ceiling((double)mData.Count / mItemsPerPage);
                TotalCount = mData.Count;
            }
        }

        /// <summary>
        /// A quantidade total de páginas que a consulta retornou com base no <see cref="ItemsPerPage"/> que está setado.
        /// </summary>
        public int PageOfItems { get; set; }

        /// <summary>
        /// Quantidade total de itens
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// A página atual.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Serve como um buffer para guardar a lista de Pessoas
        /// </summary>
        private List<Pessoas> mData = new List<Pessoas>();

        private List<Pessoas> Data
        {
            get { return mData; }
            set
            {
                mData = value;
                PageOfItems = (int)Math.Ceiling((double)mData.Count / ItemsPerPage);
                TotalCount = mData.Count;
            }
        }

        #endregion

        #endregion

        #region Comandos

        /// <summary>
        /// Comando para pesquisar pessoa
        /// </summary>
        public ICommand SearchPessoaCommand { get; set; }

        /// <summary>
        /// Fecha e volta para o menu
        /// </summary>
        public ICommand BackCommand { get; set; }

        #region Pagination Commands

        /// <summary>
        /// Passa para a página anterior.
        /// </summary>
        public ICommand PreviusPageCommand { get; set; }

        /// <summary>
        /// Passa para a proxima página.
        /// </summary>
        public ICommand NextPageCommand { get; set; }

        /// <summary>
        /// Passa para a primeira página.
        /// </summary>
        public ICommand FirstPageCommand { get; set; }

        /// <summary>
        /// Passa para a ultima página.
        /// </summary>
        public ICommand LastPageCommand { get; set; }

        #endregion

        #endregion

        #region Metodos

        public void Search(string parameter)
        {
            Page = 1;
            if (string.IsNullOrEmpty(parameter.Trim()))
            {
                Data = new Pessoas().Load(Tipo);
            }
            else
            {
                Data = new Pessoas().Search(Tipo, parameter);
            }

            ListPessoas = GetReorganizePessoas();
        }

        #region Paginnation Methods

        /// <summary>
        /// Passa para a página anterior.
        /// </summary>
        private void PreviusPage()
        {
            if (Page > 1 && !Data.Count.Equals(0))
            {
                Page--;
                ListPessoas = GetReorganizePessoas();
            }
        }

        /// <summary>
        /// Passa para a proxima página.
        /// </summary>
        private void NextPage()
        {
            if (Page < PageOfItems && !Data.Count.Equals(0))
            {
                Page++;
                ListPessoas = GetReorganizePessoas();
            }
        }

        /// <summary>
        /// Passa para a primeira página.
        /// </summary>
        private void GoToFirstPage()
        {
            if (!Data.Count.Equals(0))
            {
                Page = 1;
                ListPessoas = GetReorganizePessoas();
            }
        }

        /// <summary>
        /// Passa para a ultima página.
        /// </summary>
        private void GoToLastPage()
        {
            if (!Data.Count.Equals(0))
            {
                Page = PageOfItems;
                ListPessoas = GetReorganizePessoas();
            }
        }

        /// <summary>
        /// Organiza as consultas conforme a pagina e a quantidade de pedidos por página.
        /// </summary>
        /// <returns>Uma lista de pedidos organizados por página.</returns>
        private List<Pessoas> GetReorganizePessoas()
        {
            return (from c in Data select c).Skip((Page * ItemsPerPage) - ItemsPerPage).Take(ItemsPerPage).ToList();
        }

        #endregion

        #endregion
    }
}