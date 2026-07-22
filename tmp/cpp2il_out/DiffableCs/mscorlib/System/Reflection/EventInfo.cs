namespace System.Reflection;

public abstract class EventInfo : MemberInfo
{
	private sealed class AddEventAdapter : MulticastDelegate
	{

		[CallerCount(Count = 290)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public AddEventAdapter(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(object _this, Delegate dele) { }

	}

	private AddEventAdapter cached_add_event; //Field offset: 0x10

	public override Type EventHandlerType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 279
	}

	public virtual MemberTypes MemberType
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected EventInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public override Type get_EventHandlerType() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual MemberTypes get_MemberType() { }

	[CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillMethods", ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.ComponentModel.EventDescriptor[]")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override MethodInfo GetAddMethod() { }

	public abstract MethodInfo GetAddMethod(bool nonPublic) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	public abstract MethodInfo GetRaiseMethod(bool nonPublic) { }

	[CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillMethods", ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.ComponentModel.EventDescriptor[]")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override MethodInfo GetRemoveMethod() { }

	public abstract MethodInfo GetRemoveMethod(bool nonPublic) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	[CallerCount(Count = 264)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	[CallerCount(Count = 165)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

}

