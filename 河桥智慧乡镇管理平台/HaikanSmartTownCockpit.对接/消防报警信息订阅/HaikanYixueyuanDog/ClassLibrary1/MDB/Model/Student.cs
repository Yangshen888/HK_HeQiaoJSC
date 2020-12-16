using System;
namespace ClassLibrary1.Model
{
	/// <summary>
	/// ѧ����Ϣ
	/// </summary>
	[Serializable]
	public partial class Student
	{
		public Student()
		{}
		#region Model
		private int _id;
		private DateTime? _createtime= DateTime.Now;
		private Guid _studentuuid;
		private string _name;
		private string _sex;
		private string _stunum;
		private Guid _collegeuuid;
		private Guid _majoruuid;
		private Guid _stuclassuuid;
		private string _yicard;
		private Guid _dormitoryuuid;
		private string _picture;
		private Guid _dormitorynumuuid;
		private string _phone;
		private string _idcard;
		private string _email;
		private string _nation;
		private string _political;
		private string _religion;
		private int? _isdeleted;
		private string _addtime;
		private string _addpeople;
		private Guid _schooldistrictuuid;
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
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid StudentUuid
		{
			set{ _studentuuid=value;}
			get{return _studentuuid;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		/// ѧ��
		/// </summary>
		public string StuNum
		{
			set{ _stunum=value;}
			get{return _stunum;}
		}
		/// <summary>
		/// ѧԺ
		/// </summary>
		public Guid CollegeUuid
		{
			set{ _collegeuuid=value;}
			get{return _collegeuuid;}
		}
		/// <summary>
		/// רҵ
		/// </summary>
		public Guid MajorUuid
		{
			set{ _majoruuid=value;}
			get{return _majoruuid;}
		}
		/// <summary>
		/// �༶
		/// </summary>
		public Guid StuClassUuid
		{
			set{ _stuclassuuid=value;}
			get{return _stuclassuuid;}
		}
		/// <summary>
		/// һ��ͨ
		/// </summary>
		public string YiCard
		{
			set{ _yicard=value;}
			get{return _yicard;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public Guid DormitoryUuid
		{
			set{ _dormitoryuuid=value;}
			get{return _dormitoryuuid;}
		}
		/// <summary>
		/// ������ͼ
		/// </summary>
		public string Picture
		{
			set{ _picture=value;}
			get{return _picture;}
		}
		/// <summary>
		/// ���ƺ�
		/// </summary>
		public Guid DormitoryNumUuid
		{
			set{ _dormitorynumuuid=value;}
			get{return _dormitorynumuuid;}
		}
		/// <summary>
		/// ��ϵ��ʽ
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// ���֤��
		/// </summary>
		public string IdCard
		{
			set{ _idcard=value;}
			get{return _idcard;}
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
		/// ����
		/// </summary>
		public string Nation
		{
			set{ _nation=value;}
			get{return _nation;}
		}
		/// <summary>
		/// ������ò
		/// </summary>
		public string Political
		{
			set{ _political=value;}
			get{return _political;}
		}
		/// <summary>
		/// �ڽ�����
		/// </summary>
		public string Religion
		{
			set{ _religion=value;}
			get{return _religion;}
		}
		/// <summary>
		/// 0.δɾ 1.��ɾ
		/// </summary>
		public int? IsDeleted
		{
			set{ _isdeleted=value;}
			get{return _isdeleted;}
		}
		/// <summary>
		/// ���ʱ��
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
		/// ѧ��uuid
		/// </summary>
		public Guid SchoolDistrictUuid
		{
			set{ _schooldistrictuuid=value;}
			get{return _schooldistrictuuid;}
		}
		#endregion Model

	}
}

