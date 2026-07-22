namespace UnityEngine.Bindings;

[NativeHeader("Runtime/Scripting/Marshalling/BindingsAllocator.h")]
[StaticAccessor("Marshalling::BindingsAllocator", StaticAccessorType::DoubleColon (2))]
[VisibleToOtherModules]
internal static class BindingsAllocator
{
	private struct NativeOwnedMemory
	{
		public Void* data; //Field offset: 0x0

	}


	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void Free(Void* ptr) { }

	[CalledBy(Type = typeof(BlittableArrayWrapper), Member = "Unmarshal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void FreeNativeOwnedMemory(Void* ptr) { }

	[CallerCount(Count = 46)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static Void* GetNativeOwnedDataPointer(Void* ptr) { }

}

