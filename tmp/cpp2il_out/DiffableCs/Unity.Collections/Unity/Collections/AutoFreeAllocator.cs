namespace Unity.Collections;

[BurstCompile]
internal struct AutoFreeAllocator : IAllocator, IDisposable
{
	public static class Try_000000E3$BurstDirectCall
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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(AutoFreeAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public static int Invoke(IntPtr state, ref Block block) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class Try_000000E3$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public Try_000000E3$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(IntPtr state, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke(IntPtr state, ref Block block) { }

	}

	private ArrayOfArrays<IntPtr> m_allocated; //Field offset: 0x0
	private ArrayOfArrays<IntPtr> m_tofree; //Field offset: 0x20
	private AllocatorHandle m_handle; //Field offset: 0x40
	private AllocatorHandle m_backingAllocatorHandle; //Field offset: 0x44

	public override TryFunction Function
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 213
	}

	public override AllocatorHandle Handle
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override bool IsAutoDispose
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsCustomAllocator
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 9
	}

	public override Allocator ToAllocator
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AutoFreeAllocator), Member = "FreeAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayOfArrays`1), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AutoFreeAllocator), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayOfArrays`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayOfArrays`1), Member = "Rewind", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void FreeAll() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public override TryFunction get_Function() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override AllocatorHandle get_Handle() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_IsAutoDispose() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsCustomAllocator() { }

	[CallerCount(Count = 0)]
	public override Allocator get_ToAllocator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayOfArrays`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(void))]
	public void Initialize(AllocatorHandle backingAllocatorHandle) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void set_Handle(AllocatorHandle value) { }

	[CalledBy(Type = typeof(Try_000000E3$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Try$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayOfArrays`1), Member = "LockfreeAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override int Try(ref Block block) { }

	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(AutoFreeAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(TryFunction))]
	internal static int Try(IntPtr state, ref Block block) { }

	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AutoFreeAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(TryFunction))]
	internal static int Try$BurstManaged(IntPtr state, ref Block block) { }

	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "FreeAll", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayOfArrays`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayOfArrays`1), Member = "RemoveAtSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayOfArrays`1), Member = "Rewind", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayOfArrays`1), Member = "TrimExcess", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update() { }

}

