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
using System.Globalization;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack<string> PathOfText;
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
            PathOfText = new Stack<string>();
            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }
        }
        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }
        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }

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

            LastDoc.Items.Add((object)dlg.FileName);

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

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("Dictionary2.xaml",UriKind.Relative); 
            ResourceDictionary nightmod = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(nightmod);

        }

        private void OverColor_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("Dictionary3.xaml", UriKind.Relative);
            ResourceDictionary nightmod = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(nightmod);
        }

        private void LastDoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string path = ((ComboBox)sender).SelectedItem.ToString();
                rtbEditor.Document.Blocks.Clear();
                FileStream fileStream = new FileStream(path, FileMode.Open);
                TextRange range = new TextRange(rtbEditor.Document.ContentStart,
                rtbEditor.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
        }

        private void Endglish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Russian_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
