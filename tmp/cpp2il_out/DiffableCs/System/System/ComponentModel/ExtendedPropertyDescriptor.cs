namespace System.ComponentModel;

internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor
{
	private readonly ReflectPropertyDescriptor _extenderInfo; //Field offset: 0x88
	private readonly IExtenderProvider _provider; //Field offset: 0x90

	public virtual Type ComponentType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
	}

	public virtual string DisplayName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ISite))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 585
	}

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 225
	}

	public virtual Type PropertyType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
	}

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider)}, ReturnType = typeof(PropertyDescriptor[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberDescriptor), typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool CanResetValue(object comp) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_ComponentType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ISite))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_DisplayName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_PropertyType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public virtual object GetValue(object comp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ResetValue(object comp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderSetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetValue(object component, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool ShouldSerializeValue(object comp) { }

}

