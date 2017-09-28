using MahApps.Metro;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;

namespace MetroDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        ObservableCollection<FileInformation> Files = new ObservableCollection<FileInformation>();
        public MainWindow()
        {
            InitializeComponent();
            Resources = System.Windows.Application.Current.Resources;
            DataContext = Files;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((sender as System.Windows.Controls.Button).Content.ToString() == "Dark")
            {
                Tuple<AppTheme, Accent> theme = ThemeManager.DetectAppStyle(this);
                ThemeManager.ChangeAppStyle(this,theme.Item2,ThemeManager.GetAppTheme("BaseDark"));
                (sender as System.Windows.Controls.Button).Content = "Light";
            }
            else
            {
                var theme = ThemeManager.DetectAppStyle(this);
                ThemeManager.ChangeAppStyle(this,theme.Item2,ThemeManager.GetAppTheme("BaseLight"));
                (sender as System.Windows.Controls.Button).Content = "Dark";
            }

        }
        private void Button_read_Click(object sender, RoutedEventArgs e)
        {
            Files.Clear();//列表清零
            string path = null;//文件夹目录
            FolderBrowserDialog folder = new FolderBrowserDialog();//新建文件夹窗口
            if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)//"+-*/"
            {
                path = folder.SelectedPath;

                foreach (string filename in Directory.GetFiles(path))
                {
                    FileInfo file = new FileInfo(filename);
                    Files.Add(new FileInformation(file.Name, FileOperator.filesize(file.Length)));
                }
            }//1个文件 1024个字节 大小1kB
        }
    }
}
