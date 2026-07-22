namespace K4os.Hash.xxHash;

public class XXH
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XXH() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void Validate(Byte[] bytes, int offset, int length) { }

	[CallerCount(Count = 0)]
	internal static void XXH_copy(Void* target, Void* source, int length) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	internal static uint XXH_read32(Void* p) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	internal static ulong XXH_read64(Void* p) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void XXH_zero(Void* target, int length) { }

}

