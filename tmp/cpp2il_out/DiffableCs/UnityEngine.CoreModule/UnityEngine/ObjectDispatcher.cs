namespace UnityEngine;

[NativeHeader("Runtime/Misc/ObjectDispatcher.h")]
[RequiredByNativeCode]
[StaticAccessor("GetObjectDispatcher()", StaticAccessorType::Dot (0))]
internal sealed class ObjectDispatcher : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <.cctor>b__64_0(Object[] changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, Action<TypeDispatchData> callback) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <.cctor>b__64_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, Action<TransformDispatchData> callback) { }

	}

	internal enum TransformTrackingType
	{
		GlobalTRS = 0,
		LocalTRS = 1,
		Hierarchy = 2,
	}

	[Flags]
	internal enum TypeTrackingFlags
	{
		SceneObjects = 1,
		Assets = 2,
		EditorOnlyObjects = 4,
		Default = 3,
		All = 7,
	}

	private static Action<Object[], IntPtr, IntPtr, Int32, Int32, Action`1<TypeDispatchData>> s_TypeDispatch; //Field offset: 0x0
	private static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, Int32, Action`1<TransformDispatchData>> s_TransformDispatch; //Field offset: 0x8
	private IntPtr m_Ptr; //Field offset: 0x10
	private Allocator m_DispatchAllocator; //Field offset: 0x18
	private TypeDispatchData m_TypeDispatchData; //Field offset: 0x20
	private TransformDispatchData m_TransformDispatchData; //Field offset: 0x48
	private Component[] m_TransformedComponents; //Field offset: 0xA8
	private Action<TypeDispatchData> m_TypeDataCallback; //Field offset: 0xB0
	private Action<TransformDispatchData> m_TransformDataCallback; //Field offset: 0xB8
	private Action<Component[]> m_TransformComponentCallback; //Field offset: 0xC0

	public bool valid
	{
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Action`6<System.Object, System.IntPtr, System.IntPtr, System.Int32, System.Int32, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`8), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static ObjectDispatcher() { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerSettings", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Action`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public ObjectDispatcher() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr CreateDispatchSystemHandle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	private static void DestroyDispatchSystemHandle(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void DispatchCallback(Component[] components) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(Allocator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DispatchCallback(TypeDispatchData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(Allocator)}, ReturnType = typeof(void))]
	private void DispatchCallback(TransformDispatchData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectDispatcher), Member = "ValidateComponentTypeAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void DispatchTransformChangesAndClear(Type type, TransformTrackingType trackingType, Action<TransformDispatchData> callback) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DispatchTransformDataChangesAndClear(IntPtr ptr, Type type, TransformTrackingType trackingType, Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, Int32, Action`1<TransformDispatchData>> callback, Action<TransformDispatchData> param) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DispatchTypeChangesAndClear(IntPtr ptr, Type type, Action<Object[], IntPtr, IntPtr, Int32, Int32, Action`1<TypeDispatchData>> callback, bool sortByInstanceID, bool noScriptingArray, Action<TypeDispatchData> param) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectDispatcher), Member = "ValidateTypeAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void DispatchTypeChangesAndClear(Type type, Action<TypeDispatchData> callback, bool sortByInstanceID = false, bool noScriptingArray = false) { }

	[CalledBy(Type = typeof(ObjectDispatcher), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectDispatcher), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Dispose(bool disposing) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectDispatcher), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerSettings", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDispatcher), Member = "EnableTransformTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformTrackingType), typeof(Type[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public void EnableTransformTracking(TransformTrackingType trackingType) { }

	[CalledBy(Type = typeof(ObjectDispatcher), Member = "EnableTransformTracking", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformTrackingType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void EnableTransformTracking(TransformTrackingType trackingType, Type[] types) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableTransformTracking(IntPtr ptr, Type type, TransformTrackingType trackingType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableTypeTracking(IntPtr ptr, Type type, TypeTrackingFlags typeTrackingMask) { }

	[CalledBy(Type = typeof(ObjectDispatcher), Member = "EnableTypeTracking", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeTrackingFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void EnableTypeTracking(TypeTrackingFlags typeTrackingMask, Type[] types) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerSettings", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDispatcher), Member = "EnableTypeTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeTrackingFlags), typeof(Type[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public void EnableTypeTracking(TypeTrackingFlags typeTrackingMask = 3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectDispatcher), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_valid() { }

	[CalledBy(Type = typeof(ObjectDispatcher), Member = "GetTransformChangesAndClear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformTrackingType), typeof(Allocator)}, ReturnType = typeof(TransformDispatchData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectDispatcher), Member = "ValidateComponentTypeAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public TransformDispatchData GetTransformChangesAndClear(Type type, TransformTrackingType trackingType, Allocator allocator) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "ProcessRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeDispatchData), "Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDispatcher), Member = "GetTransformChangesAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(TransformTrackingType), typeof(Allocator)}, ReturnType = typeof(TransformDispatchData))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TransformDispatchData GetTransformChangesAndClear(TransformTrackingType trackingType, Allocator allocator) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDispatcher), Member = "GetTypeChangesAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Allocator), typeof(bool), typeof(bool)}, ReturnType = typeof(TypeDispatchData))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TypeDispatchData GetTypeChangesAndClear(Allocator allocator, bool sortByInstanceID = false, bool noScriptingArray = false) { }

	[CalledBy(Type = typeof(ObjectDispatcher), Member = "GetTypeChangesAndClear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(bool), typeof(bool)}, ReturnType = typeof(TypeDispatchData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectDispatcher), Member = "ValidateTypeAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public TypeDispatchData GetTypeChangesAndClear(Type type, Allocator allocator, bool sortByInstanceID = false, bool noScriptingArray = false) { }

	[CalledBy(Type = typeof(ObjectDispatcher), Member = "DispatchTransformChangesAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(TransformTrackingType), typeof(System.Action`1<UnityEngine.TransformDispatchData>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectDispatcher), Member = "GetTransformChangesAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(TransformTrackingType), typeof(Allocator)}, ReturnType = typeof(TransformDispatchData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void ValidateComponentTypeAndThrow(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void ValidateSystemHandleAndThrow() { }

	[CalledBy(Type = typeof(ObjectDispatcher), Member = "DispatchTypeChangesAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Action`1<UnityEngine.TypeDispatchData>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectDispatcher), Member = "GetTypeChangesAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Allocator), typeof(bool), typeof(bool)}, ReturnType = typeof(TypeDispatchData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void ValidateTypeAndThrow(Type type) { }

}

