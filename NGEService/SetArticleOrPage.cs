using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NGEServiceWithLinq;
using System.Data.Linq;

namespace NGEService
{
	public abstract class SetArticleOrPage
	{
		//新建报导时
		public static void SetArticleInDB(string stfID, string path)
		{
			string id_temp = "";
			NGEsysDB dbConn = new NGEsysDB("Server = STEVEN-PC; Database = NGEsysDB; Integrated Security = SSPI");
			NGEServiceWithLinq.Article atcl = new NGEServiceWithLinq.Article();
			NGEServiceWithLinq.Staff author = new NGEServiceWithLinq.Staff();
			string[] dptName = new string[] { "文娱体育部", "政治与时事部", "社会热点部", "教育与科技部", "广告部" };
			DateTime date = DateTime.Today;
			id_temp += string.Format("{0:yyyyMMdd}", date);
			string getDptName = "";
			string getPstn = "";

			var dpts =
				from stf in dbConn.Staff
				where stf.StaffID == stfID
				select stf.StfDpt;

			foreach (var dpt in dpts)
				getDptName += dpt;

			int dptNo = 0;
			for(int i = 0; i < dptName.Length - 1; i++)
			{
				if (dptName[i] == getDptName)
					dptNo = i + 1;
			}

			if (dptNo < 10)
			{
				id_temp += "0";
				id_temp += dptNo.ToString();
			}
			else if (dptNo < 100)
				id_temp += dptNo.ToString();

			var pstns =
				from stf in dbConn.Staff
				where stf.StaffID == stfID
				select stf.StfPstn;

			foreach (var pstn in pstns)
				getPstn += pstn;


			atcl.APubDate = date;
			atcl.Author = stfID;
			atcl.Department = getDptName;
			atcl.AStatus = 1;
			atcl.APath = path;

			string lastExistId = null;

			var existArtciles =
				from ea in dbConn.Article
				where ea.APubDate == date && ea.Department == getDptName
				select ea.ArticleID;

			foreach (var existAtcl in existArtciles)
				lastExistId = existAtcl;

			if (lastExistId != null)
				id_temp = (Convert.ToInt64(lastExistId) + 1).ToString();
			else
				id_temp += "01";

			atcl.ArticleID = id_temp;

			dbConn.Article.InsertOnSubmit(atcl);
			dbConn.SubmitChanges();

			dbConn.Dispose();
		}

		//TODO:校对

		//TODO:提交版面

		//TODO:审核版面
	}
}