using System;
namespace ClassLibrary1.Model
{
	/// <summary>
	/// ����¥
	/// </summary>
	[Serializable]
	public partial class Dormitory
	{
		public Dormitory()
		{}
		#region Model
		private int _id;
		private DateTime? _createtime= DateTime.Now;
		private Guid _dormitoryuuid;
		private string _dormitoryname;
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
		public Guid DormitoryUuid
		{
			set{ _dormitoryuuid=value;}
			get{return _dormitoryuuid;}
		}
		/// <summary>
		/// ����¥����
		/// </summary>
		public string DormitoryName
		{
			set{ _dormitoryname=value;}
			get{return _dormitoryname;}
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
		/// У��uuid
		/// </summary>
		public Guid SchoolDistrictUuid
		{
			set{ _schooldistrictuuid=value;}
			get{return _schooldistrictuuid;}
		}
		#endregion Model

	}
}

