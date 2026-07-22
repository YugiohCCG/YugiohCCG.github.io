namespace Unity.Burst;

public sealed class BurstCompilerOptions
{
	private const string DisableCompilationArg = "--burst-disable-compilation"; //Field offset: 0x0
	internal const string OptionSaveExtraContext = "save-extra-context"; //Field offset: 0x0
	internal const string OptionDiscardAssemblies = "discard-assemblies="; //Field offset: 0x0
	internal const string OptionTargetFramework = "target-framework="; //Field offset: 0x0
	internal const string OptionCompilationId = "compilation-id="; //Field offset: 0x0
	internal const string OptionLibraryOutputMode = "library-output-mode="; //Field offset: 0x0
	internal const string OptionSafetyChecks = "safety-checks"; //Field offset: 0x0
	internal const string OptionAotPdbSearchPaths = "pdb-search-paths="; //Field offset: 0x0
	internal const string OptionAlwaysCreateOutput = "always-create-output="; //Field offset: 0x0
	internal const string OptionOutputMode = "output-mode="; //Field offset: 0x0
	internal const string OptionPrintLogOnMissingPInvokeCallbackAttribute = "print-monopinvokecallbackmissing-message"; //Field offset: 0x0
	internal const string OptionChunkSize = "chunk-size="; //Field offset: 0x0
	internal const string CompilerCommandShutdown = "$shutdown"; //Field offset: 0x0
	internal const string OptionCompilerThreads = "threads="; //Field offset: 0x0
	internal const string OptionVerbose = "verbose"; //Field offset: 0x0
	internal const string OptionAotDecodeFolder = "decode-folder="; //Field offset: 0x0
	internal const string OptionAotKeyFolder = "key-folder="; //Field offset: 0x0
	internal const string OptionAotEmitLlvmObjects = "emit-llvm-objects"; //Field offset: 0x0
	internal const string OptionAotNoNativeToolchain = "no-native-toolchain"; //Field offset: 0x0
	internal const string OptionMethodPrefix = "method-prefix="; //Field offset: 0x0
	internal const string OptionAotOnlyStaticMethods = "only-static-methods"; //Field offset: 0x0
	internal const string OptionAotNoLink = "nolink"; //Field offset: 0x0
	internal const string OptionAotKeepIntermediateFiles = "keep-intermediate-files"; //Field offset: 0x0
	internal const string OptionAotAssembly = "assembly="; //Field offset: 0x0
	internal const string OptionAotType = "type="; //Field offset: 0x0
	internal const string OptionValidateExternalToolChain = "validate-external-tool-chain"; //Field offset: 0x0
	internal const string OptionAotMethod = "method="; //Field offset: 0x0
	internal const string CompilerCommandCancel = "$cancel"; //Field offset: 0x0
	internal const string CompilerCommandDisableCompiler = "$disable_compiler"; //Field offset: 0x0
	internal static readonly bool ForceDisableBurstCompilation; //Field offset: 0x0
	internal const string CompilerCommandSetProtocolVersionBurst = "$set_protocol_version_burst"; //Field offset: 0x0
	internal const string CompilerCommandRequestSetProtocolVersionEditor = "$request_set_protocol_version_editor"; //Field offset: 0x0
	internal const string CompilerCommandInitialiseDebuggerCommmand = "$load_debugger_interface"; //Field offset: 0x0
	internal const string CompilerCommandRequestInitialiseDebuggerCommmand = "$request_debug_command"; //Field offset: 0x0
	internal const string CompilerCommandAotCompilation = "$aot_compilation"; //Field offset: 0x0
	internal const string CompilerCommandDirtyAllAssemblies = "$dirty_all_assemblies"; //Field offset: 0x0
	internal const string CompilerCommandNotifyCompilationFinished = "$notify_compilation_finished"; //Field offset: 0x0
	internal const string CompilerCommandNotifyCompilationStarted = "$notify_compilation_started"; //Field offset: 0x0
	internal const string CompilerCommandNotifyAssemblyCompilationFinished = "$notify_assembly_compilation_finished"; //Field offset: 0x0
	internal const string CompilerCommandNotifyAssemblyCompilationNotRequired = "$notify_assembly_compilation_not_required"; //Field offset: 0x0
	internal const string CompilerCommandEnableCompiler = "$enable_compiler"; //Field offset: 0x0
	internal const string CompilerCommandIsArmTestEnv = "$is_arm_test_env"; //Field offset: 0x0
	internal const string CompilerCommandIsNativeApiAvailable = "$is_native_api_available"; //Field offset: 0x0
	internal const string CompilerCommandUnloadBurstNatives = "$unload_burst_natives"; //Field offset: 0x0
	internal const string CompilerCommandSetProfileCallbacks = "$set_profile_callbacks"; //Field offset: 0x0
	internal const string CompilerCommandGetTargetCpuFromHost = "$get_target_cpu_from_host"; //Field offset: 0x0
	internal const string CompilerCommandVersionNotification = "$version"; //Field offset: 0x0
	internal const string CompilerCommandDomainReload = "$domain_reload"; //Field offset: 0x0
	internal const string CompilerCommandInitialize = "$initialize"; //Field offset: 0x0
	internal const string CompilerCommandTriggerRecompilation = "$trigger_recompilation"; //Field offset: 0x0
	internal const string CompilerCommandIsCurrentCompilationDone = "$is_current_compilation_done"; //Field offset: 0x0
	internal const string CompilerCommandTriggerSetupRecompilation = "$trigger_setup_recompilation"; //Field offset: 0x0
	internal const string CompilerCommandSetDefaultOptions = "$set_default_options"; //Field offset: 0x0
	internal const string CompilerCommandILPPCompilation = "$ilpp_compilation"; //Field offset: 0x0
	internal const string OptionIncludeRootAssemblyReferences = "include-root-assembly-references="; //Field offset: 0x0
	internal const string OptionAotOutputPath = "output="; //Field offset: 0x0
	internal const string OptionAotAssemblyFolder = "assembly-folder="; //Field offset: 0x0
	internal const string OptionFormat = "format="; //Field offset: 0x0
	internal const string OptionDump = "dump="; //Field offset: 0x0
	internal const string OptionRootAssembly = "root-assembly="; //Field offset: 0x0
	internal const string OptionDisableWarnings = "disable-warnings="; //Field offset: 0x0
	internal const string OptionBranchProtection = "branch-protection="; //Field offset: 0x0
	internal const string OptionFloatMode = "float-mode="; //Field offset: 0x0
	internal const string OptionFloatPrecision = "float-precision="; //Field offset: 0x0
	internal const string OptionOptForSize = "opt-for-size"; //Field offset: 0x0
	internal const string OptionLogTimings = "log-timings"; //Field offset: 0x0
	internal const string OptionOptLevel = "opt-level="; //Field offset: 0x0
	internal const string OptionTarget = "target="; //Field offset: 0x0
	internal const string OptionFastMath = "fastmath"; //Field offset: 0x0
	internal const string OptionDisableOpt = "disable-opt"; //Field offset: 0x0
	internal const string OptionDisableSafetyChecks = "disable-safety-checks"; //Field offset: 0x0
	internal const string OptionGlobalSafetyChecksSetting = "global-safety-checks-setting="; //Field offset: 0x0
	internal const string OptionBackend = "backend="; //Field offset: 0x0
	internal const string OptionMinimumOSVersion = "minimum-os-version="; //Field offset: 0x0
	internal const string OptionPlatform = "platform="; //Field offset: 0x0
	internal const string OptionGroup = "group"; //Field offset: 0x0
	internal const string OptionBurstcSwitch = "+burstc"; //Field offset: 0x0
	internal const string BurstInitializeStaticsName = "burst.initialize.statics"; //Field offset: 0x0
	internal const string BurstInitializeExternalsName = "burst.initialize.externals"; //Field offset: 0x0
	internal const string BurstInitializeName = "burst.initialize"; //Field offset: 0x0
	internal const string DefaultLibraryName = "lib_burst_generated"; //Field offset: 0x0
	private const string ForceSynchronousCompilationArg = "--burst-force-sync-compilation"; //Field offset: 0x0
	internal const string OptionDebugTrap = "debugtrap"; //Field offset: 0x0
	internal const string OptionDisableVectors = "disable-vectors"; //Field offset: 0x0
	internal const string OptionAssemblyDefines = "assembly-defines="; //Field offset: 0x0
	internal const string OptionDebugMode = "debugMode"; //Field offset: 0x0
	internal const string OptionEnableInterpreter = "enable-interpreter"; //Field offset: 0x0
	internal const string OptionJitManagedDelegateHandle = "managed-delegate-handle="; //Field offset: 0x0
	internal const string OptionJitManagedFunctionPointer = "managed-function-pointer="; //Field offset: 0x0
	internal const string OptionJitIsForFunctionPointer = "is-for-function-pointer"; //Field offset: 0x0
	internal const string OptionJitCompilationPriority = "compilation-priority="; //Field offset: 0x0
	internal const string OptionJitEnableSynchronousCompilation = "enable-synchronous-compilation"; //Field offset: 0x0
	internal const string OptionJitEnableAssemblyCachingLogs = "enable-assembly-caching-logs"; //Field offset: 0x0
	internal const string OptionDebug = "debug="; //Field offset: 0x0
	internal const string OptionJitDisableFunctionCaching = "disable-function-caching"; //Field offset: 0x0
	internal const string OptionCacheDirectory = "cache-directory="; //Field offset: 0x0
	internal const string OptionForceDisableFrameInfoRegistration = "force-disable-frame-info-registration"; //Field offset: 0x0
	internal const string OptionStackProtectorBufferSize = "stack-protector-buffer-size="; //Field offset: 0x0
	internal const string OptionJitDisableAssemblyCaching = "disable-assembly-caching"; //Field offset: 0x0
	internal const string OptionPlatformConfiguration = "platform-configuration="; //Field offset: 0x0
	internal const string OptionStaticLinkage = "generate-static-linkage-methods"; //Field offset: 0x0
	internal const string OptionStackProtector = "stack-protector="; //Field offset: 0x0
	internal const string OptionTempDirectory = "temp-folder="; //Field offset: 0x0
	internal const string OptionEnableDirectExternalLinking = "enable-direct-external-linking"; //Field offset: 0x0
	internal const string OptionLinkerOptions = "linker-options="; //Field offset: 0x0
	internal const string OptionJobMarshalling = "generate-job-marshalling-methods"; //Field offset: 0x0
	internal const string OptionEnableFrameInfoRegistration = "enable-frame-info-registration"; //Field offset: 0x0
	internal const string OptionGenerateLinkXml = "generate-link-xml="; //Field offset: 0x0
	internal const string OptionMetaDataGeneration = "meta-data-generation="; //Field offset: 0x0
	internal const string OptionDisableStringInterpolationInExceptionMessages = "disable-string-interpolation-in-exception-messages"; //Field offset: 0x0
	internal const string OptionEnableAutoLayoutFallbackCheck = "enable-autolayout-fallback-check"; //Field offset: 0x0
	private static readonly bool ForceBurstCompilationSynchronously; //Field offset: 0x1
	internal static readonly bool IsSecondaryUnityProcess; //Field offset: 0x2
	private bool _enableBurstCompilation; //Field offset: 0x10
	private bool _enableBurstCompileSynchronously; //Field offset: 0x11
	private bool _enableBurstSafetyChecks; //Field offset: 0x12
	private bool _enableBurstTimings; //Field offset: 0x13
	private bool _enableBurstDebug; //Field offset: 0x14
	private bool _forceEnableBurstSafetyChecks; //Field offset: 0x15
	[CompilerGenerated]
	private readonly bool <IsGlobal>k__BackingField; //Field offset: 0x16
	[CompilerGenerated]
	private Action <OptionsChanged>k__BackingField; //Field offset: 0x18

