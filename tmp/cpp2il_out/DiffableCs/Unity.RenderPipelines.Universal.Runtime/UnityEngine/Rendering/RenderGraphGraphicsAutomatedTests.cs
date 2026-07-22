namespace UnityEngine.Rendering;

public static class RenderGraphGraphicsAutomatedTests
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<String> <>9__1_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool <get_activatedFromCommandLine>b__1_0(string arg) { }

	}

	[CompilerGenerated]
	private static bool <enabled>k__BackingField; //Field offset: 0x0

	private static bool activatedFromCommandLine
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Exists", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Predicate`1<T>"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 282
	}

	public static bool enabled
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 83
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Exists", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Predicate`1<T>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static RenderGraphGraphicsAutomatedTests() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Exists", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Predicate`1<T>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool get_activatedFromCommandLine() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_enabled() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static void set_enabled(bool value) { }

}

