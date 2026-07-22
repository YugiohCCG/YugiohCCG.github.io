namespace UnityEngine.UIElements.UIR;

internal class Allocator2D
{
	internal struct Alloc2D
	{
		public RectInt rect; //Field offset: 0x0
		public Row row; //Field offset: 0x10
		public Alloc alloc; //Field offset: 0x18

		[CalledBy(Type = typeof(Allocator2D), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Alloc2D&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 3)]
		public Alloc2D(Row row, Alloc alloc, int width, int height) { }

	}

	internal class Area
	{
		public RectInt rect; //Field offset: 0x10
		public BestFitAllocator allocator; //Field offset: 0x20

		[CalledBy(Type = typeof(Allocator2D), Member = "BuildAreas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.Allocator2D+Area>), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public Area(RectInt rect) { }

	}

	internal class Row : LinkedPoolItem<Row>
	{
		public static readonly LinkedPool<Row> pool; //Field offset: 0x0
		public RectInt rect; //Field offset: 0x18
		public Area area; //Field offset: 0x28
		public BestFitAllocator allocator; //Field offset: 0x30
		public Alloc alloc; //Field offset: 0x38
		public Row next; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private static Row() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public Row() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private static Row Create() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		private static void Reset(Row row) { }

	}

	private readonly Vector2Int m_MinSize; //Field offset: 0x10
	private readonly Vector2Int m_MaxSize; //Field offset: 0x18
	private readonly Vector2Int m_MaxAllocSize; //Field offset: 0x20
	private readonly int m_RowHeightBias; //Field offset: 0x28
	private readonly Row[] m_Rows; //Field offset: 0x30
	private readonly List<Area> m_Areas; //Field offset: 0x38

	[CalledBy(Type = typeof(DynamicAtlasPage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(FilterMode), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "GetNextPow2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Allocator2D), Member = "BuildAreas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.Allocator2D+Area>), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "GetPrevPow2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UIRUtility), Member = "GetNextPow2Exp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) { }

	[CalledBy(Type = typeof(Allocator2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int), typeof(Vector2Int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Area), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static void BuildAreas(List<Area> areas, Vector2Int minSize, Vector2Int maxSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRUtility), Member = "GetNextPow2Exp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	private static Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRUtility), Member = "GetPrevPow2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Vector2Int ComputeMaxAllocSize(List<Area> areas, int rowHeightBias) { }

	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BestFitAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BestFitAllocator), Member = "get_highWatermark", ReturnType = typeof(uint))]
	[Calls(Type = typeof(UIRUtility), Member = "GetNextPow2Exp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public void Free(Alloc2D alloc2D) { }

	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Alloc2D&), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRUtility), Member = "GetNextPow2Exp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BestFitAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Alloc))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Alloc2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Row), typeof(Alloc), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public bool TryAllocate(int width, int height, out Alloc2D alloc2D) { }

}

