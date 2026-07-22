namespace UnityEngine.Rendering;

internal class AtlasAllocator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction<AtlasNode> <>9__6_0; //Field offset: 0x8
		public static UnityAction<AtlasNode> <>9__6_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <.ctor>b__6_0(AtlasNode _) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <.ctor>b__6_1(AtlasNode _) { }

	}

	private class AtlasNode
	{
		public AtlasNode m_RightChild; //Field offset: 0x10
		public AtlasNode m_BottomChild; //Field offset: 0x18
		public Vector4 m_Rect; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public AtlasNode() { }

		[CalledBy(Type = typeof(AtlasNode), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPool`1<AtlasNode>&), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(AtlasNode))]
		[CalledBy(Type = typeof(AtlasAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
		[Calls(Type = typeof(AtlasNode), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPool`1<AtlasNode>&), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(AtlasNode))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		public AtlasNode Allocate(ref ObjectPool<AtlasNode>& pool, int width, int height, bool powerOfTwoPadding) { }

		[CalledBy(Type = typeof(AtlasNode), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPool`1<AtlasNode>&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AtlasAllocator), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Texture2DAtlas), Member = "ResetAllocator", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(AtlasNode), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPool`1<AtlasNode>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public void Release(ref ObjectPool<AtlasNode>& pool) { }

	}

	private AtlasNode m_Root; //Field offset: 0x10
	private int m_Width; //Field offset: 0x18
	private int m_Height; //Field offset: 0x1C
	private bool powerOfTwoPadding; //Field offset: 0x20
	private ObjectPool<AtlasNode> m_NodePool; //Field offset: 0x28

	[CalledBy(Type = typeof(Texture2DAtlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(FilterMode), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T>", "UnityEngine.Events.UnityAction`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public AtlasAllocator(int width, int height, bool potPadding) { }

	[CalledBy(Type = typeof(Texture2DAtlas), Member = "AllocateTextureWithoutBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Vector4&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "EnsureTextureSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&), typeof(Vector4&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AtlasNode), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPool`1<AtlasNode>&), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(AtlasNode))]
	[CallsUnknownMethods(Count = 1)]
	public bool Allocate(ref Vector4 result, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AtlasNode), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPool`1<AtlasNode>&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Reset() { }

}

