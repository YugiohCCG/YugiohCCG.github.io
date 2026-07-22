namespace Unity.Collections;

[NativeClass(null)]
internal struct NativeArrayDisposeJob : IJob
{
	internal NativeArrayDispose Data; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void Execute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "EarlyJobInit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	internal static void RegisterNativeArrayDisposeJobReflectionData() { }

}

