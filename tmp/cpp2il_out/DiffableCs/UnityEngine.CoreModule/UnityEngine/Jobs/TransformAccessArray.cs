namespace UnityEngine.Jobs;

[DefaultMember("Item")]
[NativeType(Header = "Runtime/Transform/ScriptBindings/TransformAccess.bindings.h", CodegenOptions = CodegenOptions::Custom (1))]
public struct TransformAccessArray : IDisposable
{
	private IntPtr m_TransformArray; //Field offset: 0x0

	public bool isCreated
	{
		[CalledBy(Type = "UnityEngine.Rendering.ArrayExtensions", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalChunk", Member = "ResizeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), "UnityEngine.Rendering.Universal.DecalProjector[]", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityChunk", Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
	}

	public Transform Item
	{
		[CalledBy(Type = "UnityEngine.Rendering.ArrayExtensions", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 106
	}

	public int length
	{
		[CalledBy(Type = "UnityEngine.Rendering.ArrayExtensions", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalChunk", Member = "ResizeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), "UnityEngine.Rendering.Universal.DecalProjector[]", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityChunk", Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 51
	}

	[CalledBy(Type = "UnityEngine.Rendering.ArrayExtensions", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalChunk", Member = "ResizeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), "UnityEngine.Rendering.Universal.DecalProjector[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityChunk", Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeUtility), Member = "LeakRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(LeakCategory), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public TransformAccessArray(int capacity, int desiredJobCount = -1) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "TransformAccessArrayBindings::AddTransform", IsFreeFunction = True)]
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[CalledBy(Type = "UnityEngine.Rendering.ArrayExtensions", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalChunk", Member = "ResizeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), "UnityEngine.Rendering.Universal.DecalProjector[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityChunk", Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "CreateDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalProjector"}, ReturnType = "UnityEngine.Rendering.Universal.DecalEntity")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void Add(Transform transform) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Add_Injected(IntPtr transformArrayIntPtr, IntPtr transform) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "LeakRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(LeakCategory), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TransformAccessArrayBindings::Create", IsFreeFunction = True)]
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "DestroyTransformAccessArray", IsFreeFunction = True)]
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[CalledBy(Type = "UnityEngine.Rendering.ArrayExtensions", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalChunk", Member = "ResizeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), "UnityEngine.Rendering.Universal.DecalProjector[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityChunk", Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityChunk", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnsafeUtility), Member = "LeakErase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(LeakCategory)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CalledBy(Type = "UnityEngine.Rendering.ArrayExtensions", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalChunk", Member = "ResizeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), "UnityEngine.Rendering.Universal.DecalProjector[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityChunk", Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_isCreated() { }

	[CalledBy(Type = "UnityEngine.Rendering.ArrayExtensions", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public Transform get_Item(int index) { }

	[CalledBy(Type = "UnityEngine.Rendering.ArrayExtensions", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalChunk", Member = "ResizeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformAccessArray&), "UnityEngine.Rendering.Universal.DecalProjector[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityChunk", Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public int get_length() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TransformAccessArrayBindings::GetLength", IsFreeFunction = True)]
	internal static int GetLength(IntPtr transformArrayIntPtr) { }

	[CalledBy(Type = typeof(TransformParallelForLoopStruct`1), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TransformAccessArrayBindings::GetSortedToUserIndex", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

	[CalledBy(Type = typeof(TransformParallelForLoopStruct`1), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TransformAccessArrayBindings::GetSortedTransformAccess", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TransformAccessArrayBindings::GetTransform", IsFreeFunction = True, ThrowsException = True)]
	internal static Transform GetTransform(IntPtr transformArrayIntPtr, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetTransform_Injected(IntPtr transformArrayIntPtr, int index) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	internal IntPtr GetTransformAccessArrayForSchedule() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityChunk", Member = "RemoveAtSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveAtSwapBack(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TransformAccessArrayBindings::RemoveAtSwapBack", IsFreeFunction = True, ThrowsException = True)]
	private static void RemoveAtSwapBack(IntPtr transformArrayIntPtr, int index) { }

}

