namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
[UsedByNativeCode]
internal struct AsyncRequestNativeArrayData
{
	public Void* nativeArrayBuffer; //Field offset: 0x0
	public long lengthInBytes; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static AsyncRequestNativeArrayData CreateAndCheckAccess(NativeArray<T> array) { }

}

