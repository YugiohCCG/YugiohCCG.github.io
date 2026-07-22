namespace System.ComponentModel;

internal sealed class ReflectPropertyDescriptor : PropertyDescriptor
{
	private static readonly Type[] argsNone; //Field offset: 0x0
	private static readonly object noValue; //Field offset: 0x8
	private static TraceSwitch PropDescCreateSwitch; //Field offset: 0x10
	private static TraceSwitch PropDescUsageSwitch; //Field offset: 0x18
	private static readonly int BitDefaultValueQueried; //Field offset: 0x20
	private static readonly int BitGetQueried; //Field offset: 0x24
	private static readonly int BitSetQueried; //Field offset: 0x28
	private static readonly int BitShouldSerializeQueried; //Field offset: 0x2C
	private static readonly int BitResetQueried; //Field offset: 0x30
	private static readonly int BitChangedQueried; //Field offset: 0x34
	private static readonly int BitIPropChangedQueried; //Field offset: 0x38
	private static readonly int BitReadOnlyChecked; //Field offset: 0x3C
	private static readonly int BitAmbientValueQueried; //Field offset: 0x40
	private static readonly int BitSetOnDemand; //Field offset: 0x44
	private BitVector32 state; //Field offset: 0x88
	private Type componentClass; //Field offset: 0x90
	private Type type; //Field offset: 0x98
	private object defaultValue; //Field offset: 0xA0
	private object ambientValue; //Field offset: 0xA8
	private PropertyInfo propInfo; //Field offset: 0xB0
	private MethodInfo getMethod; //Field offset: 0xB8
	private MethodInfo setMethod; //Field offset: 0xC0
	private MethodInfo shouldSerializeMethod; //Field offset: 0xC8
	private MethodInfo resetMethod; //Field offset: 0xD0
	private EventDescriptor realChangedEvent; //Field offset: 0xD8
	private Type receiverType; //Field offset: 0xE0

	private object AmbientValue
	{
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 427
	}

	public virtual Type ComponentType
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	private object DefaultValue
	{
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		private get { } //Length: 754
	}

	private MethodInfo GetMethodValue
	{
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
		[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
		[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 30)]
		private get { } //Length: 1318
	}

	private bool IsExtender
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 52
	}

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 244
	}

	public virtual Type PropertyType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	private MethodInfo ResetMethodValue
	{
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 7)]
		private get { } //Length: 699
	}

	private MethodInfo SetMethodValue
	{
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_IsReadOnly", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderSetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
		[Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
		[CallsDeduplicatedMethods(Count = 23)]
		[CallsUnknownMethods(Count = 13)]
		private get { } //Length: 1645
	}

	private MethodInfo ShouldSerializeMethodValue
	{
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 7)]
		private get { } //Length: 699
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TraceSwitch), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitVector32), Member = "CreateMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static ReflectPropertyDescriptor() { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider)}, ReturnType = typeof(PropertyDescriptor[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type), typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type), typeof(PropertyInfo), typeof(MethodInfo), typeof(MethodInfo), typeof(Attribute[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type), typeof(Type), typeof(MethodInfo), typeof(MethodInfo), typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 23)]
	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyDescriptor[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type), typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_AmbientValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool CanResetValue(object component) { }

	[CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal Type ExtenderGetReceiverType() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	[CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderSetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	[CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_AmbientValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ISite))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderSetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	[CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ISite))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	[CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "ShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(AttributeCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Attribute[]))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MemberInfo[]))]
	[Calls(Type = typeof(MemberDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 30)]
	protected virtual void FillAttributes(IList attributes) { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private object get_AmbientValue() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public virtual Type get_ComponentType() { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	private object get_DefaultValue() { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 30)]
	private MethodInfo get_GetMethodValue() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool get_IsExtender() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual Type get_PropertyType() { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private MethodInfo get_ResetMethodValue() { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_IsReadOnly", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderSetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 13)]
	private MethodInfo get_SetMethodValue() { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ShouldSerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private MethodInfo get_ShouldSerializeMethodValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(SecurityUtils), Member = "MethodInfoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 38)]
	public virtual object GetValue(object component) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_AmbientValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ISite))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(SecurityUtils), Member = "MethodInfoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public virtual void ResetValue(object component) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ISite))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(SecurityUtils), Member = "MethodInfoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	public virtual void SetValue(object component, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(AttributeCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public virtual bool ShouldSerializeValue(object component) { }

}

