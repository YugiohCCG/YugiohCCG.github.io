namespace System.ComponentModel;

[ComVisible(True)]
public abstract class MemberDescriptor
{
	private string name; //Field offset: 0x10
	private string displayName; //Field offset: 0x18
	private int nameHash; //Field offset: 0x20
	private AttributeCollection attributeCollection; //Field offset: 0x28
	private Attribute[] attributes; //Field offset: 0x30
	private Attribute[] originalAttributes; //Field offset: 0x38
	private bool attributesFiltered; //Field offset: 0x40
	private bool attributesFilled; //Field offset: 0x41
	private int metadataVersion; //Field offset: 0x44
	private string category; //Field offset: 0x48
	private string description; //Field offset: 0x50
	private object lockCookie; //Field offset: 0x58

	protected override Attribute[] AttributeArray
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemberDescriptor), Member = "CheckAttributesValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(MemberDescriptor), Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
		 get { } //Length: 36
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 193
	}

	public override AttributeCollection Attributes
	{
		[CalledBy(Type = "System.Data.DataColumnPropertyDescriptor", Member = "get_Attributes", ReturnType = typeof(AttributeCollection))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(MemberDescriptor), Member = "CheckAttributesValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 226
	}

	public override string DisplayName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 282
	}

	public override string Name
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 67
	}

	protected override int NameHashCode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(EventDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Attribute[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Attribute[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectEventDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(EventInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type), typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	protected MemberDescriptor(string name, Attribute[] attributes) { }

	[CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReflectPropertyDescriptor), typeof(Type), typeof(IExtenderProvider), typeof(Attribute[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberDescriptor), typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 16)]
	protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	[CalledBy(Type = typeof(MemberDescriptor), Member = "get_AttributeArray", ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = typeof(MemberDescriptor), Member = "get_Attributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void CheckAttributesValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override AttributeCollection CreateAttributeCollection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(MemberDescriptor), Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(PropertyDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected override void FillAttributes(IList attributeList) { }

	[CalledBy(Type = typeof(MemberDescriptor), Member = "get_AttributeArray", ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = typeof(MemberDescriptor), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 20)]
	private void FilterAttributesIfNeeded() { }

	[CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillMethods", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberDescriptor), Member = "CheckAttributesValid", ReturnType = typeof(void))]
	[Calls(Type = typeof(MemberDescriptor), Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
	protected override Attribute[] get_AttributeArray() { }

	[CalledBy(Type = "System.Data.DataColumnPropertyDescriptor", Member = "get_Attributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MemberDescriptor), Member = "CheckAttributesValid", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override AttributeCollection get_Attributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_DisplayName() { }

	[CallerCount(Count = 0)]
	public override string get_Name() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected override int get_NameHashCode() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAssociation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	protected override object GetInvocationTarget(Type type, object instance) { }

	[CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "get_DisplayName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderSetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	protected static ISite GetSite(object component) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected override void set_AttributeArray(Attribute[] value) { }

}

