namespace System.ComponentModel;

[DefaultMember("Item")]
public class AttributeCollection : ICollection, IEnumerable
{
	private struct AttributeEntry
	{
		public Type type; //Field offset: 0x0
		public int index; //Field offset: 0x8

	}

	public static readonly AttributeCollection Empty; //Field offset: 0x0
	private static Hashtable s_defaultAttributes; //Field offset: 0x8
	private static readonly object s_internalSyncObject; //Field offset: 0x10
	private readonly Attribute[] _attributes; //Field offset: 0x10
	private AttributeEntry[] _foundAttributeTypes; //Field offset: 0x18
	private int _index; //Field offset: 0x20

	protected override Attribute[] Attributes
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int Count
	{
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 38
	}

	public override Attribute Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AttributeCollection), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 27)]
		 get { } //Length: 1356
	}

	private override int System.Collections.ICollection.Count
	{
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 38
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private static AttributeCollection() { }

	[CalledBy(Type = typeof(MemberDescriptor), Member = "CreateAttributeCollection", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CalledBy(Type = "System.Data.DataColumnPropertyDescriptor", Member = "get_Attributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = "System.Data.DataRowView", Member = "System.ComponentModel.ICustomTypeDescriptor.GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public AttributeCollection(Attribute[] attributes) { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.ComponentModel.TypeConverter+SimplePropertyDescriptor", Member = "get_IsReadOnly", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "AddXdoProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object), typeof(XmlElement), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool Contains(Attribute attribute) { }

	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = "System.Data.DataColumnPropertyDescriptor", Member = "get_Attributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void CopyTo(Array array, int index) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected override Attribute[] get_Attributes() { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeCollection), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 27)]
	public override Attribute get_Item(Type attributeType) { }

	[CalledBy(Type = typeof(AttributeCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetReflectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public IEnumerator GetEnumerator() { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override int System.Collections.ICollection.get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

