using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NGEService;
using System.Data.Linq;

namespace NGEService
{
	// 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“FileService”。
	// 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 FileService.svc 或 FileService.svc.cs，然后开始调试。
	public class FileService : IFileService
	{
		string path = @"e:\files\";//为本系统的服务端设置一个默认的根路径
		public bool UploadTxt(string title, string content, string idIn)
		{
			bool ifUploaded = false;
			DateTime date = DateTime.Now;
			path += date.ToLongDateString();
			path += @"\txt\";

			try
			{
				if (!Directory.Exists(path))//若不存在路径则创建
					Directory.CreateDirectory(path);
				path += string.Format("{0:HHmm}", date);//不能使用标准的时间表示形式（HH:mm）：文件名不能存在冒号
				path += (title + ".txt");
				File.AppendAllText(path, content);
				if (File.Exists(path))
				{
					ifUploaded = true;
				}
				else
					ifUploaded = false;

				return ifUploaded;
			}
			catch
			{
				return false;
			}
			finally//在数据库中更改文件的状态
			{
				if(ifUploaded)
					SetArticleOrPage.SetArticleInDB(idIn, path);
			}
		}
	}
}
