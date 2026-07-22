namespace Microsoft.Win32;

internal static class NativeMethods
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool CloseProcess(IntPtr handle) { }

	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = "System.IO.MonoIO", Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr&), typeof(int), typeof(int), typeof(int), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "System.IO.MonoIO", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.MonoIOError"}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 5)]
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr GetCurrentProcess() { }

	[CalledBy(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetCurrentProcessId() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

}

