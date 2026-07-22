namespace System.Threading;

internal static class PlatformHelper
{
	private static int s_processorCount; //Field offset: 0x0
	private static int s_lastProcessorCountRefreshTicks; //Field offset: 0x4
	internal static readonly bool IsSingleProcessor; //Field offset: 0x8

	internal static int ProcessorCount
	{
		[CalledBy(Type = typeof(PlatformHelper), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CancellationTokenSource), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "get_DefaultConcurrencyLevel", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "EnterMyLockSpin", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Environment), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 4)]
		internal get { } //Length: 262
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private static PlatformHelper() { }

	[CalledBy(Type = typeof(PlatformHelper), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "get_DefaultConcurrencyLevel", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Environment), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	internal static int get_ProcessorCount() { }

}

