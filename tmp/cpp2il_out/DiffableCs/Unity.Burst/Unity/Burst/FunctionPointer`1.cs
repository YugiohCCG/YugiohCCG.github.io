namespace Unity.Burst;

[IsReadOnly]
public struct FunctionPointer : IFunctionPointer
{
	[NativeDisableUnsafePtrRestriction]
	private readonly IntPtr _ptr; //Field offset: 0x0

	public T Invoke
	{
		[CalledBy(Type = "Unity.Collections.AllocatorManager", Member = "allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Block&"}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Marshal), Member = "GetDelegateForFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "TDelegate")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 118
	}

	public bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public IntPtr Value
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public FunctionPointer`1(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private void CheckIsCreated() { }

	[CalledBy(Type = "Unity.Collections.AllocatorManager", Member = "allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Block&"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "GetDelegateForFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "TDelegate")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T get_Invoke() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsCreated() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public IntPtr get_Value() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IFunctionPointer Unity.Burst.IFunctionPointer.FromIntPtr(IntPtr ptr) { }

}

