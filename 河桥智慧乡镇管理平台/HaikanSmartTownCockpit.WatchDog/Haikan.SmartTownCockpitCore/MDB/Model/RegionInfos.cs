using System;
namespace big_data.Model
{
	/// <summary>
	/// ����������
	/// </summary>
	[Serializable]
	public partial class RegionInfos
	{
		public RegionInfos()
		{}
		#region Model
		private int _id;
		private int? _regionid;
		private string _regionxyinfo;
		private DateTime? _addtime= DateTime.Now;
		private string _unifiedaddresslibraryid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ����id
		/// </summary>
		public int? RegionID
		{
			set{ _regionid=value;}
			get{return _regionid;}
		}
		/// <summary>
		/// ���꼯�� ���磺120.3654541,30.4414447|120.3654541,30.4414447
		/// </summary>
		public string RegionXYInfo
		{
			set{ _regionxyinfo=value;}
			get{return _regionxyinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// ��ַ��ID����
		/// </summary>
		public string UnifiedAddressLibraryID
		{
			set{ _unifiedaddresslibraryid=value;}
			get{return _unifiedaddresslibraryid;}
		}
		#endregion Model

	}
}

