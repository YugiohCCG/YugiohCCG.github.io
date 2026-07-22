namespace UnityEngine.Bindings;

[VisibleToOtherModules]
internal static class ExceptionMarshaller
{
	[ThreadStatic]
	private static Exception s_pendingException; //Field offset: 0x80000000

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	private static void SetPendingException(Exception ex) { }

}

