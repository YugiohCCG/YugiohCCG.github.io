namespace System.Security.Policy;

[ComVisible(True)]
[MonoTODO("Serialization format not compatible with .NET")]
public sealed class Evidence : ICollection, IEnumerable
{
	private class EvidenceEnumerator : IEnumerator
	{
		private IEnumerator currentEnum; //Field offset: 0x10
		private IEnumerator hostEnum; //Field offset: 0x18
		private IEnumerator assemblyEnum; //Field offset: 0x20

		public override object Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 73
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public override object get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public override void Reset() { }

	}

	private bool _locked; //Field offset: 0x10
	private ArrayList hostEvidenceList; //Field offset: 0x18
	private ArrayList assemblyEvidenceList; //Field offset: 0x20

	[Obsolete]
	public override int Count
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 97
	}

	public override bool IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override object SyncRoot
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Evidence() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete]
	public override void CopyTo(Array array, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override int get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsSynchronized() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public override object get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Obsolete]
	public override IEnumerator GetEnumerator() { }

}

