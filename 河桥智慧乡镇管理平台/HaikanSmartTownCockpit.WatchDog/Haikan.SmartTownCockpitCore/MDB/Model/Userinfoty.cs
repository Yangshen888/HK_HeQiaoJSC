using System;
namespace big_data.Model
{
	/// <summary>
	/// ͳһ��Ա��Ϣ��
	/// </summary>
	[Serializable]
	public partial class Userinfoty
	{
		public Userinfoty()
		{}
		#region Model
		private Guid _userinfouuid;
		private int _id;
		private int? _isdeleted;
		private string _addtime;
		private string _addpeople;
		private string _realname;
		private string _useridcard;
		private string _wechat;
		private string _phone;
		private string _email;
		private string _sex;
		private string _address;
		private Guid _departmentuuid;
		private string _birth;
		private string _identitycard;
		private string _residence;
		private string _domicile;
		private string _nation;
		private string _education;
		private string _qianyistime;
		private string _qianyietime;
		private string _settled;
		private string _occupation;
		private string _dystaues;
		private string _politics;
		private string _position;
		private string _evaluate;
		private string _organizationuuid;
		private string _joinarmy;
		private string _armytime;
		private string _settledtime;
		private Guid _townuuid;
		private string _defense;
		private string _category;
		private string _partybranch;
		private string _joindate;
		private string _work;
		private int? _age;
		private string _household;
		private string _relation;
		private string _householdername;
		/// <summary>
		/// 
		/// </summary>
		public Guid UserInfoUUID
		{
			set{ _userinfouuid=value;}
			get{return _userinfouuid;}
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
		/// 
		/// </summary>
		public int? IsDeleted
		{
			set{ _isdeleted=value;}
			get{return _isdeleted;}
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
		/// ����
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserIdCard
		{
			set{ _useridcard=value;}
			get{return _useridcard;}
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
		/// �绰����
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
		/// ��ַ
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// ��ز���
		/// </summary>
		public Guid DepartmentUUID
		{
			set{ _departmentuuid=value;}
			get{return _departmentuuid;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Birth
		{
			set{ _birth=value;}
			get{return _birth;}
		}
		/// <summary>
		/// ���֤��
		/// </summary>
		public string IdentityCard
		{
			set{ _identitycard=value;}
			get{return _identitycard;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string Residence
		{
			set{ _residence=value;}
			get{return _residence;}
		}
		/// <summary>
		/// ��ַ
		/// </summary>
		public string Domicile
		{
			set{ _domicile=value;}
			get{return _domicile;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Nation
		{
			set{ _nation=value;}
			get{return _nation;}
		}
		/// <summary>
		/// ѧ��
		/// </summary>
		public string Education
		{
			set{ _education=value;}
			get{return _education;}
		}
		/// <summary>
		/// Ǩ��ʱ��
		/// </summary>
		public string QianYiSTime
		{
			set{ _qianyistime=value;}
			get{return _qianyistime;}
		}
		/// <summary>
		/// Ǩ��ʱ��
		/// </summary>
		public string QianYiETime
		{
			set{ _qianyietime=value;}
			get{return _qianyietime;}
		}
		/// <summary>
		/// �仧��
		/// </summary>
		public string Settled
		{
			set{ _settled=value;}
			get{return _settled;}
		}
		/// <summary>
		/// ְҵ
		/// </summary>
		public string Occupation
		{
			set{ _occupation=value;}
			get{return _occupation;}
		}
		/// <summary>
		/// �Ƿ�Ա
		/// </summary>
		public string DyStaues
		{
			set{ _dystaues=value;}
			get{return _dystaues;}
		}
		/// <summary>
		/// ������ò
		/// </summary>
		public string Politics
		{
			set{ _politics=value;}
			get{return _politics;}
		}
		/// <summary>
		/// ְλ
		/// </summary>
		public string position
		{
			set{ _position=value;}
			get{return _position;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string Evaluate
		{
			set{ _evaluate=value;}
			get{return _evaluate;}
		}
		/// <summary>
		/// ������֯UUID
		/// </summary>
		public string OrganizationUuid
		{
			set{ _organizationuuid=value;}
			get{return _organizationuuid;}
		}
		/// <summary>
		/// �ξ���Ը
		/// </summary>
		public string JoinArmy
		{
			set{ _joinarmy=value;}
			get{return _joinarmy;}
		}
		/// <summary>
		/// �ξ�����
		/// </summary>
		public string ArmyTime
		{
			set{ _armytime=value;}
			get{return _armytime;}
		}
		/// <summary>
		/// �仧ʱ��
		/// </summary>
		public string SettledTime
		{
			set{ _settledtime=value;}
			get{return _settledtime;}
		}
		/// <summary>
		/// ��������UUID
		/// </summary>
		public Guid TownUuid
		{
			set{ _townuuid=value;}
			get{return _townuuid;}
		}
		/// <summary>
		/// �Ƿ�ξ�
		/// </summary>
		public string Defense
		{
			set{ _defense=value;}
			get{return _defense;}
		}
		/// <summary>
		/// ��Ա���
		/// </summary>
		public string Category
		{
			set{ _category=value;}
			get{return _category;}
		}
		/// <summary>
		/// ���ڵ�֧��
		/// </summary>
		public string Partybranch
		{
			set{ _partybranch=value;}
			get{return _partybranch;}
		}
		/// <summary>
		/// ���뵳ʱ��
		/// </summary>
		public string JoinDate
		{
			set{ _joindate=value;}
			get{return _joindate;}
		}
		/// <summary>
		/// ������λ
		/// </summary>
		public string Work
		{
			set{ _work=value;}
			get{return _work;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public int? Age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Household
		{
			set{ _household=value;}
			get{return _household;}
		}
		/// <summary>
		/// �뻧���Ĺ�ϵ
		/// </summary>
		public string Relation
		{
			set{ _relation=value;}
			get{return _relation;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string HouseholderName
		{
			set{ _householdername=value;}
			get{return _householdername;}
		}
		#endregion Model

	}
}

