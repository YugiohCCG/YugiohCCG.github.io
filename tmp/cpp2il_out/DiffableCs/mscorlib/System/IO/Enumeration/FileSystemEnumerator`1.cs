namespace System.IO.Enumeration;

public abstract class FileSystemEnumerator : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator
{
	private readonly string _originalRootDirectory; //Field offset: 0x0
	private readonly string _rootDirectory; //Field offset: 0x0
	private readonly EnumerationOptions _options; //Field offset: 0x0
	private readonly object _lock; //Field offset: 0x0
	private FILE_FULL_DIR_INFORMATION* _entry; //Field offset: 0x0
	private TResult _current; //Field offset: 0x0
	private IntPtr _buffer; //Field offset: 0x0
	private int _bufferLength; //Field offset: 0x0
	private IntPtr _directoryHandle; //Field offset: 0x0
	private string _currentPath; //Field offset: 0x0
	private bool _lastEntryFound; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Handle", "Path"})]
	private Queue<ValueTuple`2<IntPtr, String>> _pending; //Field offset: 0x0

	public override TResult Current
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerable`1+DelegateEnumerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Enumeration.FileSystemEnumerable`1<TResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "CreateDirectoryHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(DisableMediaInsertionPrompt), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public FileSystemEnumerator`1(string directory, EnumerationOptions options = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel32), Member = "CloseHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void CloseDirectoryHandle() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool ContinueOnDirectoryError(int error, bool ignoreNotFound) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected override bool ContinueOnError(int error) { }

	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "CreateRelativeDirectoryHandleUWP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystem), Member = "UnityCreateFile_IntPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FileShare), typeof(FileMode), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NtDll), Member = "CreateFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(IntPtr), typeof(CreateDisposition), typeof(DesiredAccess), typeof(FileShare), typeof(FileAttributes), typeof(CreateOptions), typeof(ObjectAttributes)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.IntPtr>))]
	[Calls(Type = typeof(NtDll), Member = "RtlNtStatusToDosError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private IntPtr CreateRelativeDirectoryHandle(ReadOnlySpan<Char> relativePath, string fullPath) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "CreateDirectoryHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[DeduplicatedMethod]
	private IntPtr CreateRelativeDirectoryHandleUWP(ReadOnlySpan<Char> relativePath, string fullPath) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.ValueTuple`2<System.IntPtr, System.Object>>), Member = "Dequeue", ReturnType = typeof(System.ValueTuple`2<System.IntPtr, System.Object>))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool DequeueNextDirectory() { }

	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "FindNextEntry", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Kernel32), Member = "CloseHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.ValueTuple`2<System.IntPtr, System.Object>>), Member = "Dequeue", ReturnType = typeof(System.ValueTuple`2<System.IntPtr, System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void DirectoryFinished() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "InternalDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "InternalDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "GetNextInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FILE_FULL_DIR_INFORMATION*)}, ReturnType = typeof(FILE_FULL_DIR_INFORMATION*))]
	[Calls(Type = typeof(NtDll), Member = "NtQueryDirectoryFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IO_STATUS_BLOCK&), typeof(IntPtr), typeof(uint), typeof(FILE_INFORMATION_CLASS), typeof(BOOLEAN), typeof(UNICODE_STRING*), typeof(BOOLEAN)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NtDll), Member = "RtlNtStatusToDosError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "DirectoryFinished", ReturnType = typeof(void))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void FindNextEntry() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public override TResult get_Current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NtDll), Member = "NtQueryDirectoryFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IO_STATUS_BLOCK&), typeof(IntPtr), typeof(uint), typeof(FILE_INFORMATION_CLASS), typeof(BOOLEAN), typeof(UNICODE_STRING*), typeof(BOOLEAN)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NtDll), Member = "RtlNtStatusToDosError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private bool GetData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel32), Member = "GetFileInformationByHandleEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FILE_INFO_BY_HANDLE_CLASS), typeof(IntPtr), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private bool GetDataUWP() { }

	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Kernel32), Member = "CloseHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.ValueTuple`2<System.IntPtr, System.Object>>), Member = "Dequeue", ReturnType = typeof(System.ValueTuple`2<System.IntPtr, System.Object>))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void InternalDispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemEntry), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&), typeof(FILE_FULL_DIR_INFORMATION*), typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "GetNextInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FILE_FULL_DIR_INFORMATION*)}, ReturnType = typeof(FILE_FULL_DIR_INFORMATION*))]
	[Calls(Type = typeof(NtDll), Member = "NtQueryDirectoryFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IO_STATUS_BLOCK&), typeof(IntPtr), typeof(uint), typeof(FILE_INFORMATION_CLASS), typeof(BOOLEAN), typeof(UNICODE_STRING*), typeof(BOOLEAN)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NtDll), Member = "RtlNtStatusToDosError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "DirectoryFinished", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NtDll), Member = "CreateFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(IntPtr), typeof(CreateDisposition), typeof(DesiredAccess), typeof(FileShare), typeof(FileAttributes), typeof(CreateOptions), typeof(ObjectAttributes)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.IntPtr>))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.ValueTuple`2<System.IntPtr, System.Object>>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.IntPtr, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Kernel32), Member = "CloseHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	public override bool MoveNext() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnDirectoryFinished(ReadOnlySpan<Char> directory) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void Reset() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected override bool ShouldIncludeEntry(ref FileSystemEntry entry) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	private override object System.Collections.IEnumerator.get_Current() { }

	protected abstract TResult TransformEntry(ref FileSystemEntry entry) { }

}

