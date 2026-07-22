namespace Microsoft.Win32.SafeHandles;

public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeProcessHandle InvalidHandle; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SafeProcessHandle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	internal SafeProcessHandle(IntPtr handle) { }

	[CalledBy(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual bool ReleaseHandle() { }

}

