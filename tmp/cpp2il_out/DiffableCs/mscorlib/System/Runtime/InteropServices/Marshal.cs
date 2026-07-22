namespace System.Runtime.InteropServices;

public static class Marshal
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Dictionary`2<ValueTuple`2<Type, String>, ICustomMarshaler>> <>9__201_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Object, System.Object>, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<System.Object, System.Object>>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal Dictionary<ValueTuple`2<Type, String>, ICustomMarshaler> <GetCustomMarshalerInstance>b__201_0() { }

	}

	public class MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple`2<Type, String>>
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public MarshalerInstanceKeyComparer() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ValueTuple`2<System.Object, System.Object>), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Object, System.Object>)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		public override bool Equals(ValueTuple<Type, String> lhs, ValueTuple<Type, String> rhs) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ValueTuple`2<System.Object, System.Object>), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode(ValueTuple<Type, String> key) { }

	}

	public sealed class SecureStringAllocator : MulticastDelegate
	{

		[CallerCount(Count = 26)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public SecureStringAllocator(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IntPtr Invoke(int len) { }

	}

	public static readonly int SystemMaxDBCSCharSize; //Field offset: 0x0
	public static readonly int SystemDefaultCharSize; //Field offset: 0x4
	internal static Dictionary<ValueTuple`2<Type, String>, ICustomMarshaler> MarshalerInstanceCache; //Field offset: 0x8
	internal static readonly object MarshalerInstanceCacheLock; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_IsRunningOnWindows", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Marshal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[CallerCount(Count = 45)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static IntPtr AllocHGlobal(int cb) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IntPtr BufferToBSTR(Char* ptr, int slen) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	private static void ClearBSTR(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void ClearUnicode(IntPtr ptr) { }

	[CalledBy(Type = "Plugins.CoreAPI", Member = "PreloadScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel+<SetResponse>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "ToPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = "System.ValueTuple`2<Int32, IntPtr>")]
	[CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ReadCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(IntPtr), "unitytls_errorstate*"}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsBioMono", Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsBioMono", Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = "System.ValueTuple`2<Int32, Boolean>")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509", Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "Mono.Btls.MonoBtlsX509Format"}, ReturnType = "Mono.Btls.MonoBtlsX509")]
	[CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "UnmanagedRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void Copy(Byte[] source, int startIndex, IntPtr destination, int length) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "SetCiphers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int16[]", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Copy(Int16[] source, int startIndex, IntPtr destination, int length) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Copy(Int32[] source, int startIndex, IntPtr destination, int length) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Copy(IntPtr source, Byte[] destination, int startIndex, int length) { }

	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "BuildTailoringTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(TailoringInfo), typeof(Contraction[]&), typeof(Level2Map[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Copy(IntPtr source, Char[] destination, int startIndex, int length) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "CopyIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(IntPtr)}, ReturnType = "System.String[]")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Copy(IntPtr source, Int32[] destination, int startIndex, int length) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "CopyIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(IntPtr)}, ReturnType = "System.String[]")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, Void* fixed_destination_element) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void copy_to_unmanaged(Byte[] source, int startIndex, IntPtr destination, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, Void* fixed_source_element) { }

	[CalledBy(Type = typeof(Variant), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void FreeBSTR(IntPtr ptr) { }

	[CallerCount(Count = 55)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void FreeHGlobal(IntPtr hglobal) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Object, System.Object>, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Object, System.Object>), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "InternalInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(Exception&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Object, System.Object>, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Object, System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 44)]
	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie) { }

	[CalledBy(Type = "Unity.Burst.FunctionPointer`1", Member = "get_Invoke", ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "GetDelegateForFunctionPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static TDelegate GetDelegateForFunctionPointer(IntPtr ptr) { }

	[CalledBy(Type = typeof(Marshal), Member = "GetDelegateForFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "TDelegate")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "CompileDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 19)]
	public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t) { }

	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "GetILPPMethodFunctionPointer2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(RuntimeMethodHandle), typeof(RuntimeTypeHandle)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static IntPtr GetFunctionPointerForDelegate(Delegate d) { }

	[CalledBy(Type = typeof(OSSpecificSynchronizationContext), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SendOrPostCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDelegates", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsBioMono", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.IMonoBtlsBioMono"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSsl", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsSslCtx"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsSslCtx+BoringSslCtxHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509LookupMono", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static IntPtr GetFunctionPointerForDelegate(TDelegate d) { }

	[CalledBy(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	[CallerCount(Count = 0)]
	public static int GetHRForException(Exception e) { }

	[CallerCount(Count = 32)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int GetLastWin32Error() { }

	[CalledBy(Type = "System.ComponentModel.ReferenceConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsComObject(object o) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout", Member = "AddControlItemsFromMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Reflection.MemberInfo[]", "System.Collections.Generic.List`1<ControlItem>", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout", Member = "CreateControlItemFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), "UnityEngine.InputSystem.Layouts.InputControlAttribute"}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem")]
	[CalledBy(Type = "Unity.Collections.CollectionHelper", Member = "WriteLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr OffsetOf(Type t, string fieldName) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsSsl", Member = "PrintErrorsCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string PtrToStringAnsi(IntPtr ptr, int len) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsSslError"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsError", Member = "GetErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsError", Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSsl", Member = "GetServerName", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509Name", Member = "GetEntryOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static string PtrToStringAnsi(IntPtr ptr) { }

	[CalledBy(Type = "SQLite.SQLite3", Member = "GetErrmsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[CalledBy(Type = "SQLite.SQLite3", Member = "ColumnName16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "SQLite.SQLite3", Member = "ColumnString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SafePasswordHandle), Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static string PtrToStringUni(IntPtr ptr) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.StringHelpers", Member = "ReadStringFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.StringHelpers", Member = "ReadStringFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(UInt32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[CalledBy(Type = "Mono.Unity.UnityTls", Member = "get_NativeInterface", ReturnType = "Mono.Unity.UnityTls+unitytls_interface_struct")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T PtrToStructure(IntPtr ptr) { }

	[CallerCount(Count = 26)]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(True)]
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[CalledBy(Type = typeof(Variant), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int Release(IntPtr pUnk) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	private static int ReleaseInternal(IntPtr pUnk) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static IntPtr SecureStringGlobalAllocator(int len) { }

	[CalledBy(Type = "System.Diagnostics.Process", Member = "FillUserInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo", "ProcInfo&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SecureString), Member = "GetBuffer", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SecureString), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static IntPtr SecureStringToBSTR(SecureString s) { }

	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsInvalidInstructions]
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecureString), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(SecureString), Member = "GetBuffer", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	internal static IntPtr SecureStringToUnicode(SecureString s, SecureStringAllocator allocator) { }

	[CalledBy(Type = typeof(Kernel32), Member = "CopyFileUWP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUPrefixSum+RenderGraphResources", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUPrefixSum+SupportResources", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager+LightCookieShaderData", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShaderData", Member = "GetOrUpdateBuffer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ComputeBuffer&", typeof(int)}, ReturnType = "UnityEngine.ComputeBuffer")]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureProbeBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureTransformBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchProbeUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<SphericalHarmonicsL2>", "Unity.Collections.NativeArray`1<Vector4>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "AllocateInstanceBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "AllocateDrawBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int SizeOf() { }

	[CalledBy(Type = "Discord.Discord", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static int SizeOf(T structure) { }

	[CalledBy(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.NetworkInformation.Win32NetworkInterfaceAPI", Member = "GetAdaptersAddresses", ReturnType = "System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES[]")]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "TryCreateDebugRenderData", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GraphicsBuffer", Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CommandBuffer", Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ComputeBuffer", "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CommandBuffer", Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ComputeBuffer", typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CommandBuffer", Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ComputeBuffer", "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CommandBuffer", Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GraphicsBuffer", "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CommandBuffer", Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GraphicsBuffer", typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CommandBuffer", Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GraphicsBuffer", "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.CollectionHelper", Member = "WriteLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	public static int SizeOf(Type t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool skip_fixed(Array array, int startIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IntPtr StringToHGlobalAnsi(Char* s, int length) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsSsl", Member = "SetServerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509Lookup", Member = "AddDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Mono.Btls.MonoBtlsX509FileType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "Mono.Btls.MonoBtlsX509VerifyParam")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "SetHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static IntPtr StringToHGlobalAnsi(string s) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IntPtr StringToHGlobalUni(Char* s, int length) { }

	[CalledBy(Type = typeof(SafePasswordHandle), Member = "CreateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(SafePasswordHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static IntPtr StringToHGlobalUni(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static void StructureToPtr(T structure, IntPtr ptr, bool fDeleteOld) { }

	[CalledBy(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(True)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	[CalledBy(Type = typeof(Marshal), Member = "UnsafeAddrOfPinnedArrayElement", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Marshal), Member = "UnsafeAddrOfPinnedArrayElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(IntPtr))]
	[DeduplicatedMethod]
	public static IntPtr UnsafeAddrOfPinnedArrayElement(T[] arr, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	[CalledBy(Type = "System.UriTypeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithShellExecuteEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void ZeroFreeBSTR(IntPtr s) { }

	[CalledBy(Type = typeof(SafePasswordHandle), Member = "FreeHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafePasswordHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebRequestPrefixElement", Member = "get_Creator", ReturnType = "System.Net.IWebRequestCreate")]
	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

}

