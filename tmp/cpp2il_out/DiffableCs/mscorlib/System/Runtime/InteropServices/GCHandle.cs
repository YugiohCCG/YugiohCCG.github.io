namespace System.Runtime.InteropServices;

[ComVisible(True)]
public struct GCHandle
{
	private IntPtr handle; //Field offset: 0x0

	public bool IsAllocated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public object Target
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 126
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 86
	}

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	private GCHandle(IntPtr h) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private GCHandle(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal GCHandle(object value, GCHandleType type) { }

	[CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.UriComponents"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PinnedArray`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "CopySafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), "Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "CopySafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), "T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public IntPtr AddrOfPinnedObject() { }

	[CallerCount(Count = 22)]
	[CallsUnknownMethods(Count = 1)]
	public static GCHandle Alloc(object value, GCHandleType type) { }

	[CallerCount(Count = 78)]
	[CallsUnknownMethods(Count = 1)]
	public static GCHandle Alloc(object value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal static bool CanDereferenceHandle(IntPtr handle) { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static bool CheckCurrentDomain(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 91)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Free() { }

	[CallerCount(Count = 0)]
	private static void FreeHandle(IntPtr handle) { }

	[CallerCount(Count = 89)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public static GCHandle FromIntPtr(IntPtr value) { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsAllocated() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public object get_Target() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IntPtr GetAddrOfPinnedObject(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static object GetRef(IntPtr handle) { }

	[CallerCount(Count = 121)]
	private static object GetTarget(IntPtr handle) { }

	[CalledBy(Type = typeof(WeakReference), Member = "set_Target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WeakReference`1), Member = "SetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.GCHandlePool", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.GCHandlePool", Member = "ReturnAll", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GCHandlePool", Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GCHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type) { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static IntPtr op_Explicit(GCHandle value) { }

	[CallerCount(Count = 89)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public static GCHandle op_Explicit(IntPtr value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Target(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetRef(IntPtr handle, object value) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static IntPtr ToIntPtr(GCHandle value) { }

}

