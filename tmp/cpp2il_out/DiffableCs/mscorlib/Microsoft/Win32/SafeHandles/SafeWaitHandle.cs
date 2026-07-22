namespace Microsoft.Win32.SafeHandles;

public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeEventCalls), Member = "CloseEvent_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	protected virtual bool ReleaseHandle() { }

}

