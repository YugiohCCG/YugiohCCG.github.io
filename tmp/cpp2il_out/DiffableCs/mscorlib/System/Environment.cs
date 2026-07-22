namespace System;

[ComVisible(True)]
public static class Environment
{
	[ComVisible(True)]
	internal enum SpecialFolder
	{
		MyDocuments = 5,
		Desktop = 0,
		MyComputer = 17,
		Programs = 2,
		Personal = 5,
		Favorites = 6,
		Startup = 7,
		Recent = 8,
		SendTo = 9,
		StartMenu = 11,
		MyMusic = 13,
		DesktopDirectory = 16,
		Templates = 21,
		ApplicationData = 26,
		LocalApplicationData = 28,
		InternetCache = 32,
		Cookies = 33,
		History = 34,
		CommonApplicationData = 35,
		System = 37,
		ProgramFiles = 38,
		MyPictures = 39,
		CommonProgramFiles = 43,
		MyVideos = 14,
		NetworkShortcuts = 19,
		Fonts = 20,
		CommonStartMenu = 22,
		CommonPrograms = 23,
		CommonStartup = 24,
		CommonDesktopDirectory = 25,
		PrinterShortcuts = 27,
		Windows = 36,
		UserProfile = 40,
		SystemX86 = 41,
		ProgramFilesX86 = 42,
		CommonProgramFilesX86 = 44,
		CommonTemplates = 45,
		CommonDocuments = 46,
		CommonAdminTools = 47,
		AdminTools = 48,
		CommonMusic = 53,
		CommonPictures = 54,
		CommonVideos = 55,
		Resources = 56,
		LocalizedResources = 57,
		CommonOemLinks = 58,
		CDBurning = 59,
	}

	internal enum SpecialFolderOption
	{
		None = 0,
		DoNotVerify = 16384,
		Create = 32768,
	}

	private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789"; //Field offset: 0x0
	private static string nl; //Field offset: 0x0
	private static OperatingSystem os; //Field offset: 0x8