	[Obsolete("This property is no longer used and will be removed in a future major release")]
	public bool DisableOptimizations
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public bool EnableBurstCompilation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(BurstCompilerOptions), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(JobsUtility), Member = "set_JobCompilerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 219
	}

	public bool EnableBurstCompileSynchronously
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 33
	}

	public bool EnableBurstDebug
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 33
	}

	public bool EnableBurstSafetyChecks
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 33
	}

	internal bool EnableBurstTimings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal set { } //Length: 33
	}

	[Obsolete("This property is no longer used and will be removed in a future major release. Use the [BurstCompile(FloatMode = FloatMode.Fast)] on the method directly to enable this feature")]
	public bool EnableFastMath
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public bool ForceEnableBurstSafetyChecks
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 33
	}

	public bool IsEnabled
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 101
	}

	private bool IsGlobal
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	internal Action OptionsChanged
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal bool RequiresSynchronousCompilation
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 99
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static BurstCompilerOptions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobsUtility), Member = "set_JobCompilerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private BurstCompilerOptions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstCompilerOptions), Member = "set_EnableBurstCompilation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal BurstCompilerOptions(bool isGlobal) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void AddOption(StringBuilder builder, string option) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private static bool CheckIsSecondaryUnityProcess() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobsUtility), Member = "set_JobCompilerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	internal BurstCompilerOptions Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeStringArrayHelper), Member = "DeserialiseStringArraySafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static ValueTuple<String[], String[], String> DeserialiseCompilationOptionsSafe(string from) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool get_DisableOptimizations() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_EnableBurstCompilation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_EnableBurstCompileSynchronously() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_EnableBurstDebug() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_EnableBurstSafetyChecks() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_EnableBurstTimings() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public bool get_EnableFastMath() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_ForceEnableBurstSafetyChecks() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsEnabled() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool get_IsGlobal() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal Action get_OptionsChanged() { }

	[CallerCount(Count = 0)]
	internal bool get_RequiresSynchronousCompilation() { }

	[CalledBy(Type = typeof(BurstCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(BurstCompilerOptions), Member = "TryGetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BurstCompileAttribute&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BurstCompilerOptions), Member = "HasBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BurstCompilerOptions), Member = "TryGetOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(String&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(BurstCompileAttribute), Member = "set_CompileSynchronously", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static string GetOption(string optionName, object value = null) { }

	[CalledBy(Type = typeof(BurstCompilerOptions), Member = "TryGetOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(String&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(BurstCompiler), Member = "IsApiAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "get_CurrentDirectory", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 33)]
	[CallsUnknownMethods(Count = 74)]
	internal string GetOptions(BurstCompileAttribute attr = null, bool isForILPostProcessing = false, bool isForCompilerClient = false, bool deterministicCompilation = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal static bool HasBurstCompileAttribute(MemberInfo member) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void MaybeTriggerRecompilation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void MergeAttributes(ref BurstCompileAttribute memberAttribute, in BurstCompileAttribute assemblyAttribute) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnOptionsChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeStringArrayHelper), Member = "SerialiseStringArraySafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	internal static string SerialiseCompilationOptionsSafe(String[] roots, String[] folders, string options) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void set_DisableOptimizations(bool value) { }

	[CalledBy(Type = typeof(BurstCompilerOptions), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobsUtility), Member = "set_JobCompilerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_EnableBurstCompilation(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_EnableBurstCompileSynchronously(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_EnableBurstDebug(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_EnableBurstSafetyChecks(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void set_EnableBurstTimings(bool value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void set_EnableFastMath(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ForceEnableBurstSafetyChecks(bool value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_OptionsChanged(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool TryGetAttribute(Assembly assembly, out BurstCompileAttribute attribute) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
	[CallsUnknownMethods(Count = 2)]
	private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = "T")]
	[Calls(Type = typeof(BurstCompilerOptions), Member = "GetOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BurstCompileAttribute), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal bool TryGetOptions(MemberInfo member, out string flagsOut, bool isForILPostProcessing = false, bool isForCompilerClient = false, bool deterministicCompilation = false) { }

}

