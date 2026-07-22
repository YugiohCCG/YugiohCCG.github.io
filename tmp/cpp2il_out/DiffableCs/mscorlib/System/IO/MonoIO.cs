namespace System.IO;

internal static class MonoIO
{
	public static readonly IntPtr InvalidHandle; //Field offset: 0x0
	private static bool dump_handles; //Field offset: 0x8

	public static char AltDirectorySeparatorChar
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public static IntPtr ConsoleError
	{
		[CalledBy(Type = typeof(Console), Member = "OpenStandardError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public static IntPtr ConsoleInput
	{
		[CalledBy(Type = typeof(Console), Member = "OpenStandardInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public static IntPtr ConsoleOutput
	{
		[CalledBy(Type = typeof(Console), Member = "OpenStandardOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public static char DirectorySeparatorChar
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public static char PathSeparator
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public static char VolumeSeparatorChar
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static MonoIO() { }

	[CalledBy(Type = "System.Diagnostics.AsyncStreamReader", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal static bool Cancel(SafeHandle safeHandle, out MonoIOError error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool Cancel_internal(IntPtr handle, out MonoIOError error) { }

	[CalledBy(Type = typeof(SafeFileHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool CreatePipe(out IntPtr read_handle, out IntPtr write_handle, out MonoIOError error) { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static void DumpHandles() { }

	[CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HandleRef), typeof(HandleRef), typeof(HandleRef), "Microsoft.Win32.SafeHandles.SafeProcessHandle&", typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	[CalledBy(Type = typeof(SafeFindHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool FindCloseFile(IntPtr hnd) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static char get_AltDirectorySeparatorChar() { }

	[CalledBy(Type = typeof(Console), Member = "OpenStandardError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr get_ConsoleError() { }

	[CalledBy(Type = typeof(Console), Member = "OpenStandardInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr get_ConsoleInput() { }

	[CalledBy(Type = typeof(Console), Member = "OpenStandardOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr get_ConsoleOutput() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static char get_DirectorySeparatorChar() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static char get_PathSeparator() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static char get_VolumeSeparatorChar() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetCurrentDirectory(out MonoIOError error) { }

	[CalledBy(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
	[CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HandleRef), typeof(HandleRef), typeof(HandleRef), "Microsoft.Win32.SafeHandles.SafeProcessHandle&", typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Exception GetException(MonoIOError error) { }

	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFileHandle), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PathTooLongException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DirectoryNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 4)]
	public static Exception GetException(string path, MonoIOError error) { }

	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFileHandle), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	[CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IntPtr Open(Char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	[CalledBy(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static int Read(SafeHandle safeHandle, Byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int Read(IntPtr handle, Byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RemapPath(string path, out string newPath) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	[CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFileHandle), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	[CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	[CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static int Write(SafeHandle safeHandle, Byte[] src, int src_offset, int count, out MonoIOError error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int Write(IntPtr handle, in Byte[] src, int src_offset, int count, out MonoIOError error) { }

}

