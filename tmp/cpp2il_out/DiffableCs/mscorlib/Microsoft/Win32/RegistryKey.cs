namespace Microsoft.Win32;

public sealed class RegistryKey : MarshalByRefObject, IDisposable
{
	[Flags]
	private enum StateFlags
	{
		Dirty = 1,
		SystemKey = 2,
		WriteAccess = 4,
		PerfData = 8,
	}

	internal static readonly IntPtr HKEY_CLASSES_ROOT; //Field offset: 0x0
	internal static readonly IntPtr HKEY_CURRENT_USER; //Field offset: 0x8
	internal static readonly IntPtr HKEY_LOCAL_MACHINE; //Field offset: 0x10
	internal static readonly IntPtr HKEY_USERS; //Field offset: 0x18
	internal static readonly IntPtr HKEY_PERFORMANCE_DATA; //Field offset: 0x20
	internal static readonly IntPtr HKEY_CURRENT_CONFIG; //Field offset: 0x28
	internal static readonly IntPtr HKEY_DYN_DATA; //Field offset: 0x30
	private static readonly String[] s_hkeyNames; //Field offset: 0x38
	private SafeRegistryHandle _hkey; //Field offset: 0x18
	private string _keyName; //Field offset: 0x20
	private bool _remoteKey; //Field offset: 0x28
	private StateFlags _state; //Field offset: 0x2C
	private RegistryKeyPermissionCheck _checkMode; //Field offset: 0x30
	private RegistryView _regView; //Field offset: 0x34

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private static RegistryKey() { }

	[CalledBy(Type = typeof(RegistryKey), Member = "OpenBaseKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryHive), typeof(RegistryView)}, ReturnType = typeof(RegistryKey))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalOpenSubKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CalledBy(Type = typeof(RegistryKey), Member = "OpenBaseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryHive), typeof(RegistryView)}, ReturnType = typeof(RegistryKey))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private RegistryKey(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Advapi32), Member = "RegCloseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	private void ClosePerfDataKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Advapi32), Member = "RegCloseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void EnsureNotDisposed() { }

	[CalledBy(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static string FixupName(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void FixupPath(StringBuilder path) { }

	[CallerCount(Count = 0)]
	private static int GetRegistryKeyAccess(bool isWritable) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryInfoKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(StringBuilder), typeof(Int32[]), typeof(IntPtr), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNamesCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public String[] GetSubKeyNames() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneEntryFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryKey), typeof(string), typeof(REG_TZI_FORMAT&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCompareTimeZoneInformationToRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalizedNamesByRegistryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryKey), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = "System.TimeZoneInfo+TimeZoneInfoResult")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public object GetValue(string name, object defaultValue, RegistryValueOptions options) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryInfoKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(StringBuilder), typeof(Int32[]), typeof(IntPtr), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNamesCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private String[] InternalGetSubKeyNames() { }

	[CalledBy(Type = typeof(RegistryKey), Member = "GetSubKeyNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNames", ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Advapi32), Member = "RegEnumKeyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(int), typeof(Char[]), typeof(Int32&), typeof(Int32[]), typeof(StringBuilder), typeof(Int32[]), typeof(Int64[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private String[] InternalGetSubKeyNamesCore(int subkeys) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity) { }

	[CalledBy(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryValueEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(string), typeof(Int32[]), typeof(Int32&), typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand) { }

	[CalledBy(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Advapi32), Member = "RegOpenKeyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(string), typeof(int), typeof(int), typeof(SafeRegistryHandle&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegistryKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(RegistryView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowSecurityException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryInfoKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(StringBuilder), typeof(Int32[]), typeof(IntPtr), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private int InternalSubKeyCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryInfoKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(StringBuilder), typeof(Int32[]), typeof(IntPtr), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private int InternalSubKeyCountCore() { }

	[CalledBy(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsPerfDataKey() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsSystemKey() { }

	[CalledBy(Type = typeof(Registry), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(RegistryView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(RegistryView)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view) { }

	[CalledBy(Type = "System.TimeZoneInfo+<>c", Member = "<.cctor>b__157_0", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZonesFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.TimeZoneInfo+CachedData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "FindIdFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCompareTimeZoneInformationToRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = "System.TimeZoneInfo+TimeZoneInfoResult")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RegistryKey), Member = "ValidateKeyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = "FixupName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegistryKey), Member = "InternalOpenSubKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public RegistryKey OpenSubKey(string name, bool writable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CompareInfo), Member = "IndexOfOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 29)]
	private static void ValidateKeyName(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private static void ValidateKeyView(RegistryView view) { }

	[CalledBy(Type = typeof(RegistryKey), Member = "InternalSubKeyCountCore", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNamesCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalSubKeyCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RegistryKey), Member = "GetSubKeyNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNames", ReturnType = typeof(String[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RegistryKey), Member = "IsPerfDataKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(Kernel32), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private void Win32Error(int errorCode, string str) { }

}

