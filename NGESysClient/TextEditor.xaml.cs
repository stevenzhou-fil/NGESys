using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NGESysClient.FileServiceReference;

namespace NGESysClient
{
    /// <summary>
    /// TextEditor.xaml 的交互逻辑
    /// </summary>
    public partial class TextEditor : Page
    {
		FileServiceClient fclient = new FileServiceClient();
		string idForQuery;

        public TextEditor(string pstn, string idIn)
        {
            InitializeComponent();
			idForQuery = idIn;
		}

		private void TextEditorPage_Loaded(object sender, RoutedEventArgs e)
		{
			//设置编辑器的可选字体
			foreach (FontFamily f in Fonts.SystemFontFamilies)
			{
				LanguageSpecificStringDictionary fontDic = f.FamilyNames;
				if (fontDic.ContainsKey(XmlLanguage.GetLanguage("zh-cn")))
				{
					string fontName = "";
					if (fontDic.TryGetValue(XmlLanguage.GetLanguage("zh-cn"), out fontName))
					{
						editorFontToolBarCb.Items.Add(fontName);
					}
				}
			}

			//设置编辑器可选的字号范围
			for (int i = 8; i <= 100; i += 2)
			{
				editorSizeToolBarCb.Items.Add(i);
			}

			//设置编辑器初始的字号与字体
			editorFontToolBarCb.SelectedItem = "宋体";
			editorSizeToolBarCb.SelectedItem = 16;

			//重置状态栏
			RichTextBoxStatus.Content = "";
		}

		private void MenuItem_Click_Copy(object sender, RoutedEventArgs e)
		{
			editorRichTextBox.Copy();
			RichTextBoxStatus.Content = "复制";
		}

		private void MenuItem_Click_Cut(object sender, RoutedEventArgs e)
		{
			editorRichTextBox.Cut();
			RichTextBoxStatus.Content = "剪切";
		}

		private void MenuItem_Click_Paste(object sender, RoutedEventArgs e)
		{
			editorRichTextBox.Paste();
			RichTextBoxStatus.Content = "粘贴";
		}

		private void editorFontToolBarCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			editorRichTextBox.Selection.ApplyPropertyValue(FontFamilyProperty, new FontFamily(editorFontToolBarCb.SelectedItem.ToString()));
			RichTextBoxStatus.Content = "设置字体：" + editorFontToolBarCb.SelectedItem.ToString();
		}

		private void editorSizeToolBarCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			editorRichTextBox.Selection.ApplyPropertyValue(FontSizeProperty, Convert.ToDouble(editorSizeToolBarCb.SelectedItem));
			RichTextBoxStatus.Content = "设置字号：" + editorSizeToolBarCb.SelectedItem.ToString();
		}

		private void editorSaveAsButton_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.InitialDirectory = @"d:\";
			sfd.Filter = "文本文档|*.txt";

			if (sfd.ShowDialog() == true)
			{
				TextRange tr = new TextRange(editorRichTextBox.Document.ContentStart, editorRichTextBox.Document.ContentEnd);
				File.AppendAllText(sfd.FileName, tr.Text);
				MessageBox.Show("保存成功");
			}
		}

		private void addArticleSubmitButton_Click(object sender, RoutedEventArgs e)
		{
			bool ifUploaded;
			TextRange tr = new TextRange(editorRichTextBox.Document.ContentStart, editorRichTextBox.Document.ContentEnd);
			ifUploaded = fclient.UploadTxt(titleTextBox.Text, tr.Text, idForQuery);
			if (ifUploaded)
				MessageBox.Show("上传成功！请等待审核", "", MessageBoxButton.OK, MessageBoxImage.Information);
			else
				MessageBox.Show("上传失败，请重试", "", MessageBoxButton.OK, MessageBoxImage.Error);
		}
	}
}
