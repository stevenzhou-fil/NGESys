using System;
using System.Collections.Generic;
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
using NGESysClient.GeneralServiceReference;
using System.Windows.Markup;
using Microsoft.Win32;
using System.IO;

namespace NGESysClient
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		GeneralServiceClient client = new GeneralServiceClient();
		string pstn;
		string StfIDForQuery;
		public MainWindow(string stfName, string stfID)
		{
			InitializeComponent();
			GreetingLabel.Content += stfName;
			StfIDForQuery = stfID;
			pstn = client.GetStaffPosition(stfID);

			//通过switch-case设定可做的工作
			switch(pstn)
			{
				case "记者":
					WorkCbi_Add.Visibility = Visibility.Visible; break;
				case "校对":
					WorkCbi_ProofRead.Visibility = Visibility.Visible; break;
				case "编辑":
					WorkCbi_Add.Visibility = Visibility.Visible;
					WorkCbi_Edit.Visibility = Visibility.Visible;break;
				case "部门主任":
					WorkCbi_Add.Visibility = Visibility.Visible;					
					WorkCbi_Edit.Visibility = Visibility.Visible;
					WorkCbi_Check.Visibility = Visibility.Visible; break;
			}
		}

		private void mainWin_Loaded(object sender, RoutedEventArgs e)
		{

		}

		private void WorkSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int workSelected = WorkSelectComboBox.SelectedIndex;
			switch(workSelected)
			{
				case 0:
					MessageBox.Show("文档编辑界面已准备好");
					TextEditor te = new TextEditor(pstn, StfIDForQuery);
					workContainer.Navigate(te);
					break;
			}
		}
	}
}
