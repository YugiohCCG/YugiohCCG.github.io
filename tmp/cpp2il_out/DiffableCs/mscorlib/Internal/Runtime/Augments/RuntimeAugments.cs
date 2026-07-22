namespace Internal.Runtime.Augments;

internal class RuntimeAugments
{
	private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks; //Field offset: 0x0

	internal static ReflectionExecutionDomainCallbacks Callbacks
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static RuntimeAugments() { }

	[CallerCount(Count = 0)]
	internal static ReflectionExecutionDomainCallbacks get_Callbacks() { }

	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "ThrowAsyncIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ReportUnhandledException(Exception exception) { }

}

