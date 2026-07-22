//Type is in global namespace

internal static class Interop
{
	public class Advapi32
	{

		[CalledBy(Type = typeof(RegistryKey), Member = "ClosePerfDataKey", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RegistryKey), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SafeRegistryHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		internal static int RegCloseKey(IntPtr hKey) { }

		[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNamesCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal static int RegEnumKeyEx(SafeRegistryHandle hKey, int dwIndex, Char[] lpName, ref int lpcbName, Int32[] lpReserved, out StringBuilder lpClass, Int32[] lpcbClass, Int64[] lpftLastWriteTime) { }

		[CalledBy(Type = typeof(RegistryKey), Member = "InternalOpenSubKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(RegistryKey))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal static int RegOpenKeyEx(SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out SafeRegistryHandle hkResult) { }

		[CalledBy(Type = typeof(RegistryKey), Member = "InternalSubKeyCountCore", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalSubKeyCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(RegistryKey), Member = "GetSubKeyNames", ReturnType = typeof(String[]))]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNames", ReturnType = typeof(String[]))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal static int RegQueryInfoKey(SafeRegistryHandle hKey, out StringBuilder lpClass, Int32[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, Int32[] lpcbMaxSubKeyLen, Int32[] lpcbMaxClassLen, ref int lpcValues, Int32[] lpcbMaxValueNameLen, Int32[] lpcbMaxValueLen, Int32[] lpcbSecurityDescriptor, Int32[] lpftLastWriteTime) { }

		[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, out Byte[] lpData, ref int lpcbData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, ref int lpData, ref int lpcbData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, ref long lpData, ref int lpcbData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, out Char[] lpData, ref int lpcbData) { }

	}

	public class BCrypt
	{
		public enum NTSTATUS
		{
			STATUS_SUCCESS = 0,
			STATUS_NOT_FOUND = 3221226021,
			STATUS_INVALID_PARAMETER = 3221225485,
			STATUS_NO_MEMORY = 3221225495,
		}


		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal static NTSTATUS BCryptGenRandom(IntPtr hAlgorithm, Byte* pbBuffer, int cbBuffer, int dwFlags) { }

	}

	public enum BOOL
	{
		FALSE = 0,
		TRUE = 1,
	}

	public enum BOOLEAN
	{
		FALSE = 0,
		TRUE = 1,
	}

	public static class Kernel32
	{
		public struct COPYFILE2_EXTENDED_PARAMETERS
		{
			internal uint dwSize; //Field offset: 0x0
			internal uint dwCopyFlags; //Field offset: 0x4
			internal IntPtr pfCancel; //Field offset: 0x8
			internal IntPtr pProgressRoutine; //Field offset: 0x10
			internal IntPtr pvCallbackContext; //Field offset: 0x18

		}

		public struct FILE_BASIC_INFO
		{
			internal long CreationTime; //Field offset: 0x0
			internal long LastAccessTime; //Field offset: 0x8
			internal long LastWriteTime; //Field offset: 0x10
			internal long ChangeTime; //Field offset: 0x18
			internal uint FileAttributes; //Field offset: 0x20

		}

		public enum FILE_INFO_BY_HANDLE_CLASS
		{
			FileBasicInfo = 0,
			FileStandardInfo = 1,
			FileNameInfo = 2,
			FileRenameInfo = 3,
			FileDispositionInfo = 4,
			FileAllocationInfo = 5,
			FileEndOfFileInfo = 6,
			FileStreamInfo = 7,
			FileCompressionInfo = 8,
			FileAttributeTagInfo = 9,
			FileIdBothDirectoryInfo = 10,
			FileIdBothDirectoryRestartInfo = 11,
			FileIoPriorityHintInfo = 12,
			FileRemoteProtocolInfo = 13,
			FileFullDirectoryInfo = 14,
			FileFullDirectoryRestartInfo = 15,
		}

		public struct FILE_TIME
		{
			internal uint dwLowDateTime; //Field offset: 0x0
			internal uint dwHighDateTime; //Field offset: 0x4

			[CalledBy(Type = typeof(FileSystem), Member = "GetLastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
			[CalledBy(Type = typeof(FileSystemInfo), Member = "get_CreationTimeCore", ReturnType = typeof(DateTimeOffset))]
			[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTimeCore", ReturnType = typeof(DateTimeOffset))]
			[CalledBy(Type = typeof(FileSystemInfo), Member = "get_CreationTimeUtc", ReturnType = typeof(DateTime))]
			[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTime", ReturnType = typeof(DateTime))]
			[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTimeUtc", ReturnType = typeof(DateTime))]
			[CallerCount(Count = 6)]
			[Calls(Type = typeof(DateTimeOffset), Member = "FromFileTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTimeOffset))]
			internal DateTimeOffset ToDateTimeOffset() { }

			[CallerCount(Count = 0)]
			internal long ToTicks() { }

		}

		public enum FINDEX_INFO_LEVELS
		{
			FindExInfoStandard = 0,
			FindExInfoBasic = 1,
			FindExInfoMaxInfoLevel = 2,
		}

		public enum FINDEX_SEARCH_OPS
		{
			FindExSearchNameMatch = 0,
			FindExSearchLimitToDirectories = 1,
			FindExSearchLimitToDevices = 2,
			FindExSearchMaxSearchOp = 3,
		}

		public enum GET_FILEEX_INFO_LEVELS
		{
			GetFileExInfoStandard = 0,
			GetFileExMaxInfoLevel = 1,
		}

		public struct REG_TZI_FORMAT
		{
			internal int Bias; //Field offset: 0x0
			internal int StandardBias; //Field offset: 0x4
			internal int DaylightBias; //Field offset: 0x8
			internal SYSTEMTIME StandardDate; //Field offset: 0xC
			internal SYSTEMTIME DaylightDate; //Field offset: 0x1C

			[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			internal REG_TZI_FORMAT(in TIME_ZONE_INFORMATION tzi) { }

		}

		public struct SECURITY_ATTRIBUTES
		{
			internal uint nLength; //Field offset: 0x0
			internal IntPtr lpSecurityDescriptor; //Field offset: 0x8
			internal BOOL bInheritHandle; //Field offset: 0x10

		}

		public struct SYSTEMTIME
		{
			internal ushort Year; //Field offset: 0x0
			internal ushort Month; //Field offset: 0x2
			internal ushort DayOfWeek; //Field offset: 0x4
			internal ushort Day; //Field offset: 0x6
			internal ushort Hour; //Field offset: 0x8
			internal ushort Minute; //Field offset: 0xA
			internal ushort Second; //Field offset: 0xC
			internal ushort Milliseconds; //Field offset: 0xE

			[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckDaylightSavingTimeNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCompareStandardDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(REG_TZI_FORMAT&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCompareTimeZoneInformationToRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 5)]
			[ContainsUnimplementedInstructions]
			internal bool Equals(in SYSTEMTIME other) { }

		}

		public struct TIME_DYNAMIC_ZONE_INFORMATION
		{
			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <DaylightName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <StandardName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <TimeZoneKeyName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			internal int Bias; //Field offset: 0x0
			[FixedBuffer(typeof(char), 32)]
			internal <StandardName>e__FixedBuffer StandardName; //Field offset: 0x4
			internal SYSTEMTIME StandardDate; //Field offset: 0x44
			internal int StandardBias; //Field offset: 0x54
			[FixedBuffer(typeof(char), 32)]
			internal <DaylightName>e__FixedBuffer DaylightName; //Field offset: 0x58
			internal SYSTEMTIME DaylightDate; //Field offset: 0x98
			internal int DaylightBias; //Field offset: 0xA8
			[FixedBuffer(typeof(char), 128)]
			internal <TimeZoneKeyName>e__FixedBuffer TimeZoneKeyName; //Field offset: 0xAC
			internal byte DynamicDaylightTimeDisabled; //Field offset: 0x1AC

			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeZoneInfo))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*)}, ReturnType = typeof(string))]
			internal string GetTimeZoneKeyName() { }

		}

		public struct TIME_ZONE_INFORMATION
		{
			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <DaylightName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <StandardName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			internal int Bias; //Field offset: 0x0
			[FixedBuffer(typeof(char), 32)]
			internal <StandardName>e__FixedBuffer StandardName; //Field offset: 0x4
			internal SYSTEMTIME StandardDate; //Field offset: 0x44
			internal int StandardBias; //Field offset: 0x54
			[FixedBuffer(typeof(char), 32)]
			internal <DaylightName>e__FixedBuffer DaylightName; //Field offset: 0x58
			internal SYSTEMTIME DaylightDate; //Field offset: 0x98
			internal int DaylightBias; //Field offset: 0xA8

			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeZoneInfo))]
			[CallerCount(Count = 1)]
			internal TIME_ZONE_INFORMATION(in TIME_DYNAMIC_ZONE_INFORMATION dtzi) { }

			[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*)}, ReturnType = typeof(string))]
			internal string GetDaylightName() { }

			[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCompareTimeZoneInformationToRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*)}, ReturnType = typeof(string))]
			internal string GetStandardName() { }

		}

		public struct WIN32_FILE_ATTRIBUTE_DATA
		{
			internal int dwFileAttributes; //Field offset: 0x0
			internal FILE_TIME ftCreationTime; //Field offset: 0x4
			internal FILE_TIME ftLastAccessTime; //Field offset: 0xC
			internal FILE_TIME ftLastWriteTime; //Field offset: 0x14
			internal uint nFileSizeHigh; //Field offset: 0x1C
			internal uint nFileSizeLow; //Field offset: 0x20

			[CalledBy(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
			[CallerCount(Count = 1)]
			internal void PopulateFrom(ref WIN32_FIND_DATA findData) { }

		}

		public struct WIN32_FIND_DATA
		{
			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <_cAlternateFileName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <_cFileName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			internal uint dwFileAttributes; //Field offset: 0x0
			internal FILE_TIME ftCreationTime; //Field offset: 0x4
			internal FILE_TIME ftLastAccessTime; //Field offset: 0xC
			internal FILE_TIME ftLastWriteTime; //Field offset: 0x14
			internal uint nFileSizeHigh; //Field offset: 0x1C
			internal uint nFileSizeLow; //Field offset: 0x20
			internal uint dwReserved0; //Field offset: 0x24
			internal uint dwReserved1; //Field offset: 0x28
			[FixedBuffer(typeof(char), 260)]
			private <_cFileName>e__FixedBuffer _cFileName; //Field offset: 0x2C
			[FixedBuffer(typeof(char), 14)]
			private <_cAlternateFileName>e__FixedBuffer _cAlternateFileName; //Field offset: 0x234

			internal ReadOnlySpan<Char> cFileName
			{
				[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
				[CallerCount(Count = 4)]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 4)]
				internal get { } //Length: 230
			}

			[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 4)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			internal ReadOnlySpan<Char> get_cFileName() { }

			[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(FileSystem), Member = "UnityFindFirstFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(SafeFindHandle))]
			[CalledBy(Type = typeof(FileSystem), Member = "UnityFindNextFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFindHandle), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
			[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			internal void SetFileName(string fileName) { }

		}

		private static bool useUWPFallback; //Field offset: 0x0

		[CalledBy(Type = typeof(Kernel32), Member = "CreateFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FileShare), typeof(FileMode), typeof(int)}, ReturnType = typeof(SafeFileHandle))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "CloseDirectoryHandle", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "InternalDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "DirectoryFinished", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool CloseHandle(IntPtr handle) { }

		[CalledBy(Type = typeof(FileSystem), Member = "CopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityCopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[Calls(Type = typeof(Kernel32), Member = "CopyFileUWP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 4)]
		internal static int CopyFile(string src, string dst, bool failIfExists) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal static int CopyFile2(string pwszExistingFileName, string pwszNewFileName, ref COPYFILE2_EXTENDED_PARAMETERS pExtendedParameters) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool CopyFileEx(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private static bool CopyFileExPrivate(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags) { }

		[CalledBy(Type = typeof(Kernel32), Member = "CopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Win32Marshal), Member = "TryMakeWin32ErrorCodeFromHR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal static int CopyFileUWP(string src, string dst, bool failIfExists) { }

		[CalledBy(Type = typeof(FileSystem), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityCreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool CreateDirectory(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private static bool CreateDirectoryPrivate(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes) { }

		[CalledBy(Type = typeof(FileSystem), Member = "CopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystem), Member = "OpenHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(SafeFileHandle))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Kernel32), Member = "CloseHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal static SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

		[CalledBy(Type = typeof(FileSystem), Member = "UnityCreateFile_IntPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FileShare), typeof(FileMode), typeof(int)}, ReturnType = typeof(IntPtr))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		internal static IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private static IntPtr CreateFilePrivate(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES* securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile) { }

		[CalledBy(Type = typeof(FileSystem), Member = "UnityDeleteFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool DeleteFile(string path) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private static bool DeleteFilePrivate(string path) { }

		[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		internal static bool DeleteVolumeMountPoint(string mountPoint) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool DeleteVolumeMountPointPrivate(string mountPoint) { }

		[CalledBy(Type = typeof(FileSystem), Member = "UnityFindFirstFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(SafeFindHandle))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal static SafeFindHandle FindFirstFile(string fileName, ref WIN32_FIND_DATA data) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private static SafeFindHandle FindFirstFileExPrivate(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, ref WIN32_FIND_DATA lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, int dwAdditionalFlags) { }

		[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityFindNextFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFindHandle), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool FindNextFile(SafeFindHandle hndFindFile, ref WIN32_FIND_DATA lpFindFileData) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private static int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, Char* lpBuffer, int nSize, IntPtr[] arguments) { }

		[CalledBy(Type = typeof(SafeLibraryHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool FreeLibrary(IntPtr hModule) { }

		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeZoneInfo))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal static uint GetDynamicTimeZoneInformation(out TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation) { }

		[CalledBy(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityGetFileAttributesEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool GetFileAttributesEx(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private static bool GetFileAttributesExPrivate(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }

		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "GetDataUWP", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		public static bool GetFileInformationByHandleEx(IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, IntPtr lpFileInformation, uint dwBufferSize) { }

		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		internal static bool GetFileMUIPath(uint flags, string filePath, out StringBuilder language, ref int languageLength, out StringBuilder fileMuiPath, ref int fileMuiPathLength, ref long enumerator) { }

		[CalledBy(Type = typeof(DriveInfoInternal), Member = "GetLogicalDrives", ReturnType = typeof(String[]))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal static int GetLogicalDrives() { }

		[CalledBy(Type = typeof(Kernel32), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Kernel32), Member = "TryGetErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(System.Span`1<System.Char>), typeof(String&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal static string GetMessage(IntPtr moduleHandle, int errorCode) { }

		[CalledBy(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = typeof(Win32Marshal), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Kernel32), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		internal static string GetMessage(int errorCode) { }

		[CalledBy(Type = "System.TimeZoneInfo+CachedData", Member = "GetCurrentOneYearLocal", ReturnType = typeof(TimeZoneInfo))]
		[CalledBy(Type = "System.TimeZoneInfo+CachedData", Member = "GetOneYearLocalFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.TimeZoneInfo+OffsetAndRule")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		internal static uint GetTimeZoneInformation(out TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal static SafeLibraryHandle LoadLibraryEx(string libFilename, IntPtr reserved, int flags) { }

		[CalledBy(Type = typeof(FileSystem), Member = "UnityMoveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool MoveFile(string src, string dst) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private static bool MoveFileExPrivate(string src, string dst, uint flags) { }

		[CalledBy(Type = typeof(FileSystem), Member = "UnityRemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool RemoveDirectory(string path) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private static bool RemoveDirectoryPrivate(string path) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool SetFileInformationByHandle(SafeFileHandle hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, ref FILE_BASIC_INFO lpFileInformation, uint dwBufferSize) { }

		[CalledBy(Type = typeof(FileSystem), Member = "SetLastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeOffset), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool SetFileTime(SafeFileHandle hFile, long creationTime = -1, long lastAccessTime = -1, long lastWriteTime = -1, long changeTime = -1, uint fileAttributes = 0) { }

		[CalledBy(Type = typeof(DisableMediaInsertionPrompt), Member = "Create", ReturnType = typeof(DisableMediaInsertionPrompt))]
		[CalledBy(Type = typeof(DisableMediaInsertionPrompt), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal static bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode) { }

		[CalledBy(Type = typeof(Kernel32), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Span`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		private static bool TryGetErrorMessage(IntPtr moduleHandle, int errorCode, Span<Char> buffer, out string errorMsg) { }

	}

	public struct LongFileTime
	{
		internal long TicksSince1601; //Field offset: 0x0

	}

	public class NtDll
	{
		internal enum CreateDisposition
		{
			FILE_SUPERSEDE = 0,
			FILE_OPEN = 1,
			FILE_CREATE = 2,
			FILE_OPEN_IF = 3,
			FILE_OVERWRITE = 4,
			FILE_OVERWRITE_IF = 5,
		}

		internal enum CreateOptions
		{
			FILE_DIRECTORY_FILE = 1,
			FILE_WRITE_THROUGH = 2,
			FILE_SEQUENTIAL_ONLY = 4,
			FILE_NO_INTERMEDIATE_BUFFERING = 8,
			FILE_SYNCHRONOUS_IO_ALERT = 16,
			FILE_SYNCHRONOUS_IO_NONALERT = 32,
			FILE_NON_DIRECTORY_FILE = 64,
			FILE_CREATE_TREE_CONNECTION = 128,
			FILE_COMPLETE_IF_OPLOCKED = 256,
			FILE_NO_EA_KNOWLEDGE = 512,
			FILE_RANDOM_ACCESS = 2048,
			FILE_DELETE_ON_CLOSE = 4096,
			FILE_OPEN_BY_FILE_ID = 8192,
			FILE_OPEN_FOR_BACKUP_INTENT = 16384,
			FILE_NO_COMPRESSION = 32768,
			FILE_OPEN_REQUIRING_OPLOCK = 65536,
			FILE_DISALLOW_EXCLUSIVE = 131072,
			FILE_SESSION_AWARE = 262144,
			FILE_RESERVE_OPFILTER = 1048576,
			FILE_OPEN_REPARSE_POINT = 2097152,
			FILE_OPEN_NO_RECALL = 4194304,
		}

		[Flags]
		internal enum DesiredAccess
		{
			FILE_READ_DATA = 1,
			FILE_LIST_DIRECTORY = 1,
			FILE_WRITE_DATA = 2,
			FILE_ADD_FILE = 2,
			FILE_APPEND_DATA = 4,
			FILE_ADD_SUBDIRECTORY = 4,
			FILE_CREATE_PIPE_INSTANCE = 4,
			FILE_READ_EA = 8,
			FILE_WRITE_EA = 16,
			FILE_EXECUTE = 32,
			FILE_TRAVERSE = 32,
			FILE_DELETE_CHILD = 64,
			FILE_READ_ATTRIBUTES = 128,
			FILE_WRITE_ATTRIBUTES = 256,
			FILE_ALL_ACCESS = 983551,
			DELETE = 65536,
			READ_CONTROL = 131072,
			WRITE_DAC = 262144,
			WRITE_OWNER = 524288,
			SYNCHRONIZE = 1048576,
			STANDARD_RIGHTS_READ = 131072,
			STANDARD_RIGHTS_WRITE = 131072,
			STANDARD_RIGHTS_EXECUTE = 131072,
			FILE_GENERIC_READ = 2147483648,
			FILE_GENERIC_WRITE = 1073741824,
			FILE_GENERIC_EXECUTE = 536870912,
		}

		internal struct FILE_FULL_DIR_INFORMATION
		{
			public uint NextEntryOffset; //Field offset: 0x0
			public uint FileIndex; //Field offset: 0x4
			public LongFileTime CreationTime; //Field offset: 0x8
			public LongFileTime LastAccessTime; //Field offset: 0x10
			public LongFileTime LastWriteTime; //Field offset: 0x18
			public LongFileTime ChangeTime; //Field offset: 0x20
			public long EndOfFile; //Field offset: 0x28
			public long AllocationSize; //Field offset: 0x30
			public FileAttributes FileAttributes; //Field offset: 0x38
			public uint FileNameLength; //Field offset: 0x3C
			public uint EaSize; //Field offset: 0x40
			private char _fileName; //Field offset: 0x44

			public ReadOnlySpan<Char> FileName
			{
				[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
				[CalledBy(Type = typeof(FileSystemEntry), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
				[CalledBy(Type = typeof(FileSystemEntry), Member = "ToFileSystemInfo", ReturnType = typeof(FileSystemInfo))]
				[CalledBy(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass3_0", Member = "<UserFiles>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass4_0", Member = "<UserDirectories>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0", Member = "<UserEntries>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass6_0", Member = "<FileInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass7_0", Member = "<DirectoryInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass8_0", Member = "<FileSystemInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CallerCount(Count = 15)]
				[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
				 get { } //Length: 103
			}

			[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(FileSystemEntry), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
			[CalledBy(Type = typeof(FileSystemEntry), Member = "ToFileSystemInfo", ReturnType = typeof(FileSystemInfo))]
			[CalledBy(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass3_0", Member = "<UserFiles>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass4_0", Member = "<UserDirectories>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0", Member = "<UserEntries>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass6_0", Member = "<FileInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass7_0", Member = "<DirectoryInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass8_0", Member = "<FileSystemInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 15)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			public ReadOnlySpan<Char> get_FileName() { }

			[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "FindNextEntry", ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			public static FILE_FULL_DIR_INFORMATION* GetNextInfo(FILE_FULL_DIR_INFORMATION* info) { }

		}

		internal enum FILE_INFORMATION_CLASS
		{
			FileDirectoryInformation = 1,
			FileFullDirectoryInformation = 2,
			FileBothDirectoryInformation = 3,
			FileBasicInformation = 4,
			FileStandardInformation = 5,
			FileInternalInformation = 6,
			FileEaInformation = 7,
			FileAccessInformation = 8,
			FileNameInformation = 9,
			FileRenameInformation = 10,
			FileLinkInformation = 11,
			FileNamesInformation = 12,
			FileDispositionInformation = 13,
			FilePositionInformation = 14,
			FileFullEaInformation = 15,
			FileModeInformation = 16,
			FileAlignmentInformation = 17,
			FileAllInformation = 18,
			FileAllocationInformation = 19,
			FileEndOfFileInformation = 20,
			FileAlternateNameInformation = 21,
			FileStreamInformation = 22,
			FilePipeInformation = 23,
			FilePipeLocalInformation = 24,
			FilePipeRemoteInformation = 25,
			FileMailslotQueryInformation = 26,
			FileMailslotSetInformation = 27,
			FileCompressionInformation = 28,
			FileObjectIdInformation = 29,
			FileCompletionInformation = 30,
			FileMoveClusterInformation = 31,
			FileQuotaInformation = 32,
			FileReparsePointInformation = 33,
			FileNetworkOpenInformation = 34,
			FileAttributeTagInformation = 35,
			FileTrackingInformation = 36,
			FileIdBothDirectoryInformation = 37,
			FileIdFullDirectoryInformation = 38,
			FileValidDataLengthInformation = 39,
			FileShortNameInformation = 40,
			FileIoCompletionNotificationInformation = 41,
			FileIoStatusBlockRangeInformation = 42,
			FileIoPriorityHintInformation = 43,
			FileSfioReserveInformation = 44,
			FileSfioVolumeInformation = 45,
			FileHardLinkInformation = 46,
			FileProcessIdsUsingFileInformation = 47,
			FileNormalizedNameInformation = 48,
			FileNetworkPhysicalNameInformation = 49,
			FileIdGlobalTxDirectoryInformation = 50,
			FileIsRemoteDeviceInformation = 51,
			FileUnusedInformation = 52,
			FileNumaNodeInformation = 53,
			FileStandardLinkInformation = 54,
			FileRemoteProtocolInformation = 55,
			FileRenameInformationBypassAccessCheck = 56,
			FileLinkInformationBypassAccessCheck = 57,
			FileVolumeNameInformation = 58,
			FileIdInformation = 59,
			FileIdExtdDirectoryInformation = 60,
			FileReplaceCompletionInformation = 61,
			FileHardLinkFullIdInformation = 62,
			FileIdExtdBothDirectoryInformation = 63,
			FileDispositionInformationEx = 64,
			FileRenameInformationEx = 65,
			FileRenameInformationExBypassAccessCheck = 66,
			FileDesiredStorageClassInformation = 67,
			FileStatInformation = 68,
		}

		internal struct IO_STATUS_BLOCK
		{
			internal struct IO_STATUS
			{
				public uint Status; //Field offset: 0x0
				public IntPtr Pointer; //Field offset: 0x0

			}

			public IO_STATUS Status; //Field offset: 0x0
			public IntPtr Information; //Field offset: 0x8

		}

		internal struct OBJECT_ATTRIBUTES
		{
			public uint Length; //Field offset: 0x0
			public IntPtr RootDirectory; //Field offset: 0x8
			public UNICODE_STRING* ObjectName; //Field offset: 0x10
			public ObjectAttributes Attributes; //Field offset: 0x18
			public Void* SecurityDescriptor; //Field offset: 0x20
			public Void* SecurityQualityOfService; //Field offset: 0x28

			[CallerCount(Count = 0)]
			public OBJECT_ATTRIBUTES(UNICODE_STRING* objectName, ObjectAttributes attributes, IntPtr rootDirectory) { }

		}

		[Flags]
		internal enum ObjectAttributes
		{
			OBJ_INHERIT = 2,
			OBJ_PERMANENT = 16,
			OBJ_EXCLUSIVE = 32,
			OBJ_CASE_INSENSITIVE = 64,
			OBJ_OPENIF = 128,
			OBJ_OPENLINK = 256,
		}


		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "CreateRelativeDirectoryHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string)}, ReturnType = typeof(IntPtr))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 10)]
		internal static ValueTuple<Int32, IntPtr> CreateFile(ReadOnlySpan<Char> path, IntPtr rootDirectory, CreateDisposition createDisposition, DesiredAccess desiredAccess = 2148532224, FileShare shareAccess = 7, FileAttributes fileAttributes = 0, CreateOptions createOptions = 32, ObjectAttributes objectAttributes = 64) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static int NtCreateFile(out IntPtr FileHandle, DesiredAccess DesiredAccess, ref OBJECT_ATTRIBUTES ObjectAttributes, out IO_STATUS_BLOCK IoStatusBlock, Int64* AllocationSize, FileAttributes FileAttributes, FileShare ShareAccess, CreateDisposition CreateDisposition, CreateOptions CreateOptions, Void* EaBuffer, uint EaLength) { }

		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "FindNextEntry", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "GetData", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public static int NtQueryDirectoryFile(IntPtr FileHandle, IntPtr Event, IntPtr ApcRoutine, IntPtr ApcContext, out IO_STATUS_BLOCK IoStatusBlock, IntPtr FileInformation, uint Length, FILE_INFORMATION_CLASS FileInformationClass, BOOLEAN ReturnSingleEntry, UNICODE_STRING* FileName, BOOLEAN RestartScan) { }

		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "FindNextEntry", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "GetData", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "CreateRelativeDirectoryHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string)}, ReturnType = typeof(IntPtr))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		public static uint RtlNtStatusToDosError(int Status) { }

	}

	public struct UNICODE_STRING
	{
		internal ushort Length; //Field offset: 0x0
		internal ushort MaximumLength; //Field offset: 0x2
		internal IntPtr Buffer; //Field offset: 0x8

	}

	public class User32
	{

		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		internal static int LoadString(SafeLibraryHandle handle, int id, out StringBuilder buffer, int bufferLength) { }

	}


	[CalledBy(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[CalledBy(Type = typeof(HashCode), Member = "GenerateGlobalSeed", ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(HashCode), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Random), Member = "GenerateGlobalSeed", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Random), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	internal static void GetRandomBytes(Byte* buffer, int length) { }

}

