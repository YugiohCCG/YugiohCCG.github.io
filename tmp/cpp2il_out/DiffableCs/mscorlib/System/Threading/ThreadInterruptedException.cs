namespace System.Threading;

[ComVisible(True)]
public class ThreadInterruptedException : SystemException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "GetMessageFromNativeResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionMessageKind)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public ThreadInterruptedException() { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ThreadInterruptedException(SerializationInfo info, StreamingContext context) { }

}

