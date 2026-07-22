namespace System.Threading;

public static class Interlocked
{

	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeList`1+ParallelWriter", Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeList`1+ParallelWriter", Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeList`1+ParallelWriter", Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeList`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32", Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeList`1+ParallelWriter", Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeList`1+ParallelWriter", Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "AllocEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.AllocateBinsPerBatch", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PrefixSumDrawsAndInstances", Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "AtomicAddLengthNoResize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeList`1<T>&", typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int Add(ref int location1, int value) { }

	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter64", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter64", Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static long Add(ref long location1, long value) { }

	[CallerCount(Count = 89)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[CalledBy(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "TryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result) { }

	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	[CalledBy(Type = "UnityEngineInternal.MathfInternal", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ComVisible(False)]
	[Intrinsic]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static T CompareExchange(ref T location1, T value, T comparand) { }

	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "BeginTransaction", ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "SaveTransactionPoint", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.Task+WhenAllPromise`1", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "RemoveConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebConnection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "OnConnectionClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebConnection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "OperationCompleted", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.DeflateManagedStream+<ReadAsyncCore>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.DeflateManagedStream+<WriteAsyncCore>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.DeflateManagedStream", Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CalledBy(Type = "System.Drawing.Size", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int Decrement(ref int location) { }

	[ComVisible(False)]
	[Intrinsic]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static T Exchange(ref T location1, T value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Exchange(ref double location1, double value) { }

	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static long Exchange(ref long location1, long value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Exchange(ref float location1, float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	private static void Exchange(ref object location1, ref object value, ref object result) { }

	[CallerCount(Count = 42)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int Exchange(ref int location1, int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static object Exchange(ref object location1, object value) { }

	[CalledBy(Type = "System.Data.DataCommonEventSource", Member = "EnterScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.LockRecursionPolicy"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static long Increment(ref long location) { }

	[CallerCount(Count = 40)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int Increment(ref int location) { }

	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Segment), Member = "TryPeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Collections.RewindableAllocator", Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Block&", typeof(int), typeof(int), typeof(long), typeof(long)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
	public static void MemoryBarrier() { }

	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 1)]
	public static long Read(ref long location) { }

}

