namespace System.Diagnostics;

internal static class TraceInternal
{
	[ThreadStatic]
	private static int indentLevel; //Field offset: 0x80000000
	private static string appName; //Field offset: 0x0
	private static TraceListenerCollection listeners; //Field offset: 0x8
	private static bool autoFlush; //Field offset: 0x10
	private static int indentSize; //Field offset: 0x14
	internal static readonly object critSec; //Field offset: 0x18

	public static bool AutoFlush
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 90
	}

	public static int IndentLevel
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 72
	}

	public static int IndentSize
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 88
	}

	public static TraceListenerCollection Listeners
	{
		[CalledBy(Type = typeof(Trace), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TraceListener), Member = "set_IndentSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TraceListenerCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceListener)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		 get { } //Length: 786
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static TraceInternal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_AutoFlush() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int get_IndentLevel() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int get_IndentSize() { }

	[CalledBy(Type = typeof(Trace), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TraceListener), Member = "set_IndentSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TraceListenerCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceListener)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public static TraceListenerCollection get_Listeners() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static void InitializeSettings() { }

}

