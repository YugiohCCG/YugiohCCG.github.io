namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Method (64))]
[VisibleToOtherModules]
internal class FreeFunctionAttribute : NativeMethodAttribute
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FreeFunctionAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public FreeFunctionAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public FreeFunctionAttribute(string name, bool isThreadSafe) { }

}

