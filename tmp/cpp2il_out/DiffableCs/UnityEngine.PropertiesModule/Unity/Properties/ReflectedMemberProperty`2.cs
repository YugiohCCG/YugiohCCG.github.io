namespace Unity.Properties;

public class ReflectedMemberProperty : Property<TContainer, TValue>
{
	private sealed class GetClassValueAction : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public GetClassValueAction(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override TValue Invoke(TContainer container) { }

	}

	private sealed class GetStructValueAction : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public GetStructValueAction(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override TValue Invoke(ref TContainer container) { }

	}

	private sealed class SetClassValueAction : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public SetClassValueAction(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(TContainer container, TValue value) { }

	}

	private sealed class SetStructValueAction : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public SetStructValueAction(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(ref TContainer container, TValue value) { }

	}

	private readonly IMemberInfo m_Info; //Field offset: 0x0
	private readonly bool m_IsStructContainerType; //Field offset: 0x0
	private GetStructValueAction<TContainer, TValue> m_GetStructValueAction; //Field offset: 0x0
	private SetStructValueAction<TContainer, TValue> m_SetStructValueAction; //Field offset: 0x0
	private GetClassValueAction<TContainer, TValue> m_GetClassValueAction; //Field offset: 0x0
	private SetClassValueAction<TContainer, TValue> m_SetClassValueAction; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <Name>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x0

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual string Name
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 38)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal ReflectedMemberProperty`2(IMemberInfo info, string name) { }

	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 24)]
	[DeduplicatedMethod]
	public virtual TValue GetValue(ref TContainer container) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	[DeduplicatedMethod]
	public virtual void SetValue(ref TContainer container, TValue value) { }

}

