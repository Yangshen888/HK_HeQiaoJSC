using System;
namespace big_data.Model
{
	/// <summary>
	/// ���������Ϣ��
	/// </summary>
	[Serializable]
	public partial class Town
	{
		public Town()
		{}
		#region Model
		private Guid _townuuid;
		private int _id;
		private int? _isdeleted;
		private string _townname;
		private string _townpeople;
		private string _partymember;
		private string _geographical;
		private string _company;
		private Guid _sjtownuuid;
		private string _towngrade;
		private string _lon;
		private string _lat;
		private string _addtime;
		private string _addpeople;
		/// <summary>
		/// 
		/// </summary>
		public Guid TownUuid
		{
			set{ _townuuid=value;}
			get{return _townuuid;}
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
		/// ��������
		/// </summary>
		public string TownName
		{
			set{ _townname=value;}
			get{return _townname;}
		}
		/// <summary>
		/// �˿�
		/// </summary>
		public string TownPeople
		{
			set{ _townpeople=value;}
			get{return _townpeople;}
		}
		/// <summary>
		/// ��Ա����
		/// </summary>
		public string PartyMember
		{
			set{ _partymember=value;}
			get{return _partymember;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public string Geographical
		{
			set{ _geographical=value;}
			get{return _geographical;}
		}
		/// <summary>
		/// ��ҵ����
		/// </summary>
		public string Company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// �ϼ�����UUID
		/// </summary>
		public Guid SjTownUuid
		{
			set{ _sjtownuuid=value;}
			get{return _sjtownuuid;}
		}
		/// <summary>
		/// ����ȼ�
		/// </summary>
		public string TownGrade
		{
			set{ _towngrade=value;}
			get{return _towngrade;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Lon
		{
			set{ _lon=value;}
			get{return _lon;}
		}
		/// <summary>
		/// γ��
		/// </summary>
		public string Lat
		{
			set{ _lat=value;}
			get{return _lat;}
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
		#endregion Model

	}
}

