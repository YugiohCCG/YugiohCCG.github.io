namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Property (128))]
[VisibleToOtherModules]
internal class NativePropertyAttribute : NativeMethodAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TargetType <TargetType>k__BackingField; //Field offset: 0x20

	public TargetType TargetType
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativePropertyAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public NativePropertyAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public NativePropertyAttribute(string name, bool isFree, TargetType targetType) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_TargetType(TargetType value) { }

}

