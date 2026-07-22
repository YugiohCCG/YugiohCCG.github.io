namespace System.Threading;

public class LockRecursionException : Exception
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	public LockRecursionException() { }

	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.ReaderWriterLockSlim+TimeoutTracker"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "TryEnterWriteLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.ReaderWriterLockSlim+TimeoutTracker"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "TryEnterUpgradeableReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.ReaderWriterLockSlim+TimeoutTracker"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public LockRecursionException(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	protected LockRecursionException(SerializationInfo info, StreamingContext context) { }

}

