using Hardcodet.Wpf.TaskbarNotification;
using RadialMenu.Controls;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TCC_Hidracom.Views;


namespace TCC_Hidracom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        #region Construtor

        public MainWindow()
        {
            InitializeComponent();

            IoC.Setup();
            log4net.Config.XmlConfigurator.Configure();
            Init();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Inicializa o menu
        /// </summary>
        public void Init()
        {
            InitMenu();
            MyRadialMenu.IsOpen = true;
        }

        /// <summary>
        /// Inicializa o menu
        /// </summary>
        public void InitMenu()
        {
            Menu = new List<RadialMenuItem>
            {
                new RadialMenuItem
                {
                    Content = new MenuItem("Cadastrar", "appbar_add")
                },
                new RadialMenuItem
                {
                    Content = new MenuItem("Visualizar", "appbar_page_minus")
                },
                new RadialMenuItem
                {
                    Content = new MenuItem("Gerar Relatório", "appbar_page_file_pdf")
                }
            };

            Menu[0].Click += async (sender, args) =>
            {
                MyRadialMenu.IsOpen = false;
                await Task.Delay(400);
                MyRadialMenu.Items = GetSubMenuCadastrar();
                MyRadialMenu.IsOpen = true;
            };

            Menu[1].Click += async (sender, args) =>
            {
                MyRadialMenu.IsOpen = false;
                await Task.Delay(400);
                MyRadialMenu.Items = GetSubMenuVisualizar();
                MyRadialMenu.IsOpen = true;
            };

            Menu[2].Click += async (sender, args) =>
            {
                MyRadialMenu.IsOpen = false;
                await Task.Delay(400);
                MyRadialMenu.Items = GetSubMenuGerarRelatorio();
                MyRadialMenu.IsOpen = true;
            };

            MyRadialMenu.Items = Menu;
        }

        /// <summary>
        /// Retorna o menu de cadastrar
        /// </summary>
        /// <returns></returns>
        public List<RadialMenuItem> GetSubMenuCadastrar()
        {
            var submenu = new List<RadialMenuItem>
            {
                new RadialMenuItem
                {
                    Content = new MenuItem("Tipo \n de Serviço", "appbar_app_plus"),
                    ArrowBackground = Brushes.Transparent
                },
                new RadialMenuItem
                {
                    Content = new MenuItem ("Cliente", "appbar_user_add"),
                    ArrowBackground = Brushes.Transparent
                },
                new RadialMenuItem
                {
                    Content = new MenuItem("Ordem \n de Serviço", "appbar_customerservice"),
                    ArrowBackground = Brushes.Transparent
                },
                new RadialMenuItem
                {
                    Content = new MenuItem("Funcionário", "appbar_people_checkbox"),
                    ArrowBackground = Brushes.Transparent
                },
                 new RadialMenuItem
                {
                    Content = new MenuItem("Produto","appbar_thumb_up_add"),
                    ArrowBackground = Brushes.Transparent
                },
                new RadialMenuItem()
                {
                    Content = new TextBlock { Text = "Voltar" }
                }
            };

            submenu[0].Click += async (sender, args) =>
            {
                this.Visibility = Visibility.Hidden;
                await Task.Delay(400);
                new Services().Show();
            };
            submenu[1].Click += async (sender, args) =>
            {
                this.Visibility = Visibility.Hidden;
                await Task.Delay(400);
                new CadCliente(0).Show();
            };
            submenu[2].Click += async (sender, args) =>
            {
                this.Visibility = Visibility.Hidden;
                await Task.Delay(400);
                new CadOS().Show();
            };
           
            submenu[3].Click += async (sender, args) =>
            {
                this.Visibility = Visibility.Hidden;
                await Task.Delay(400);
                new CadCliente(1).Show();
            };
            submenu[4].Click += async (sender, args) =>
            {
                this.Visibility = Visibility.Hidden;
                await Task.Delay(400);
                new Produto().Show();
            };

            submenu[5].Click += async (sender, args) =>
            {
                MyRadialMenu.IsOpen = false;
                await Task.Delay(400);
                MyRadialMenu.Items = Menu;
                MyRadialMenu.IsOpen = true;
            };
            return submenu;
        }

        /// <summary>
        /// Retorna o menu de visualizar
        /// </summary>
        /// <returns></returns>
        public List<RadialMenuItem> GetSubMenuVisualizar()
        {
            var submenu = new List<RadialMenuItem>
            {
                new RadialMenuItem
                {
                    Content = new MenuItem("Historico O.S","appbar_table_select"),
                    ArrowBackground = Brushes.Transparent
                },
             
                new RadialMenuItem                          
                {
                    Content = new MenuItem("Pesquisar Clientes","appbar_people_checkbox"),
                    ArrowBackground = Brushes.Transparent
                },
                new RadialMenuItem
                {
                    Content = new MenuItem ("Pesquisar \n Funcionários", "appbar_page_search"),
                    ArrowBackground = Brushes.Transparent
                },
                new RadialMenuItem
                {
                    Content = new TextBlock { Text = "Voltar" }
                }
            };

            submenu[0].Click += async (sender, args) =>
            {
                this.Visibility = Visibility.Hidden;
                await Task.Delay(400);
                new Historico_Servico().Show();
            };

            submenu[1].Click += async (sender, args) =>
            {
                this.Visibility = Visibility.Hidden;
                await Task.Delay(400);
                new PsqCliente().Show();
            };

            submenu[2].Click += async (sender, args) =>
            {
                this.Visibility = Visibility.Hidden;
                await Task.Delay(400);
                new PsqFuncionario().Show();
               
            };
            submenu[3].Click += async (sender, args) =>
            {
                MyRadialMenu.IsOpen = false;
                await Task.Delay(400);
                MyRadialMenu.Items = Menu;
                MyRadialMenu.IsOpen = true;
            };


            return submenu;
        }

        /// <summary>
        /// Retorna o menu de gerar relatorio
        /// </summary>
        /// <returns></returns>
        public List<RadialMenuItem> GetSubMenuGerarRelatorio()
        {
            var submenu = new List<RadialMenuItem>
            {
                new RadialMenuItem
                {
                    Content = new MenuItem("Histórico \n de Serviço", "appbar_list_check"),
                    ArrowBackground = Brushes.Transparent
                },
                new RadialMenuItem
                {
                    Content = new MenuItem("Saída do Funcionário", "appbar_arrow_down_up"),
                    ArrowBackground = Brushes.Transparent
                },
                   new RadialMenuItem
                {
                    Content = new MenuItem("Serviço \n por cliente", "appbar_arrow_down_up"),
                    ArrowBackground = Brushes.Transparent
                },
                new RadialMenuItem
                {
                    Content = new TextBlock { Text = "Voltar" }
                }
            };
            submenu[0].Click += async (sender, args) =>
            {
                Visibility = Visibility.Hidden;
                await Task.Delay(400);
                new ReportHistorico(new HistoricoServicos().LoadHistoricos()).Show();
            };
            submenu[1].Click += async (sender, args) =>
            {
                MyRadialMenu.IsOpen = false;
                await Task.Delay(400);             
                new SaidaFuncionario().Show();
            };
           
            submenu[3].Click += async (sender, args) =>
            {
                MyRadialMenu.IsOpen = false;
                await Task.Delay(400);
                MyRadialMenu.Items = Menu;
                MyRadialMenu.IsOpen = true;
            };
            submenu[2].Click += async (sender, args) =>
            {
                MyRadialMenu.IsOpen = false;
                await Task.Delay(400);
                new relatorioCliente().Show();              
            };

            return submenu;
        }

        /// <summary>
        /// Fecha o menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadialMenuCentralItem_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
           
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Menu do programa
        /// </summary>
        public List<RadialMenuItem> Menu { get; set; }

        /// <summary>
        /// Diz se vai fechar agora
        /// </summary>
        public bool CloseNow { get; set; } = false;
        

        #endregion

        #region Events

        /// <summary>
        /// Evento de quando a janela está sendo fechada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);

        }

        #endregion
    }
}
