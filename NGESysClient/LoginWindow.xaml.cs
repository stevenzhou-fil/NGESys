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
using System.Windows.Shapes;
using NGESysClient.GeneralServiceReference;

namespace NGESysClient
{
	/// <summary>
	/// LoginWindow.xaml 的交互逻辑
	/// </summary>
	public partial class LoginWindow : Window
	{
		GeneralServiceClient client = new GeneralServiceClient();

		public LoginWindow()
		{
			InitializeComponent();
		}

		private void LoginSubmitButton_Click(object sender, RoutedEventArgs e)
		{
			string idIn = LoginIDTextBox.Text;
			string pwdIn = LoginPwdBox.Password;
			bool ifPass = client.Login(idIn, pwdIn);
			if (ifPass == true)
			{
				string getName = client.LoginAccountName(idIn);
				MessageBox.Show("欢迎回来，" + getName + "！", "登录成功", MessageBoxButton.OK, MessageBoxImage.Information);
				MainWindow mainWin = new MainWindow(getName, idIn);
				mainWin.Show();
				Login.Close();
			}
			else
				MessageBox.Show("登录名或密码错误，请重新输入。");
		}

		private void LoginCancelButton_Click(object sender, RoutedEventArgs e)
		{
			if (MessageBox.Show("确定要放弃登录并退出系统吗？", "退出", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
				Application.Current.Shutdown();
		}
	}
}
