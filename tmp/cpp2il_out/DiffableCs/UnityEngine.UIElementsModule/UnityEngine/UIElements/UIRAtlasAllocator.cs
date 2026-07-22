namespace UnityEngine.UIElements;

internal class UIRAtlasAllocator : IDisposable
{
	private class AreaNode
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
			[CallsDeduplicatedMethods(Count = 1)]
			internal AreaNode <.cctor>b__9_0() { }

		}

		private static ObjectPool<AreaNode> s_Pool; //Field offset: 0x0
		public RectInt rect; //Field offset: 0x10
		public AreaNode previous; //Field offset: 0x20
		public AreaNode next; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static AreaNode() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AreaNode() { }

		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "BuildAreas", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		public static AreaNode Acquire(RectInt rect) { }

		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "BuildAreas", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Assert), Member = "IsNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void AddAfter(AreaNode previous) { }

		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "TryPartitionArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AreaNode), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Release() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public void RemoveFromChain() { }

	}

	private class Row
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
			[CallsDeduplicatedMethods(Count = 1)]
			internal Row <.cctor>b__21_0() { }

		}

		private static ObjectPool<Row> s_Pool; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <offsetX>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <offsetY>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <width>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <height>k__BackingField; //Field offset: 0x1C
		public int Cursor; //Field offset: 0x20

		private int height
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private int offsetX
		{
			[CallerCount(Count = 94)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 7)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private int offsetY
		{
			[CallerCount(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 5)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private int width
		{
			[CallerCount(Count = 7)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static Row() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Row() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		public static Row Acquire(int offsetX, int offsetY, int width, int height) { }

		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_offsetX() { }

		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_offsetY() { }

		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_width() { }

		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "TryPartitionArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Release() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_height(int value) { }

		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_offsetX(int value) { }

		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_offsetY(int value) { }

		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_width(int value) { }

	}

	private static ProfilerMarker s_MarkerTryAllocate; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <maxAtlasSize>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <maxImageWidth>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <maxImageHeight>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <virtualWidth>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <virtualHeight>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <physicalWidth>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <physicalHeight>k__BackingField; //Field offset: 0x28
	private AreaNode m_FirstUnpartitionedArea; //Field offset: 0x30
	private Row[] m_OpenRows; //Field offset: 0x38
	private int m_1SidePadding; //Field offset: 0x40
	private int m_2SidePadding; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x48

	protected private bool disposed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public int maxAtlasSize
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int maxImageHeight
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int maxImageWidth
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public private int physicalHeight
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int physicalWidth
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int virtualHeight
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int virtualWidth
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static UIRAtlasAllocator() { }

	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "AllocateRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRAtlasAllocator), Member = "GetLog2OfNextPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AreaNode), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(AreaNode))]
	[Calls(Type = typeof(AreaNode), Member = "AddAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AreaNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AreaNode), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(AreaNode))]
	[Calls(Type = typeof(AreaNode), Member = "AddAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AreaNode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void BuildAreas() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Row), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected override void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected bool get_disposed() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_maxAtlasSize() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_maxImageHeight() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_maxImageWidth() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_physicalHeight() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_physicalWidth() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_virtualHeight() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_virtualWidth() { }

	[CalledBy(Type = typeof(UIRAtlasAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int GetLog2OfNextPower(int n) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_disposed(bool value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_physicalHeight(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_physicalWidth(int value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_virtualHeight(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_virtualWidth(int value) { }

	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "AllocateRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRAtlasAllocator), Member = "GetLog2OfNextPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UIRAtlasAllocator), Member = "TryPartitionArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AreaNode), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public bool TryAllocate(int width, int height, out RectInt location) { }

	[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Row), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(AreaNode), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth) { }

}

