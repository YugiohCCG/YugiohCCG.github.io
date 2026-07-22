namespace UnityEngine;

[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
internal class UnityLogWriter : TextWriter
{

	public virtual Encoding Encoding
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Awaitable), Member = "RunOrScheduleContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AwaiterCompletionThreadAffinity), typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 19)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 1906
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextWriter), Member = ".ctor", ReturnType = typeof(void))]
	public UnityLogWriter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Awaitable), Member = "RunOrScheduleContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AwaiterCompletionThreadAffinity), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	public virtual Encoding get_Encoding() { }

	[CalledBy(Type = typeof(ClassLibraryInitializer), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextWriter), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(TextWriter))]
	[Calls(Type = typeof(Console), Member = "SetOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "SetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	public static void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityLogWriter), Member = "WriteStringToUnityLogImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Write(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityLogWriter), Member = "WriteStringToUnityLogImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public virtual void Write(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityLogWriter), Member = "WriteStringToUnityLogImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public virtual void Write(Char[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityLogWriter), Member = "WriteStringToUnityLogImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[ThreadAndSerializationSafe]
	public static void WriteStringToUnityLog(string s) { }

	[CalledBy(Type = typeof(UnityLogWriter), Member = "WriteStringToUnityLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityLogWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityLogWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityLogWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(IsThreadSafe = True)]
	private static void WriteStringToUnityLogImpl(string s) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void WriteStringToUnityLogImpl_Injected(ref ManagedSpanWrapper s) { }

}

