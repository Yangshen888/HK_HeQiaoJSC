using System;
namespace ClassLibrary1.Model
{
	/// <summary>
	/// TcqType:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class TcqType
	{
		public TcqType()
		{}
		#region Model
		private Guid _tcqguid;
		private int? _tcqid;
		private string _tcqname;
		/// <summary>
		/// 
		/// </summary>
		public Guid Tcqguid
		{
			set{ _tcqguid=value;}
			get{return _tcqguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Tcqid
		{
			set{ _tcqid=value;}
			get{return _tcqid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TcqName
		{
			set{ _tcqname=value;}
			get{return _tcqname;}
		}
		#endregion Model

	}
}

