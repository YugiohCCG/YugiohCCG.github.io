namespace System.ComponentModel;

[DefaultMember("Item")]
public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
{
	private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private PropertyDescriptorCollection _owner; //Field offset: 0x10
		private int _index; //Field offset: 0x18

		public override object Current
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 159
		}

		public override DictionaryEntry Entry
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 111
		}

		public override object Key
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 69
		}

		public override object Value
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 69
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public override object get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public override DictionaryEntry get_Entry() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override object get_Key() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override object get_Value() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override void Reset() { }

	}

	public static readonly PropertyDescriptorCollection Empty; //Field offset: 0x0
	private IDictionary _cachedFoundProperties; //Field offset: 0x10
	private bool _cachedIgnoreCase; //Field offset: 0x18
	private PropertyDescriptor[] _properties; //Field offset: 0x20
	private readonly String[] _namedSort; //Field offset: 0x28
	private readonly IComparer _comparer; //Field offset: 0x30
	private bool _propsOwned; //Field offset: 0x38
	private bool _needSort; //Field offset: 0x39
	private bool _readOnly; //Field offset: 0x3A
	private readonly object _internalSyncObject; //Field offset: 0x40
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x48

	public private int Count
	{
		[CallerCount(Count = 26)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public override PropertyDescriptor Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 126
	}

	public override PropertyDescriptor Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 20
	}

	private override int System.Collections.ICollection.Count
	{
		[CallerCount(Count = 26)]
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

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override bool System.Collections.IDictionary.IsReadOnly
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override object System.Collections.IDictionary.Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 92
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 26)]
		private set { } //Length: 1080
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 188
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 201
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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 17
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 18)]
		private set { } //Length: 558
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static PropertyDescriptorCollection() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, String[] namedSort, IComparer comparer) { }

	[CalledBy(Type = typeof(ArrayConverter), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(DesignerOptionConverter), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "System.ComponentModel.ITypedList.GetItemProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.PropertyDescriptor[]"}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Attribute[]"}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = "System.Data.DataTable", Member = "GetPropertyDescriptorCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Attribute[]"}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = "System.Data.DataRowView", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataView", Member = "System.ComponentModel.ITypedList.GetItemProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.PropertyDescriptor[]"}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public PropertyDescriptorCollection(PropertyDescriptor[] properties) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(Attribute[]), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CalledBy(Type = typeof(DesignerOptionCollection), Member = "get_Properties", ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly) { }

	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IDictionary.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DesignerOptionConverter), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public int Add(PropertyDescriptor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public bool Contains(PropertyDescriptor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public override void CopyTo(Array array, int index) { }

	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyDescriptor))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "EnsureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "InternalSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnsurePropsOwned() { }

	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void EnsureSize(int sizeNeeded) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	public override PropertyDescriptor Find(string name, bool ignoreCase) { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public override PropertyDescriptor get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override PropertyDescriptor get_Item(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int IndexOf(PropertyDescriptor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void Insert(int index, PropertyDescriptor value) { }

	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
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
	[Calls(Type = typeof(Array), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(IComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "SortDescriptorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	protected void InternalSort(IComparer sorter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Remove(PropertyDescriptor value) { }

	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public override PropertyDescriptorCollection Sort(String[] names) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	private override int System.Collections.ICollection.get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private override void System.Collections.IDictionary.Clear() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private override int System.Collections.IList.Add(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override object System.Collections.IList.get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private override int System.Collections.IList.IndexOf(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Collections.IList.Remove(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

