using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            font.ItemsSource = Fonts.SystemFontFamilies.Select(a => a.Source);
            Size.ItemsSource = new List<double>() { 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 28, 32 };
            object temp = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
            
            temp = rtbEditor.Selection.GetPropertyValue(FontFamilyProperty);
            font.SelectedItem = temp;
            temp = rtbEditor.Selection.GetPropertyValue(FontSizeProperty);
            Size.Text = temp.ToString();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            rtbEditor.Document.Blocks.Clear();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                rtbEditor.Document.Blocks.Clear();
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                TextRange range = new TextRange(rtbEditor.Document.ContentStart,
                rtbEditor.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
            }
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
           
            
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(rtbEditor.Document.ContentStart,
               rtbEditor.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
            }
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Font_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rtbEditor.Selection.ApplyPropertyValue(FontFamilyProperty, font.SelectedItem);
        }

        private void Size_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rtbEditor.Selection.ApplyPropertyValue(FontSizeProperty, Size.Text);

        }

        private void RtbEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            numofsymbols.Text = ((new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd)).Text.Length-2).ToString();
        }

  
    }
}
