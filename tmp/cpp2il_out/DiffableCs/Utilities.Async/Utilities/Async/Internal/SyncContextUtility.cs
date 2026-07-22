namespace Utilities.Async.Internal;

public static class SyncContextUtility
{
	[CompilerGenerated]
	private static int <UnityThreadId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static SynchronizationContext <UnitySynchronizationContext>k__BackingField; //Field offset: 0x8

	public static bool IsMainThread
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 71
	}

	public private static SynchronizationContext UnitySynchronizationContext
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 86
	}

	public private static int UnityThreadId
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 53
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 58
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsMainThread() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static SynchronizationContext get_UnitySynchronizationContext() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static int get_UnityThreadId() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterAssembliesLoaded (2))]
	private static void Initialize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_UnitySynchronizationContext(SynchronizationContext value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static void set_UnityThreadId(int value) { }

}

