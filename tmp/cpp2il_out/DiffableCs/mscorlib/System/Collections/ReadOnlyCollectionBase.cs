namespace System.Collections;

public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
{
	private ArrayList _list; //Field offset: 0x10

	public override int Count
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 45
	}

	protected ArrayList InnerList
	{
		[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.get_IsSynchronized", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = "System.ComponentModel.ComponentCollection", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.ComponentModel.IComponent")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 161
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 45
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 45
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ReadOnlyCollectionBase() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override int get_Count() { }

	[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.get_IsSynchronized", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CalledBy(Type = "System.ComponentModel.ComponentCollection", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.ComponentModel.IComponent")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected ArrayList get_InnerList() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override object System.Collections.ICollection.get_SyncRoot() { }

}

