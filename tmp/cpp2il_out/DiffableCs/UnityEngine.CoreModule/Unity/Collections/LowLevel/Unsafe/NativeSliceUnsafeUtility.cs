namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
public static class NativeSliceUnsafeUtility
{

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static NativeSlice<T> ConvertExistingDataToNativeSlice(Void* dataPointer, int stride, int length) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	[Extension]
	public static Void* GetUnsafePtr(NativeSlice<T> nativeSlice) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	[Extension]
	public static Void* GetUnsafeReadOnlyPtr(NativeSlice<T> nativeSlice) { }

}

