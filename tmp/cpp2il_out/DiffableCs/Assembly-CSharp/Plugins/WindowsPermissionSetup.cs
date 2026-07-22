namespace Plugins;

public static class WindowsPermissionSetup
{
	[CompilerGenerated]
	private struct <HandleLackOfPermissions>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private string <perms>5__2; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter<FileInfo> <>u__2; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WindowsPermissionSetup), Member = "LaunchAsAdmin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Updater), Member = "get_TempZipPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Updater), Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
		[Calls(Type = typeof(Updater), Member = "DownloadUpdaterToTemp", ReturnType = typeof(System.Threading.Tasks.Task`1<System.IO.FileInfo>))]
		[Calls(Type = typeof(Updater), Member = "DetermineDownloadLink", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Updater), Member = "get_RequiresUpdaterUpdate", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "get_UpdaterFile", ReturnType = typeof(FileSystemInfo))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public static FileInfo UpdaterTempFile
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncFlowControl), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
		[Calls(Type = typeof(ExecutionContext), Member = "SuppressFlow", ReturnType = typeof(AsyncFlowControl))]
		[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Awaitable), Member = "AttachManagedGCHandleToNativeAwaitable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(UIntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "Quit", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Updater), Member = "get_TempZipPath", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 17)]
		 get { } //Length: 2566
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Updater), Member = "get_TempZipPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "Quit", ReturnType = typeof(void))]
	[Calls(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Awaitable), Member = "AttachManagedGCHandleToNativeAwaitable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(UIntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecutionContext), Member = "SuppressFlow", ReturnType = typeof(AsyncFlowControl))]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncFlowControl), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	public static FileInfo get_UpdaterTempFile() { }

	[AsyncStateMachine(typeof(<HandleLackOfPermissions>d__3))]
	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleLackOfPermissions>d__3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleLackOfPermissions>d__3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<Boolean> HandleLackOfPermissions() { }

	[CalledBy(Type = typeof(<HandleLackOfPermissions>d__3), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileInfo), Member = "get_Directory", ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static bool LaunchAsAdmin(FileInfo fi, string args) { }

}

