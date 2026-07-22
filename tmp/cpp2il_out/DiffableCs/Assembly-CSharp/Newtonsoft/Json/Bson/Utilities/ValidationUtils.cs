namespace Newtonsoft.Json.Bson.Utilities;

internal static class ValidationUtils
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL64), Member = "LZ4HC_encodeSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte**), typeof(Byte**), typeof(Byte**), typeof(int), typeof(Byte*), typeof(limitedOutput_directive), typeof(Byte*)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 128)]
	[ContainsUnimplementedInstructions]
	public static void ArgumentNotNull(object value, string parameterName) { }

}

