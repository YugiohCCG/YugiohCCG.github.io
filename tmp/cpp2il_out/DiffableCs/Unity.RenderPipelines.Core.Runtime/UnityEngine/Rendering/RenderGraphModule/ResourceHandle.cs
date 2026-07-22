namespace UnityEngine.Rendering.RenderGraphModule;

internal struct ResourceHandle : IEquatable<ResourceHandle>
{
	private const uint kValidityMask = 4294901760; //Field offset: 0x0
	private const uint kIndexMask = 65535; //Field offset: 0x0
	private static uint s_CurrentValidBit; //Field offset: 0x0
	private static uint s_SharedResourceValidBit; //Field offset: 0x4
	private uint m_Value; //Field offset: 0x0
	private int m_Version; //Field offset: 0x4
	[CompilerGenerated]
	private RenderGraphResourceType <type>k__BackingField; //Field offset: 0x8

	public int index
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool IsVersioned
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public int iType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 67
	}

	public private RenderGraphResourceType type
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public int version
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	private static ResourceHandle() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "GenerateCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal ResourceHandle(int value, RenderGraphResourceType type, bool shared) { }

	[CallerCount(Count = 0)]
	internal ResourceHandle(in ResourceHandle h, int version) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(ResourceHandle hdl) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public int get_index() { }

	[CallerCount(Count = 0)]
	public bool get_IsVersioned() { }

	[CallerCount(Count = 0)]
	public int get_iType() { }

	[CallerCount(Count = 28)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public RenderGraphResourceType get_type() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_version() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool IsNull() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool IsValid() { }

	[CallerCount(Count = 0)]
	public static void NewFrame(int executionIndex) { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_type(RenderGraphResourceType value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_version(int value) { }

}

