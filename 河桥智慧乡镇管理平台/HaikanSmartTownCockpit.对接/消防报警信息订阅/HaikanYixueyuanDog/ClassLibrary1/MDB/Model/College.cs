using System;
namespace ClassLibrary1.Model
{
	/// <summary>
	/// ѧԺ��
	/// </summary>
	[Serializable]
	public partial class College
	{
		public College()
		{}
		#region Model
		private int _id;
		private DateTime? _createtime= DateTime.Now;
		private Guid _collegeuuid;
		private string _collegename;
		private int? _isdeleted;
		private string _addtime;
		private string _addpeople;
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
		public Guid CollegeUuid
		{
			set{ _collegeuuid=value;}
			get{return _collegeuuid;}
		}
		/// <summary>
		/// ѧԺ����
		/// </summary>
		public string CollegeName
		{
			set{ _collegename=value;}
			get{return _collegename;}
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
		#endregion Model

	}
}

