namespace UnityEngine.Pool;

public class ObjectPool : IDisposable, IPool, IObjectPool<T>
{
	internal readonly List<T> m_List; //Field offset: 0x0
	private readonly Func<T> m_CreateFunc; //Field offset: 0x0
	private readonly Action<T> m_ActionOnGet; //Field offset: 0x0
	private readonly Action<T> m_ActionOnRelease; //Field offset: 0x0
	private readonly Action<T> m_ActionOnDestroy; //Field offset: 0x0
	private readonly int m_MaxSize; //Field offset: 0x0
	internal bool m_CollectionCheck; //Field offset: 0x0
	private T m_FreshlyReleased; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <CountAll>k__BackingField; //Field offset: 0x0

	public private int CountAll
	{
		[CallerCount(Count = 26)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public override int CountInactive
	{
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+ManagedJobData", Member = "Release", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool+SharedObjectPool`1", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Awaitable), Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GenericPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rigidbody", Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 35
	}

	[CalledBy(Type = typeof(GenericPool`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.PropertyContainer+GetValueVisitor`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.PropertyContainer+GetPropertyVisitor", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable+<>c", Member = "<.cctor>b__76_0", ReturnType = typeof(UnityEngine.Pool.ObjectPool`1<UnityEngine.Awaitable>))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool+SharedObjectPool`1", Member = "AllocatePool", ReturnType = "UnityEngine.Pool.ObjectPool`1<T>")]
	[CalledBy(Type = typeof(CollectionPool`2), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.SetValueVisitor`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VerticalVirtualizationController`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVerticalCollectionView"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PoolManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public ObjectPool`1(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000) { }

	[CalledBy(Type = "UnityEngine.UIElements.VerticalVirtualizationController`1", Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool+SharedObjectPool`1", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectPool`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Clear", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroup", Member = "TrySetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", "Unity.Properties.PropertyPath&", "TValue", "Unity.Properties.VisitReturnCode&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", "UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextJobSystem", Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", "UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", "UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.MeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Material>&", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>&", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>&", "System.Collections.Generic.List`1<GlyphRenderMode>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.PropertyContainer", Member = "TryGetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", "Unity.Properties.PropertyPath&", "Unity.Properties.IProperty&", "Unity.Properties.VisitReturnCode&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Properties.PropertyContainer", Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", "Unity.Properties.PropertyPath&", "TValue&", "Unity.Properties.VisitReturnCode&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override T Get() { }

	[CalledBy(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[CalledBy(Type = typeof(GenericPool`1), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override PooledObject<T> Get(out T v) { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_CountAll() { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+ManagedJobData", Member = "Release", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool+SharedObjectPool`1", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Awaitable), Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rigidbody", Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override int get_CountInactive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void Release(T element) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CountAll(int value) { }

}

