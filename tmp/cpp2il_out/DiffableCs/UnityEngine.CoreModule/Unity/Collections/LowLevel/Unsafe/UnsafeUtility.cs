namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
[StaticAccessor("UnsafeUtility", StaticAccessorType::DoubleColon (2))]
public static class UnsafeUtility
{
	private struct AlignOfHelper
	{
		public byte dummy; //Field offset: 0x0
		public T data; //Field offset: 0x0

	}

	public struct TypeFlagsCache
	{
		internal static readonly int flags; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(UnsafeUtility), Member = "GetScriptingTypeFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private static TypeFlagsCache`1() { }

		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(UnsafeUtility), Member = "GetScriptingTypeFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private static void Init(ref int flags) { }

	}


	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static Void* AddressOf(ref T output) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.BuddyAllocator", Member = "AllocateRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = "System.ValueTuple`2<Int32, Int32>")]
	[CalledBy(Type = typeof(NativeArray`1), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), "Unity.Collections.NativeArray`1<T>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer+Reader", Member = "ReadNext", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer+Reader", Member = "ReadNext", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer", Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MemoryUtilities", Member = "Malloc", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = "T*")]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int AlignOf() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static T ArrayElementAsRef(Void* ptr, int index) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static T As(object from) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static T As(ref U from) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static T AsRef(Void* ptr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void CopyPtrToStructure(Void* ptr, out T output) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void CopyStructureToPtr(ref T input, Void* ptr) { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool EnumEquals(T lhs, T rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int EnumToInt(T enumValue) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputActionState", Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputStateBuffers", Member = "FreeAll", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace", Member = "Release", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace", Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlExtensions", Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl", "System.Void*"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionState", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.BuddyAllocator", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionState+UnmanagedMemory", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "UnityEngine.Rendering.MemoryUtilities", Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Allocator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = True)]
	public static void Free(Void* memory, Allocator allocator) { }

	[CalledBy(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.Memory+Unmanaged+Array", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), "Unity.Collections.AllocatorManager+AllocatorHandle", typeof(long), typeof(int)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "Unity.Collections.Memory+Unmanaged", Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", "Unity.Collections.AllocatorManager+AllocatorHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeReferenceDispose", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlockData", Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock*"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = True)]
	public static void FreeTracked(Void* memory, Allocator allocator) { }

	[CalledBy(Type = typeof(GraphicsBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForTypeNonBlittableImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static string GetReasonForGenericListNonBlittable() { }

	[CalledBy(Type = typeof(UnsafeUtility), Member = "GetReasonForTypeNonBlittableImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnsafeUtility), Member = "GetReasonForGenericListNonBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForTypeNonBlittableImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	[CalledBy(Type = typeof(TypeFlagsCache`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeFlagsCache`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	internal static int GetScriptingTypeFlags(Type type) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static void InternalCopyPtrToStructure(Void* ptr, out T output) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private static void InternalCopyStructureToPtr(ref T input, Void* ptr) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private static void InternalEnumToInt(ref T enumValue, ref int intValue) { }

	[CalledBy(Type = typeof(GraphicsBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static bool IsArrayBlittable(Array arr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnsafeUtility), Member = "IsBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool IsBlittable() { }

	[CalledBy(Type = typeof(UnsafeUtility), Member = "IsBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static bool IsBlittable(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool IsBlittableValueType(Type t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static bool IsGenericListBlittable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static bool IsUnmanaged() { }

	[BurstAuthorizedExternalMethod]
	[CalledBy(Type = typeof(TransformAccessArray), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = False)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.AIModule"})]
	internal static int LeakErase(IntPtr handle, LeakCategory category) { }

	[BurstAuthorizedExternalMethod]
	[CalledBy(Type = typeof(TransformAccessArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformAccessArray), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TransformAccessArray&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = False)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.AIModule"})]
	internal static int LeakRecord(IntPtr handle, LeakCategory category, int callstacksToSkip) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputControlExtensions", Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl", "System.Void*"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputStateBuffers", Member = "AllocateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputDevice[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace", Member = "Allocate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace", Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace", Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.BuddyAllocator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionState+UnmanagedMemory", Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Layout.ComponentType[]", typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "UnityEngine.Rendering.MemoryUtilities", Member = "Malloc", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = "T*")]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = True)]
	public static Void* Malloc(long size, int alignment, Allocator allocator) { }

	[CalledBy(Type = typeof(NativeArray`1), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), "Unity.Collections.NativeArray`1<T>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.Memory+Unmanaged+Array", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), "Unity.Collections.AllocatorManager+AllocatorHandle", typeof(long), typeof(int)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "Unity.Collections.RewindableAllocator+MemoryBlock", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeBitArray", Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlockData", Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock*", typeof(int)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock*")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = True)]
	public static Void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 2)]
	public static void MemClear(Void* destination, long size) { }

	[CallerCount(Count = 65)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = True)]
	public static int MemCmp(Void* ptr1, Void* ptr2, long size) { }

	[CallerCount(Count = 227)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = True)]
	public static void MemCpy(Void* destination, Void* source, long size) { }

	[CalledBy(Type = "Unity.Collections.FixedList`2", Member = "AddReplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList32Bytes`1", Member = "AddReplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList64Bytes`1", Member = "AddReplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList128Bytes`1", Member = "AddReplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList512Bytes`1", Member = "AddReplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList4096Bytes`1", Member = "AddReplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeList`1", Member = "AddReplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = True)]
	public static void MemCpyReplicate(Void* destination, Void* source, int size, int count) { }

	[CalledBy(Type = typeof(NativeSlice`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = True)]
	public static void MemCpyStride(Void* destination, int destinationStride, Void* source, int sourceStride, int elementSize, int count) { }

	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventBuffer", Member = "AdvanceToNextEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputEvent*&", "UnityEngine.InputSystem.LowLevel.InputEvent*&", typeof(Int32&), typeof(Int32&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList`2", Member = "InsertRangeWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList32Bytes`1", Member = "InsertRangeWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList64Bytes`1", Member = "InsertRangeWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList128Bytes`1", Member = "InsertRangeWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList512Bytes`1", Member = "InsertRangeWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.FixedList4096Bytes`1", Member = "InsertRangeWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeBitArray", Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.LowLevel.Unsafe.UnsafeBitArray&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeList`1", Member = "InsertRangeWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = True)]
	public static void MemMove(Void* destination, Void* source, long size) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputControlList`1", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.SpriteUtilities", Member = "CreateCircleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color32)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpookyHash), Member = "Hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(ulong), typeof(UInt64*), typeof(UInt64*)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.ArrayOfArrays`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.AllocatorManager+AllocatorHandle", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.HashMapHelper`1", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.HashMapHelper`1", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), "Unity.Collections.AllocatorManager+AllocatorHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.HashMapHelper`1", Member = "ResizeExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap`2", Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe(ThrowsException = True)]
	public static void MemSet(Void* destination, byte value, long size) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static T ReadArrayElement(Void* source, int index) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static T ReadArrayElementWithStride(Void* source, int index, int stride) { }

	[CalledBy(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static int SizeOf(Type type) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int SizeOf() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static void WriteArrayElement(Void* destination, int index, T value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static void WriteArrayElementWithStride(Void* destination, int index, int stride, T value) { }

}

