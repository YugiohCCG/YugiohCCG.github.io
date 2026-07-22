namespace Unity.Burst;

public static class BurstCompiler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Attribute, Boolean> <>9__22_0; //Field offset: 0x8
		public static Func<Attribute, Boolean> <>9__29_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <Compile>b__22_0(Attribute s) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <TriggerUnsafeStaticMethodRecompilation>b__29_0(Attribute x) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass17_0
	{
		public RuntimeMethodHandle managedMethodHandle; //Field offset: 0x0
		public RuntimeTypeHandle delegateTypeHandle; //Field offset: 0x8

	}

	[BurstCompile]
	public static class BurstCompilerHelper
	{
		public static class IsBurstEnabled_00000145$BurstDirectCall
		{
			private static IntPtr Pointer; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
			[CallsUnknownMethods(Count = 4)]
			private static IntPtr GetFunctionPointer() { }

			[BurstDiscard]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
			[CallsUnknownMethods(Count = 4)]
			private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

			[CalledBy(Type = typeof(BurstCompilerHelper), Member = "IsBurstEnabled", ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
			[CallsUnknownMethods(Count = 5)]
			public static bool Invoke() { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class IsBurstEnabled_00000145$PostfixBurstDelegate : MulticastDelegate
		{

			[CallerCount(Count = 1914)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public IsBurstEnabled_00000145$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(AsyncCallback unnamed_param_0, object unnamed_param_1) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override bool EndInvoke(IAsyncResult unnamed_param_0) { }

			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override bool Invoke() { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		private sealed class IsBurstEnabledDelegate : MulticastDelegate
		{

			[CallerCount(Count = 1914)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public IsBurstEnabledDelegate(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override bool EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override bool Invoke() { }

		}

		private static readonly IsBurstEnabledDelegate IsBurstEnabledImpl; //Field offset: 0x0
		public static readonly bool IsBurstGenerated; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "CompileAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "GetAsyncCompiledAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		private static BurstCompilerHelper() { }

		[BurstDiscard]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		private static void DiscardedMethod(ref bool value) { }

		[BurstCompile]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IsBurstEnabled_00000145$BurstDirectCall), Member = "Invoke", ReturnType = typeof(bool))]
		[MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
		private static bool IsBurstEnabled() { }

		[BurstCompile]
		[CallerCount(Count = 0)]
		[MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
		internal static bool IsBurstEnabled$BurstManaged() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "CompileAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "GetAsyncCompiledAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
		[ContainsUnimplementedInstructions]
		private static bool IsCompiledByBurst(Delegate del) { }

	}

	private class CommandBuilder
	{
		private StringBuilder _builder; //Field offset: 0x10
		private bool _hasArgs; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public CommandBuilder() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		public CommandBuilder And(char sep = |) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		public CommandBuilder Begin(string cmd) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "SendRawCommandToCompiler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public string SendToCompiler() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		public CommandBuilder With(string arg) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public CommandBuilder With(IntPtr arg) { }

	}

	private class FakeDelegate
	{
		[CompilerGenerated]
		private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x10

		[Preserve]
		public MethodInfo Method
		{
			[CallerCount(Count = 106)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 98)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public FakeDelegate(MethodInfo method) { }

		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public MethodInfo get_Method() { }

	}

	[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
	public class StaticTypeReinitAttribute : Attribute
	{
		public readonly Type reinitType; //Field offset: 0x10

		[CallerCount(Count = 27)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public StaticTypeReinitAttribute(Type toReinit) { }

	}

	[ThreadStatic]
	private static CommandBuilder _cmdBuilder; //Field offset: 0x80000000
	internal static bool _IsEnabled; //Field offset: 0x0
	public static readonly BurstCompilerOptions Options; //Field offset: 0x8
	internal static Action OnCompileILPPMethod2; //Field offset: 0x10
	private static readonly MethodInfo DummyMethodInfo; //Field offset: 0x18

	public static bool IsEnabled
	{
		[CallerCount(Count = 28)]
		 get { } //Length: 141
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobsUtility), Member = "set_JobCompilerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static BurstCompiler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "GetMethodFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void <GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0(out Delegate managedFallbackDelegate, out GCHandle gcHandle, ref <>c__DisplayClass17_0 unnamed_param_2) { }

	[CallerCount(Count = 0)]
	internal static string AotCompilation(String[] assemblyFolders, String[] assemblyRoots, string options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static CommandBuilder BeginCompilerCommand(string cmd) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void Cancel() { }

	[CalledBy(Type = typeof(BurstCompiler), Member = "CompileILPPMethod2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(BurstCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(Void*))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "GetAsyncCompiledAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "CompileAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "All", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 33)]
	private static Void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing, bool deterministicCompilation = false) { }

	[CalledBy(Type = typeof(BurstCompiler), Member = "CompileDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = "T")]
	[CalledBy(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BurstCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static Void* Compile(object delegateObj, bool isFunctionPointer, bool deterministicCompilation = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "GetDelegateForFunctionPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal static T CompileDelegate(T delegateMethod, bool deterministicCompilation = false) { }

	[CallerCount(Count = 71)]
	[Calls(Type = typeof(BurstCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static FunctionPointer<T> CompileFunctionPointer(T delegateMethod) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Obsolete("This method will be removed in a future version of Burst")]
	public static IntPtr CompileILPPMethod(RuntimeMethodHandle burstMethodHandle, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "GetMethodFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(BurstCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Obsolete("This method will be removed in a future version of Burst")]
	public static Void* CompileUnsafeStaticMethod(RuntimeMethodHandle handle) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void Disable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static void DummyMethod() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void Enable() { }

	[CallerCount(Count = 28)]
	public static bool get_IsEnabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "GetCurrentExecutionMode", ReturnType = typeof(uint))]
	public static BurstExecutionEnvironment GetExecutionMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Obsolete("This method will be removed in a future version of Burst")]
	public static Void* GetILPPMethodFunctionPointer(IntPtr ilppMethod) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "GetMethodFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static Void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void Initialize(String[] assemblyFolders, String[] ignoreAssemblies) { }

	[CalledBy(Type = typeof(BurstCompiler), Member = "IsLoadAdditionalLibrarySupported", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BurstCompilerOptions), Member = "GetOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BurstCompileAttribute), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BurstRuntime), Member = "LoadAdditionalLibrary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BurstCompiler), Member = "SendCommandToCompiler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool IsApiAvailable(string apiName) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal static bool IsCurrentCompilationDone() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal static bool IsHostEditorArm() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstCompiler), Member = "IsApiAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	public static bool IsLoadAdditionalLibrarySupported() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void NotifyAssemblyCompilationFinished(string assemblyName, String[] defines) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void NotifyAssemblyCompilationNotRequired(string assemblyName) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void NotifyCompilationFinished() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void NotifyCompilationStarted(String[] assemblyFolders, String[] ignoreAssemblies) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BurstCompiler), Member = "SendCommandToCompiler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	internal static int RequestSetProtocolVersion(int version) { }

	[CalledBy(Type = typeof(BurstCompiler), Member = "IsApiAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BurstCompiler), Member = "RequestSetProtocolVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsInvalidInstructions]
	private static string SendCommandToCompiler(string commandName, string commandArgs = null) { }

	[CalledBy(Type = typeof(CommandBuilder), Member = "SendToCompiler", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BurstCompiler), Member = "UnloadAdditionalLibraries", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "GetDisassembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string SendRawCommandToCompiler(string command) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "SetCurrentExecutionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public static void SetExecutionMode(BurstExecutionEnvironment mode) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void SetProfilerCallbacks() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void Shutdown() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void TriggerRecompilation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	internal static void TriggerUnsafeStaticMethodRecompilation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstCompiler), Member = "SendRawCommandToCompiler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void UnloadAdditionalLibraries() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private static void VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute(T delegateMethod) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static void VerifyDelegateIsNotMulticast(T delegateMethod) { }

}

