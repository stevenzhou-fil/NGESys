using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NGEServiceWithLinq;

namespace NGEService
{
	// 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“GeneralService”。
	// 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 GeneralService.svc 或 GeneralService.svc.cs，然后开始调试。
	public class GeneralService : IGeneralService
	{
		public bool Login(string idIn, string pwdIn)
		{
			bool ifPass = false;
			NGEsysDB dbConn = new NGEsysDB("Server = STEVEN-PC; Database = NGEsysDB; Integrated Security = SSPI");
			var pwdInDB =
				from stf in dbConn.Staff
				where stf.StaffID == idIn
				select stf.Password;

			foreach(var pwd in pwdInDB)
			{
				if (pwdIn == pwd)
					ifPass = true;
				else
					ifPass = false;
			}

			dbConn.Dispose();
			return ifPass;
		}

		public string LoginAccountName(string idIn)
		{
			string nameInDB = "";

			NGEsysDB dbConn = new NGEsysDB("Server = STEVEN-PC; Database = NGEsysDB; Integrated Security = SSPI");
			var getName =
				from stf in dbConn.Staff
				where stf.StaffID == idIn
				select stf.StfName;

			foreach (var name in getName)
				nameInDB += name;

			dbConn.Dispose();
			return nameInDB;
		}

		public string GetStaffPosition(string idIn)
		{
			string pstn = "";
			NGEsysDB dbConn = new NGEsysDB("Server = STEVEN-PC; Database = NGEsysDB; Integrated Security = SSPI");
			var getPosition =
				from stf in dbConn.Staff
				where stf.StaffID == idIn
				select stf.StfPstn;

			foreach (var position in getPosition)
				pstn += position;

			return pstn;
		}
	}
}
