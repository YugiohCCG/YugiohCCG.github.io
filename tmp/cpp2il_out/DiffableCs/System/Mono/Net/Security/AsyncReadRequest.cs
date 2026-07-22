namespace Mono.Net.Security;

internal class AsyncReadRequest : AsyncReadOrWriteRequest
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(bool), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public AsyncReadRequest(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "ProcessRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

