namespace UnityEngine;

[NativeHeader("Runtime/Mono/Coroutine.h")]
[RequiredByNativeCode]
public sealed class Coroutine : YieldInstruction
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(Coroutine coroutine) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x10

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private Coroutine() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Coroutine::CleanupCoroutineGC", True)]
	private static void ReleaseCoroutine(IntPtr ptr) { }

}

