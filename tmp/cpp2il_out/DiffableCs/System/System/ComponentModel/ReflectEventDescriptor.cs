namespace System.ComponentModel;

internal sealed class ReflectEventDescriptor : EventDescriptor
{
	private Type _type; //Field offset: 0x60
	private readonly Type _componentClass; //Field offset: 0x68
	private MethodInfo _addMethod; //Field offset: 0x70
	private MethodInfo _removeMethod; //Field offset: 0x78
	private EventInfo _realEvent; //Field offset: 0x80
	private bool _filledMethods; //Field offset: 0x88

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventDescriptor[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public ReflectEventDescriptor(Type componentClass, EventInfo eventInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectEventDescriptor), Member = "FillMethods", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectEventDescriptor), Member = "FillSingleMethodAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(IList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectEventDescriptor), Member = "FillEventInfoAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), typeof(IList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemberDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void FillAttributes(IList attributes) { }

	[CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Attribute[]))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	[CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(EventInfo))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MemberDescriptor), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[]), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(EventInfo), Member = "GetAddMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(EventInfo), Member = "GetRemoveMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 19)]
	private void FillMethods() { }

	[CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Attribute[]))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

}

