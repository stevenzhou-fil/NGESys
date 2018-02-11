using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NGEService;
using System.Data.Linq;

namespace ConsoleApp_AddData
{
	class Program
	{
		static void Main(string[] args)
		{
			NGEsysDB db = new NGEsysDB("Server = STEVEN-PC; Database = NGEsysDB; Integrated Security = SSPI");
			
			string id_temp = "";
			string[] id_56 = new string[] { "01", "02", "03", "04", "05" };
			string[] dptName = new string[] { "文娱体育部", "政治与时事部", "社会热点部", "教育与科技部", "广告部" };
			string[] chiefName = new string[] { "张三", "李四", "王五", "赵六", "周七" };
			string[] degree = new string[] { "小学文化", "初中文化", "高中及中专", "专科", "学士", "硕士", "博士" };
			string[] school = new string[] { "清华大学", "北京大学", "中国传媒大学", "北京师范大学", "华东师范大学", "东北师范大学", "北京外国语大学", "大连理工大学", "东北财经大学" };
			string[] yearIn = new string[] { "05", "06", "07", "08", "09", "10", "11", "12", "13" };
			string[] chnNum = new string[] { "一", "二", "三" };
			//每一个部门添加一个部门主任
			//for (int i = 0; i < 5; i++)
			//{
			//	Staff stf = new Staff();
			//	id_temp += "04";				
			//	id_temp += "05";
			//	id_temp += id_56[i];
			//	id_temp += "00";
			//	stf.StaffID = id_temp;				
			//	stf.StfName = chiefName[i];
			//	stf.StfYearIn = 2005;
			//	stf.StfPstn = "部门主任";
			//	stf.StfDpt = dptName[i];
			//	stf.StfDgr = degree[5];
			//	Random rdm = new Random();
			//	int schNo = rdm.Next(0, 6);
			//	stf.StfGrdtdFrm = school[schNo];
			//	stf.Password = id_temp;
			//	db.Staff.InsertOnSubmit(stf);
			//	db.SubmitChanges();
			//	id_temp = "";
			//	Console.WriteLine("number {0} data inserted. ", i);
			//}

			
			//for(int i = 3; i < 5; i++)
			//{
			//	//为每个部门添加两个编辑
			//	for (int j = 0; j < 2; j++)
			//	{
			//		Staff stf = new Staff();
			//		id_temp += "03";
			//		Random rdm = new Random();
			//		int yearRdm = rdm.Next(0, 9);
			//		id_temp += yearIn[yearRdm];
			//		id_temp += id_56[i];
			//		id_temp += '0' + (j + 1).ToString();
			//		stf.StaffID = id_temp;
			//		stf.StfName = chiefName[i] + "编" + chnNum[j];
			//		stf.StfYearIn = int.Parse("20" + yearIn[yearRdm]);
			//		stf.StfPstn = "编辑";
			//		stf.StfDpt = dptName[i];
			//		int degreeRdm = rdm.Next(4, 6);
			//		stf.StfDgr = degree[degreeRdm];
			//		int schNo = rdm.Next(0, 9);
			//		stf.StfGrdtdFrm = school[schNo];
			//		stf.Password = id_temp;
			//		db.Staff.InsertOnSubmit(stf);
			//		db.SubmitChanges();
			//		id_temp = "";
			//		Console.WriteLine("Added editor {0}", j + 1);
			//	}

			//	//为每个部门添加两个校对
			//	for (int j = 0; j < 2; j++)
			//	{
			//		Staff stf = new Staff();
			//		id_temp += "02";
			//		Random rdm = new Random();
			//		int yearRdm = rdm.Next(0, 9);
			//		id_temp += yearIn[yearRdm];
			//		id_temp += id_56[i];
			//		id_temp += '0' + (j + 3).ToString();
			//		stf.StaffID = id_temp;
			//		stf.StfName = chiefName[i] + "校" + chnNum[j];
			//		stf.StfYearIn = int.Parse("20" + yearIn[yearRdm]);
			//		stf.StfPstn = "校对";
			//		stf.StfDpt = dptName[i];
			//		int degreeRdm = rdm.Next(4, 6);
			//		stf.StfDgr = degree[degreeRdm];
			//		int schNo = rdm.Next(0, 9);
			//		stf.StfGrdtdFrm = school[schNo];
			//		stf.Password = id_temp;
			//		db.Staff.InsertOnSubmit(stf);
			//		db.SubmitChanges();
			//		id_temp = "";
			//		Console.WriteLine("Added proof-reader {0}", j + 1);
			//	}

			//	//为每个部门添加三个记者
			//	for (int j = 0; j < 3; j++)
			//	{
			//		Staff stf = new Staff();
			//		id_temp += "01";
			//		Random rdm = new Random();
			//		int yearRdm = rdm.Next(0, 9);
			//		id_temp += yearIn[yearRdm];
			//		id_temp += id_56[i];
			//		id_temp += '0' + (j + 5).ToString();
			//		stf.StaffID = id_temp;
			//		stf.StfName = chiefName[i] + "记" + chnNum[j];
			//		stf.StfYearIn = int.Parse("20" + yearIn[yearRdm]);
			//		stf.StfPstn = "记者";
			//		stf.StfDpt = dptName[i];
			//		int degreeRdm = rdm.Next(4, 6);
			//		stf.StfDgr = degree[degreeRdm];
			//		int schNo = rdm.Next(0, 9);
			//		stf.StfGrdtdFrm = school[schNo];
			//		stf.Password = id_temp;
			//		db.Staff.InsertOnSubmit(stf);
			//		db.SubmitChanges();
			//		id_temp = "";
			//		Console.WriteLine("Added journalist {0}", j + 1);
			//	}

			//}
			Console.WriteLine("end");
			db.Dispose();
			Console.ReadKey();
		}
	}
}
