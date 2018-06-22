using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LexerService.LexerServiceClient lexerServiceClient;
        private SyntaxColoringService.SyntaxColoringServiceClient syntaxColoringServiceClient;

        public MainWindow()
        {
            InitializeComponent();

            lexerServiceClient = new LexerService.LexerServiceClient();
            syntaxColoringServiceClient = new SyntaxColoringService.SyntaxColoringServiceClient();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "C source files (*.c;*.h)|*.c;*.h|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                var filePath = openFileDialog.FileName;
                OpenFile(filePath);
            }
        }

        private void OpenFile( string filePath )
        {
            var code = File.ReadAllText(filePath);

            var tokens = lexerServiceClient.GetTokenList(code);

            var list = new List<KeyValuePair<string, SyntaxColoringService.ETokenType>>();
            foreach (var t in tokens)
            {
                int type = (int)t.Value;
                list.Add(new KeyValuePair<string, SyntaxColoringService.ETokenType>(t.Key, (SyntaxColoringService.ETokenType)type));
            }
            var tokensArray = list.ToArray();

            string coloredHTML = syntaxColoringServiceClient.GetTokensColorData(tokensArray);

            Viewer.NavigateToString(coloredHTML);
        }
    }

}
