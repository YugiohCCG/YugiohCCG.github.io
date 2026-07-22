namespace Mono.Btls;

[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class MonoBtlsVerifyCallback : MulticastDelegate
{

	[CallerCount(Count = 39)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public MonoBtlsVerifyCallback(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int Invoke(MonoBtlsX509StoreCtx ctx) { }

}

