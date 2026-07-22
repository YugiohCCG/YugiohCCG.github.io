namespace Newtonsoft.Json;

[AttributeUsage(2432, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(2)]
public sealed class JsonPropertyAttribute : Attribute
{
	internal Nullable<NullValueHandling> _nullValueHandling; //Field offset: 0x10
	internal Nullable<DefaultValueHandling> _defaultValueHandling; //Field offset: 0x18
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; //Field offset: 0x20
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; //Field offset: 0x28
	internal Nullable<TypeNameHandling> _typeNameHandling; //Field offset: 0x30
	internal Nullable<Boolean> _isReference; //Field offset: 0x38
	internal Nullable<Int32> _order; //Field offset: 0x3C
	internal Nullable<Required> _required; //Field offset: 0x44
	internal Nullable<Boolean> _itemIsReference; //Field offset: 0x4C
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; //Field offset: 0x50
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; //Field offset: 0x58
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Object[] <ItemConverterParameters>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Type <NamingStrategyType>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Object[] <NamingStrategyParameters>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private string <PropertyName>k__BackingField; //Field offset: 0x80

	public DefaultValueHandling DefaultValueHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public bool IsReference
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 57
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Object[] ItemConverterParameters
	{
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Type ItemConverterType
	{
		[CallerCount(Count = 84)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool ItemIsReference
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 57
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public ReferenceLoopHandling ItemReferenceLoopHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public TypeNameHandling ItemTypeNameHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Object[] NamingStrategyParameters
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Type NamingStrategyType
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public NullValueHandling NullValueHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public ObjectCreationHandling ObjectCreationHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public int Order
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public string PropertyName
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 16
	}

	public ReferenceLoopHandling ReferenceLoopHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public Required Required
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public TypeNameHandling TypeNameHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	public JsonPropertyAttribute(string propertyName) { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonPropertyAttribute() { }

	[CallerCount(Count = 0)]
	public DefaultValueHandling get_DefaultValueHandling() { }

	[CallerCount(Count = 0)]
	public bool get_IsReference() { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Object[] get_ItemConverterParameters() { }

	[CallerCount(Count = 84)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Type get_ItemConverterType() { }

	[CallerCount(Count = 0)]
	public bool get_ItemIsReference() { }

	[CallerCount(Count = 0)]
	public ReferenceLoopHandling get_ItemReferenceLoopHandling() { }

	[CallerCount(Count = 0)]
	public TypeNameHandling get_ItemTypeNameHandling() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Object[] get_NamingStrategyParameters() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Type get_NamingStrategyType() { }

	[CallerCount(Count = 0)]
	public NullValueHandling get_NullValueHandling() { }

	[CallerCount(Count = 0)]
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	[CallerCount(Count = 0)]
	public int get_Order() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_PropertyName() { }

	[CallerCount(Count = 0)]
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	[CallerCount(Count = 0)]
	public Required get_Required() { }

	[CallerCount(Count = 0)]
	public TypeNameHandling get_TypeNameHandling() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_IsReference(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ItemConverterParameters(Object[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ItemConverterType(Type value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ItemIsReference(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ItemReferenceLoopHandling(ReferenceLoopHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ItemTypeNameHandling(TypeNameHandling value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_NamingStrategyParameters(Object[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_NamingStrategyType(Type value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_NullValueHandling(NullValueHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_Order(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_PropertyName(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_Required(Required value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_TypeNameHandling(TypeNameHandling value) { }

}

