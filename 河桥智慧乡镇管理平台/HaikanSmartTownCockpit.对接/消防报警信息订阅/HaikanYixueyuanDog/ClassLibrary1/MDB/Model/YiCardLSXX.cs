using System;
namespace ClassLibrary1.Model
{
	/// <summary>
	/// һ��ͨ��ˮ��Ϣ��
	/// </summary>
	[Serializable]
	public partial class YiCardLSXX
	{
		public YiCardLSXX()
		{}
		#region Model
		private int _id;
		private Guid _yicarduuid;
		private string _yicardname;
		private string _possessor;
		private string _consumtype;
		private string _expensecal;
		private string _balance;
		private int? _isdeleted;
		private string _addtime;
		private string _addpeople;
		private string _consumtime;
		private string _address;
		private string _sitename;
		private string _depname;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid YicardUuid
		{
			set{ _yicarduuid=value;}
			get{return _yicarduuid;}
		}
		/// <summary>
		/// һ��ͨ����
		/// </summary>
		public string YicardName
		{
			set{ _yicardname=value;}
			get{return _yicardname;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string Possessor
		{
			set{ _possessor=value;}
			get{return _possessor;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string ConsumType
		{
			set{ _consumtype=value;}
			get{return _consumtype;}
		}
		/// <summary>
		/// ������¼
		/// </summary>
		public string ExpenseCal
		{
			set{ _expensecal=value;}
			get{return _expensecal;}
		}
		/// <summary>
		/// ���
		/// </summary>
		public string Balance
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsDeleted
		{
			set{ _isdeleted=value;}
			get{return _isdeleted;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddPeople
		{
			set{ _addpeople=value;}
			get{return _addpeople;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public string ConsumTime
		{
			set{ _consumtime=value;}
			get{return _consumtime;}
		}
		/// <summary>
		/// ������ַ
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// ��Ӫ�̻�
		/// </summary>
		public string SiteName
		{
			set{ _sitename=value;}
			get{return _sitename;}
		}
		/// <summary>
		/// ������λ��༶
		/// </summary>
		public string DepName
		{
			set{ _depname=value;}
			get{return _depname;}
		}
		#endregion Model

	}
}

