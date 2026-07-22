namespace UnityEngine.UIElements;

internal class ObjectPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Func<T> <>9__6_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[DeduplicatedMethod]
		internal T <.ctor>b__6_0() { }

	}

	private readonly Stack<T> m_Stack; //Field offset: 0x0
	private int m_MaxSize; //Field offset: 0x0
	internal Func<T> CreateFunc; //Field offset: 0x0

	public int maxSize
	{
		[CallerCount(Count = 42)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 216
	}

	[CalledBy(Type = typeof(EventDispatcher), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropagationPaths), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+Row", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementListPool), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectListPool`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusChangeTarget), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public ObjectPool`1(Func<T> CreateFunc, int maxSize = 100) { }

	[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "TryPartitionArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "System.Func`4<T, T, Single, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetFocusChangeDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(FocusChangeDirection))]
	[CalledBy(Type = typeof(VisualElementFocusChangeTarget), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(VisualElementFocusChangeTarget))]
	[CalledBy(Type = typeof(VisualElementListPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
	[CalledBy(Type = typeof(VisualElementListPool), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+Row", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = "UnityEngine.UIElements.UIRAtlasAllocator+Row")]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = "UnityEngine.UIElements.UIRAtlasAllocator+AreaNode")]
	[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = "T")]
	[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[CalledBy(Type = typeof(EventDispatcher), Member = "ProcessEventQueue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatcher), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatcher), Member = "CreateDefault", ReturnType = typeof(EventDispatcher))]
	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T Get() { }

	[CallerCount(Count = 42)]
	[DeduplicatedMethod]
	public int get_maxSize() { }

	[CalledBy(Type = typeof(VisualElementListPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TabView+ViewState", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase`1), Member = "ReleasePooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropagationPaths), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+Row", Member = "Release", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", Member = "Release", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusChangeTarget), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Recycle", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Release(T element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_maxSize(int value) { }

	[CallerCount(Count = 36)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int Size() { }

}

