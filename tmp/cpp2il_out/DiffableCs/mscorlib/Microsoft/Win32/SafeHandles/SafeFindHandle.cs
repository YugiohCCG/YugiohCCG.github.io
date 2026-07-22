namespace Microsoft.Win32.SafeHandles;

internal class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal SafeFindHandle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoIO), Member = "FindCloseFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	protected virtual bool ReleaseHandle() { }

}