	public static string CurrentDirectory
	{
		[CalledBy(Type = typeof(Directory), Member = "GetCurrentDirectory", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Path), Member = "WindowsDriveAdjustment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "GetOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.BurstCompileAttribute", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
		 get { } //Length: 7
	}

	public static int CurrentManagedThreadId
	{
		[CallerCount(Count = 332)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 35
	}

	public static bool HasShutdownStarted
	{
		[CalledBy(Type = typeof(Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskExceptionHolder), Member = "Finalize", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public static bool Is64BitOperatingSystem
	{
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal static bool IsRunningOnWindows
	{
		[CalledBy(Type = typeof(Marshal), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Path), Member = "GetInvalidFileNameChars", ReturnType = typeof(Char[]))]
		[CalledBy(Type = typeof(Path), Member = "GetInvalidPathChars", ReturnType = typeof(Char[]))]
		[CalledBy(Type = typeof(Path), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 20
	}

	internal static bool IsUnix
	{
		[CalledBy(Type = typeof(WindowsIdentity), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 39
	}

	public static string MachineName
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static string NewLine
	{
		[CallerCount(Count = 101)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 118
	}

	public static OperatingSystem OSVersion
	{
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "CanSecure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.NetworkInformation.Win32NetworkInterfaceFactoryPal", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
		[CalledBy(Type = "System.Net.NetworkInformation.NetworkInterfaceFactoryPal", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
		[CalledBy(Type = "System.Net.NetworkInformation.SystemNetworkInterface", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "get_IsWindows", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.NetworkInformation.NetworkInterfaceFactory", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "IsMachineProtected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "IsUserProtected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "ProtectMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "ProtectUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(OperatingSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlatformID), typeof(Version)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 679
	}

	internal static PlatformID Platform
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public static int ProcessorCount
	{
		[CalledBy(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ThreadPoolGlobals), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public static string StackTrace
	{
		[CalledBy(Type = "System.Diagnostics.TraceEventCache", Member = "get_Callstack", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Diagnostics.TraceListener", Member = "WriteFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.TraceEventCache"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 100
	}

	public static string SystemDirectory
	{
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 586
	}

	public static int TickCount
	{
		[CallerCount(Count = 49)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public static string UserDomainName
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static string UserName
	{
		[CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type3Message", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	internal static Version CreateVersionFromString(string info) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void Exit(int exitCode) { }

	[CalledBy(Type = "Manager.Customization", Member = "get_LogPath", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CaseInsensitiveHashCodeProvider), Member = "get_Default", ReturnType = typeof(CaseInsensitiveHashCodeProvider))]
	[Calls(Type = typeof(CaseInsensitiveComparer), Member = "get_Default", ReturnType = typeof(CaseInsensitiveComparer))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IHashCodeProvider), typeof(IComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public static string ExpandEnvironmentVariables(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void FailFast(string message, Exception exception, string errorSource) { }

	[CalledBy(Type = typeof(ExecutionContext), Member = "OnAsyncLocalContextChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ExecutionContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void FailFast(string message, Exception exception) { }

	[CalledBy(Type = typeof(Directory), Member = "GetCurrentDirectory", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "WindowsDriveAdjustment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "GetOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.BurstCompileAttribute", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
	public static string get_CurrentDirectory() { }

	[CallerCount(Count = 332)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int get_CurrentManagedThreadId() { }

	[CalledBy(Type = typeof(Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_HasShutdownStarted() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool get_Is64BitOperatingSystem() { }

	[CalledBy(Type = typeof(Marshal), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "GetInvalidFileNameChars", ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Path), Member = "GetInvalidPathChars", ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Path), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool get_IsRunningOnWindows() { }

	[CalledBy(Type = typeof(WindowsIdentity), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool get_IsUnix() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static string get_MachineName() { }

	[CallerCount(Count = 101)]
	[CallsUnknownMethods(Count = 2)]
	public static string get_NewLine() { }

	[CalledBy(Type = typeof(KeyPairPersistence), Member = "CanSecure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "ProtectUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "IsUserProtected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "IsMachineProtected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "ProtectMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "get_IsWindows", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.NetworkInformation.SystemNetworkInterface", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetworkInformation.NetworkInterfaceFactoryPal", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
	[CalledBy(Type = "System.Net.NetworkInformation.Win32NetworkInterfaceFactoryPal", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
	[CalledBy(Type = "System.Net.NetworkInformation.NetworkInterfaceFactory", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OperatingSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlatformID), typeof(Version)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public static OperatingSystem get_OSVersion() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static PlatformID get_Platform() { }

	[CalledBy(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ThreadPoolGlobals), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static int get_ProcessorCount() { }

	[CalledBy(Type = "System.Diagnostics.TraceEventCache", Member = "get_Callstack", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Diagnostics.TraceListener", Member = "WriteFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.TraceEventCache"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string get_StackTrace() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static string get_SystemDirectory() { }

	[CallerCount(Count = 49)]
	[CallsUnknownMethods(Count = 1)]
	public static int get_TickCount() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static string get_UserDomainName() { }

	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type3Message", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string get_UserName() { }

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphGraphicsAutomatedTests", Member = "get_activatedFromCommandLine", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphGraphicsAutomatedTests", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static String[] GetCommandLineArgs() { }

	[CalledBy(Type = "Assets.Scripts.Plugins.Unix.OmegaUnixPlugin+<>c", Member = "<StartProcess>b__1_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MonoIO), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "CreateDefaultProviderImpl", ReturnType = "Mono.Net.Security.MobileTlsProvider")]
	[CalledBy(Type = "System.Uri", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	public static string GetEnvironmentVariable(string variable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static String[] GetEnvironmentVariableNames() { }

	[CalledBy(Type = "Assets.Scripts.Plugins.Unix.OmegaUnixPlugin", Member = "StartProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.ProcessStartInfo", Member = "get_EnvironmentVariables", ReturnType = "System.Collections.Specialized.StringDictionary")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static IDictionary GetEnvironmentVariables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CaseInsensitiveHashCodeProvider), Member = "get_Default", ReturnType = typeof(CaseInsensitiveHashCodeProvider))]
	[Calls(Type = typeof(CaseInsensitiveComparer), Member = "get_Default", ReturnType = typeof(CaseInsensitiveComparer))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IHashCodeProvider), typeof(IComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Hashtable GetEnvironmentVariablesNoCase() { }

	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.HttpListener", Member = "LoadCertificateAndKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.IPAddress", typeof(int)}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_CurrentUserPath", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_LocalMachinePath", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_NewCurrentUserPath", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_NewLocalMachinePath", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_CurrentUser", ReturnType = "Mono.Security.X509.X509Stores")]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_LocalMachine", ReturnType = "Mono.Security.X509.X509Stores")]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_TrustedRootCertificates", ReturnType = "Mono.Security.X509.X509CertificateCollection")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Environment), Member = "UnixGetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder), typeof(SpecialFolderOption)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetFolderPath(SpecialFolder folder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "UnixGetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder), typeof(SpecialFolderOption)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option) { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static bool GetIs64BitOperatingSystem() { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static string GetMachineConfigPath() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetNewLine() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static string GetOSVersionString() { }

	[CalledBy(Type = typeof(Thread), Member = "SetStartHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Thread), Member = "GetProcessDefaultStackSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static int GetPageSize() { }

	[CallerCount(Count = 158)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	internal static string GetResourceString(string key, Object[] values) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static string GetResourceString(string key) { }

	[CalledBy(Type = typeof(Encoding), Member = "get_EncodingName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	internal static string GetResourceStringEncodingName(int codePage) { }

	[CalledBy(Type = typeof(Exception), Member = "get_StackTrace", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Exception), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Exception), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static string GetStackTrace(Exception e, bool needFileInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetWindowsFolderPath(int folder) { }

	[CalledBy(Type = typeof(Environment), Member = "get_SystemDirectory", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "GetEnvironmentVariablesNoCase", ReturnType = typeof(Hashtable))]
	[CalledBy(Type = typeof(Environment), Member = "GetEnvironmentVariables", ReturnType = typeof(IDictionary))]
	[CalledBy(Type = typeof(Environment), Member = "ReadXdgUserDir", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "UnixGetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder), typeof(SpecialFolderOption)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "SearchTerminfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "get_UseManagedCollation", ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(RuntimeMarshal), Member = "MarshalString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SafeStringMarshal))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static string internalGetEnvironmentVariable(string variable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static string internalGetHome() { }

	[CalledBy(Type = typeof(Environment), Member = "UnixGetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder), typeof(SpecialFolderOption)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWithOrdinalUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	[CalledBy(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder), typeof(SpecialFolderOption)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "ReadXdgUserDir", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	internal static string UnixGetFolderPath(SpecialFolder folder, SpecialFolderOption option) { }

}

