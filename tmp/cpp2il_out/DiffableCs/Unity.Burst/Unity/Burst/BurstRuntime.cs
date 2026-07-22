namespace Unity.Burst;

public static class BurstRuntime
{
	private struct HashCode32
	{
		public static readonly int Value; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(BurstRuntime), Member = "HashStringWithFNV1A32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private static HashCode32`1() { }

	}

	private struct HashCode64
	{
		public static readonly long Value; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private static HashCode64`1() { }

	}

	public class PreserveAttribute : Attribute
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PreserveAttribute() { }

	}


	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static int GetHashCode32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetHashCode32(Type type) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static long GetHashCode64() { }

	[CalledBy(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(uint)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
	[CalledBy(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(uint)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static long GetHashCode64(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static Byte* GetUTF8LiteralPointer(string str, out int byteCount) { }

	[CalledBy(Type = typeof(HashCode32`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	internal static int HashStringWithFNV1A32(string text) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static long HashStringWithFNV1A64(string text) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstCompiler), Member = "IsApiAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 7)]
	public static bool LoadAdditionalLibrary(string pathToLibBurstGenerated) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 7)]
	internal static bool LoadAdditionalLibraryInternal(string pathToLibBurstGenerated) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), "Unity.Burst.LowLevel.BurstCompilerService+BurstLogType", typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Preserve]
	internal static void Log(Byte* message, int logType, Byte* fileName, int lineNumber) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Preserve]
	internal static void PreventRequiredAttributeStrip() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "RuntimeLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), "Unity.Burst.LowLevel.BurstCompilerService+BurstLogType", typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Preserve]
	internal static void RuntimeLog(Byte* message, int logType, Byte* fileName, int lineNumber) { }

}

