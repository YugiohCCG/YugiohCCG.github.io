namespace System.Threading;

public class AbandonedMutexException : SystemException
{
	private int _mutexIndex; //Field offset: 0x90
	private Mutex _mutex; //Field offset: 0x98

	[CalledBy(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public AbandonedMutexException() { }

	[CalledBy(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(WaitHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public AbandonedMutexException(int location, WaitHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected AbandonedMutexException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void SetupException(int location, WaitHandle handle) { }

}

