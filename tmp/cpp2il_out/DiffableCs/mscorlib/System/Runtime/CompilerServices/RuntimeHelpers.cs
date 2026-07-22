namespace System.Runtime.CompilerServices;

public static class RuntimeHelpers
{

	public static int OffsetToStringData
	{
		[CallerCount(Count = 285)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser+TagTypeInfo", Member = "PrintMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser+ParseError", Member = "PrintMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InsufficientExecutionStackException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void EnsureSufficientExecutionStack() { }

	[CallerCount(Count = 285)]
	[CallsUnknownMethods(Count = 1)]
	public static int get_OffsetToStringData() { }

	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int GetHashCode(object o) { }

	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ValueTypeCopyInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static object GetObjectValue(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void InitializeArray(Array array, IntPtr fldHandle) { }

	[CallerCount(Count = 1096)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "HasReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool IsReferenceOrContainsReferences() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static void PrepareConstrainedRegions() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void RunClassConstructor(IntPtr type) { }

	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "GetEditorTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Hashtable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static void RunClassConstructor(RuntimeTypeHandle type) { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static bool SufficientExecutionStack() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool TryEnsureSufficientExecutionStack() { }

}

