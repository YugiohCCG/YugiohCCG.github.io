namespace System.ComponentModel;

[DefaultMember("Item")]
public class EventDescriptorCollection : ICollection, IEnumerable, IList
{
	private class ArraySubsetEnumerator : IEnumerator
	{
		private readonly Array _array; //Field offset: 0x10
		private readonly int _total; //Field offset: 0x18
		private int _current; //Field offset: 0x1C

		public override object Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 108
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public ArraySubsetEnumerator(Array array, int count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public override object get_Current() { }

		[CallerCount(Count = 0)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override void Reset() { }

	}

	public static readonly EventDescriptorCollection Empty; //Field offset: 0x0
	private EventDescriptor[] _events; //Field offset: 0x10
	private String[] _namedSort; //Field offset: 0x18
	private readonly IComparer _comparer; //Field offset: 0x20
	private bool _eventsOwned; //Field offset: 0x28
	private bool _needSort; //Field offset: 0x29
	private readonly bool _readOnly; //Field offset: 0x2A
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x2C

	public private int Count
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public override EventDescriptor Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 126
	}

	public override EventDescriptor Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 20
	}

	private override int System.Collections.ICollection.Count
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override object System.Collections.IList.Item
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 17
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 14)]
		private set { } //Length: 421
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static EventDescriptorCollection() { }

	[CalledBy(Type = "System.Data.DataRowView", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEvents", ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = "System.Data.DataRowView", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Attribute[]"}, ReturnType = typeof(EventDescriptorCollection))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public EventDescriptorCollection(EventDescriptor[] events) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool)}, ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(Attribute[]), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public EventDescriptorCollection(EventDescriptor[] events, bool readOnly) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public int Add(EventDescriptor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public bool Contains(EventDescriptor value) { }

	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(EventDescriptor))]
	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "EnsureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "InternalSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnsureEventsOwned() { }

	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDescriptor)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EventDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void EnsureSize(int sizeNeeded) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override EventDescriptor Find(string name, bool ignoreCase) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public override EventDescriptor get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override EventDescriptor get_Item(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public IEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int IndexOf(EventDescriptor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void Insert(int index, EventDescriptor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(IComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "SortDescriptorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	protected void InternalSort(IComparer sorter) { }

	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(IComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "SortDescriptorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	protected void InternalSort(String[] names) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Remove(EventDescriptor value) { }

	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Count(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override int System.Collections.ICollection.get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private override int System.Collections.IList.Add(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override void System.Collections.IList.Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private override bool System.Collections.IList.Contains(object value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override object System.Collections.IList.get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private override int System.Collections.IList.IndexOf(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Collections.IList.Remove(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

