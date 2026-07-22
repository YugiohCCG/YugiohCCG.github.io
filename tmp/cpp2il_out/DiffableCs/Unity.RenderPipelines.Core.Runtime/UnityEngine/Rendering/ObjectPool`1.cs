namespace UnityEngine.Rendering;

public class ObjectPool
{
	internal struct PooledObject : IDisposable
	{
		private readonly T m_ToReturn; //Field offset: 0x0
		private readonly ObjectPool<T> m_Pool; //Field offset: 0x0

		[CallerCount(Count = 68)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal PooledObject(T value, ObjectPool<T> pool) { }

		[CalledBy(Type = typeof(DebugManager), Member = "GetItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(Widget[]))]
		[CalledBy(Type = typeof(DebugManager), Member = "GetItemsFromContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags), typeof(IContainer)}, ReturnType = typeof(Widget[]))]
		[CalledBy(Type = typeof(EnumField`1), Member = "AutoFillFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaskField), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VolumeManager), Member = "LoadBaseTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly Stack<T> m_Stack; //Field offset: 0x0
	private readonly UnityAction<T> m_ActionOnGet; //Field offset: 0x0
	private readonly UnityAction<T> m_ActionOnRelease; //Field offset: 0x0
	private readonly bool m_CollectionCheck; //Field offset: 0x0
	[CompilerGenerated]
	private int <countAll>k__BackingField; //Field offset: 0x0

	public int countActive
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 29
	}

	public private int countAll
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public int countInactive
	{
		[CallerCount(Count = 36)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	[CalledBy(Type = typeof(CommandBufferPool), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericPool`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListPool`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "CleanupStreaming", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AtlasAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public ObjectPool`1(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = true) { }

	[CalledBy(Type = typeof(CommandBufferPool), Member = "Get", ReturnType = typeof(CommandBuffer))]
	[CalledBy(Type = typeof(CommandBufferPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CommandBuffer))]
	[CalledBy(Type = typeof(GenericPool`1), Member = "Get", ReturnType = "T")]
	[CalledBy(Type = typeof(ListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "CleanupStreaming", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "PushDiskStreamingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell), typeof(string), typeof(int), typeof(OnStreamingCompleteDelegate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AddCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.AtlasAllocator+AtlasNode", Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPool`1<AtlasNode>&), typeof(int), typeof(int), typeof(bool)}, ReturnType = "UnityEngine.Rendering.AtlasAllocator+AtlasNode")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T Get() { }

	[CalledBy(Type = typeof(GenericPool`1), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "UnityEngine.Rendering.ObjectPool`1<T>+PooledObject<T>")]
	[CalledBy(Type = typeof(ListPool`1), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>&"}, ReturnType = "UnityEngine.Rendering.ObjectPool`1<List`1<T>>+PooledObject<List`1<T>>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public PooledObject<T> Get(out T v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_countActive() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_countAll() { }

	[CallerCount(Count = 36)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_countInactive() { }

	[CalledBy(Type = typeof(CommandBufferPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PooledObject), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateActiveRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ProcessNewRequests", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RemoveCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.AtlasAllocator+AtlasNode", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPool`1<AtlasNode>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Release(T element) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_countAll(int value) { }

}

