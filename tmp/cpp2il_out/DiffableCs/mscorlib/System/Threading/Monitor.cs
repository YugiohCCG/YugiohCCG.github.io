namespace System.Threading;

public static class Monitor
{

	[CalledBy(Type = "SQLite.SQLiteConnectionWithLock+LockWrapper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteConnectionWithLock", Member = "Lock", ReturnType = typeof(IDisposable))]
	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LockQueue), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = "TryPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = "TryPop", ReturnType = "T[]")]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+LockedStack", Member = "TryPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+LockedStack", Member = "TryPop", ReturnType = "T[]")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Rent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
	[CalledBy(Type = "System.Xml.Schema.Preprocessor", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchema", typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaSet", Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ThreadSafeStore`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	public static void Enter(object obj) { }

	[CallerCount(Count = 468)]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void Enter(object obj, ref bool lockTaken) { }

	[CallerCount(Count = 1131)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void Exit(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void Monitor_pulse(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void Monitor_pulse_all(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool Monitor_test_synchronised(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool Monitor_wait(object obj, int ms) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void ObjPulse(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void ObjPulseAll(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	[CalledBy(Type = typeof(LockQueue), Member = "Pulse", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static void Pulse(object obj) { }

	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReaderWriterLock), Member = "ReleaseWriterLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLock), Member = "ReleaseWriterLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static void PulseAll(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static void ReliableEnter(object obj, ref bool lockTaken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "CancellationTokenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "CancellationTokenCanceledEventHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Monitor), Member = "TryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void ThrowLockTakenException() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutManager", Member = "TryFreeNodes", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaSet", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaSet"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void TryEnter(object obj, ref bool lockTaken) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public static bool Wait(object obj, int millisecondsTimeout) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

}

