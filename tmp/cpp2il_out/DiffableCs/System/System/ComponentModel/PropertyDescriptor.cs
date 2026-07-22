namespace System.ComponentModel;

public abstract class PropertyDescriptor : MemberDescriptor
{
	private TypeConverter _converter; //Field offset: 0x60
	private Hashtable _valueChangedHandlers; //Field offset: 0x68
	private Object[] _editors; //Field offset: 0x70
	private Type[] _editorTypes; //Field offset: 0x78
	private int _editorCount; //Field offset: 0x80

	public abstract Type ComponentType
	{
		 get { } //Length: 0
	}

	public override TypeConverter Converter
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(PropertyDescriptor), Member = "GetTypeFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(PropertyDescriptor), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeConverter))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 666
	}

	public abstract bool IsReadOnly
	{
		 get { } //Length: 0
	}

	public abstract Type PropertyType
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Attribute[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected PropertyDescriptor(string name, Attribute[] attrs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberDescriptor), typeof(Attribute[])}, ReturnType = typeof(void))]
	protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs) { }

	public abstract bool CanResetValue(object component) { }

	[CalledBy(Type = typeof(PropertyDescriptor), Member = "get_Converter", ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeDescriptor), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IServiceProvider), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	protected object CreateInstance(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void FillAttributes(IList attributeList) { }

	public abstract Type get_ComponentType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PropertyDescriptor), Member = "GetTypeFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PropertyDescriptor), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeConverter))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public override TypeConverter get_Converter() { }

	public abstract bool get_IsReadOnly() { }

	public abstract Type get_PropertyType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAssociation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	[CalledBy(Type = typeof(PropertyDescriptor), Member = "get_Converter", ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	protected Type GetTypeFromName(string typeName) { }

	public abstract object GetValue(object component) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnValueChanged(object component, EventArgs e) { }

	public abstract void ResetValue(object component) { }

	public abstract void SetValue(object component, object value) { }

	public abstract bool ShouldSerializeValue(object component) { }

}

