namespace Microsoft.Win32.SafeHandles;

public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoIO), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	protected virtual bool ReleaseHandle() { }

}

