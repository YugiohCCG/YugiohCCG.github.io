namespace Unity.Burst.LowLevel;

[NativeHeader("Runtime/Burst/Burst.h")]
[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
[StaticAccessor("BurstCompilerService::Get()", StaticAccessorType::Arrow (1))]
internal static class BurstCompilerService
{
	internal enum BurstLogType
	{
		Info = 0,
		Warning = 1,
		Error = 2,
	}


	[CalledBy(Type = "Unity.Burst.BurstCompiler+BurstCompilerHelper", Member = "IsCompiledByBurst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler+BurstCompilerHelper", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(IsThreadSafe = True)]
	public static int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int CompileAsyncDelegateMethod_Injected(object delegateMethod, ref ManagedSpanWrapper compilerOptions) { }

	[CalledBy(Type = "Unity.Burst.BurstCompiler+BurstCompilerHelper", Member = "IsCompiledByBurst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler+BurstCompilerHelper", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static Void* GetAsyncCompiledAsyncDelegateMethod(int userID) { }

	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "GetExecutionMode", ReturnType = "Unity.Burst.BurstExecutionEnvironment")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static uint GetCurrentExecutionMode() { }

	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "SendRawCommandToCompiler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[ThreadSafe]
	public static string GetDisassembly(MethodInfo m, string compilerOptions) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetDisassembly_Injected(MethodInfo m, ref ManagedSpanWrapper compilerOptions, out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "Unity.Burst.SharedStatic", Member = "GetOrCreateSharedStaticInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(uint), typeof(uint)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static Void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public static bool LoadBurstLibrary(string fullPathToLibBurstGenerated) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool LoadBurstLibrary_Injected(ref ManagedSpanWrapper fullPathToLibBurstGenerated) { }

	[CalledBy(Type = "Unity.Burst.BurstRuntime", Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int), "System.Byte*", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("DefaultBurstLogCallback", True)]
	public static void Log(Void* userData, BurstLogType logType, Byte* message, Byte* filename, int lineNumber) { }

	[CalledBy(Type = "Unity.Burst.BurstRuntime", Member = "RuntimeLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int), "System.Byte*", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("DefaultBurstRuntimeLogCallback", True)]
	public static void RuntimeLog(Void* userData, BurstLogType logType, Byte* message, Byte* filename, int lineNumber) { }

	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "SetExecutionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.BurstExecutionEnvironment"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void SetCurrentExecutionMode(uint environment) { }

}

