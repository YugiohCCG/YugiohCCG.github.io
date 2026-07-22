namespace Mono.Btls;

[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class MonoBtlsSelectCallback : MulticastDelegate
{

	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public MonoBtlsSelectCallback(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int Invoke(String[] acceptableIssuers) { }

}

