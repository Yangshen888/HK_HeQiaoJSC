using System;
namespace ClassLibrary1.Model
{
	/// <summary>
	/// ϵͳ�û�
	/// </summary>
	[Serializable]
	public partial class SystemUser
	{
		public SystemUser()
		{}
		#region Model
		private Guid _systemuseruuid;
		private string _loginname;
		private string _realname;
		private string _useridcard;
		private string _password;
		private int? _usertype;
		private Guid _schooluuid;
		private string _addtime;
		private string _addpeople;
		private int? _isdeleted;
		private string _managedepartment;
		private int _id;
		private string _zaigang;
		private string _phone;
		private string _email;
		private string _sex;
		private string _intime;
		private string _types;
		private string _address;
		private string _systemroleuuid;
		private string _remarks;
		private string _staffnum;
		private string _wechat;
		private string _topic;
		private string _content;
		private string _train;
		private string _main;
		private string _job;
		private int? _healthcertificate;
		private int? _isstaff=0;
		private int? _iscreedu=0;
		private string _personneltype;
		private string _reviewstatus;
		private string _cardnumber;
		private string _isblacklist;
		/// <summary>
		/// 
		/// </summary>
		public Guid SystemUserUUID
		{
			set{ _systemuseruuid=value;}
			get{return _systemuseruuid;}
		}
		/// <summary>
		/// ��¼��
		/// </summary>
		public string LoginName
		{
			set{ _loginname=value;}
			get{return _loginname;}
		}
		/// <summary>
		/// ��ʵ����
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// ���֤
		/// </summary>
		public string UserIdCard
		{
			set{ _useridcard=value;}
			get{return _useridcard;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string PassWord
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 1 ���� 2����
		/// </summary>
		public int? UserType
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// ѧУUUID
		/// </summary>
		public Guid SchoolUUID
		{
			set{ _schooluuid=value;}
			get{return _schooluuid;}
		}
		/// <summary>
		/// ע��ʱ��
		/// </summary>
		public string AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// �����
		/// </summary>
		public string AddPeople
		{
			set{ _addpeople=value;}
			get{return _addpeople;}
		}
		/// <summary>
		/// 0���� 1ɾ��
		/// </summary>
		public int? IsDeleted
		{
			set{ _isdeleted=value;}
			get{return _isdeleted;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ManageDepartment
		{
			set{ _managedepartment=value;}
			get{return _managedepartment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ״̬
		/// </summary>
		public string ZaiGang
		{
			set{ _zaigang=value;}
			get{return _zaigang;}
		}
		/// <summary>
		/// �绰
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// �Ա�
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// ��ְʱ��
		/// </summary>
		public string InTime
		{
			set{ _intime=value;}
			get{return _intime;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Types
		{
			set{ _types=value;}
			get{return _types;}
		}
		/// <summary>
		/// ��ַ
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// ��ɫid,�ö��ŷָ�
		/// </summary>
		public string SystemRoleUUid
		{
			set{ _systemroleuuid=value;}
			get{return _systemroleuuid;}
		}
		/// <summary>
		/// ��ע
		/// </summary>
		public string Remarks
		{
			set{ _remarks=value;}
			get{return _remarks;}
		}
		/// <summary>
		/// ְ����/ѧ��
		/// </summary>
		public string StaffNum
		{
			set{ _staffnum=value;}
			get{return _staffnum;}
		}
		/// <summary>
		/// ΢��
		/// </summary>
		public string Wechat
		{
			set{ _wechat=value;}
			get{return _wechat;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string Topic
		{
			set{ _topic=value;}
			get{return _topic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Train
		{
			set{ _train=value;}
			get{return _train;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Main
		{
			set{ _main=value;}
			get{return _main;}
		}
		/// <summary>
		/// ְ��
		/// </summary>
		public string Job
		{
			set{ _job=value;}
			get{return _job;}
		}
		/// <summary>
		/// �Ƿ��н���֤    0��   1��
		/// </summary>
		public int? HealthCertificate
		{
			set{ _healthcertificate=value;}
			get{return _healthcertificate;}
		}
		/// <summary>
		/// �Ƿ�Ϊʳ�ù�����Ա 0��   1��
		/// </summary>
		public int? IsStaff
		{
			set{ _isstaff=value;}
			get{return _isstaff;}
		}
		/// <summary>
		/// �Ƿ��ɹ����𴴽�  0��   1��
		/// </summary>
		public int? IsCreEdu
		{
			set{ _iscreedu=value;}
			get{return _iscreedu;}
		}
		/// <summary>
		/// ��Ա����(1:Ժ�ڽ�ʦ��2:Ժ���ʦ��3:Ժ��ѧ����4:Ժ��ѧ����5:У����Ա,6:ϵͳ����Ա)
		/// </summary>
		public string PersonnelType
		{
			set{ _personneltype=value;}
			get{return _personneltype;}
		}
		/// <summary>
		/// ���״̬(ֻ��У����Ա��Ҫ���)
		/// </summary>
		public string ReviewStatus
		{
			set{ _reviewstatus=value;}
			get{return _reviewstatus;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string CardNumber
		{
			set{ _cardnumber=value;}
			get{return _cardnumber;}
		}
		/// <summary>
		/// �Ƿ���ں�����(0:��1:��)
		/// </summary>
		public string IsBlacklist
		{
			set{ _isblacklist=value;}
			get{return _isblacklist;}
		}
		#endregion Model

	}
}

