namespace Unity.Collections.LowLevel.Unsafe.NotBurstCompatible;

[Extension]
public static class Extensions
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeAppendBuffer), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeAppendBuffer), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Extension]
	public static void AddNBC(ref UnsafeAppendBuffer buffer, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Reader), Member = "ReadNext", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromBurstCompatTesting("Managed string out argument")]
	[Extension]
	public static void ReadNextNBC(ref Reader reader, out string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T[] ToArray(UnsafeParallelHashSet<T> set) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	public static Byte[] ToBytesNBC(ref UnsafeAppendBuffer buffer) { }

}

