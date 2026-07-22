namespace UnityEngine.UIElements.UIR;

internal struct BitmapAllocator32
{
	private struct Page
	{
		public ushort x; //Field offset: 0x0
		public ushort y; //Field offset: 0x2
		public int freeSlots; //Field offset: 0x4

	}

	private int m_PageHeight; //Field offset: 0x0
	private List<Page> m_Pages; //Field offset: 0x8
	private List<UInt32> m_AllocMap; //Field offset: 0x10
	private int m_EntryWidth; //Field offset: 0x18
	private int m_EntryHeight; //Field offset: 0x1C

	public int entryHeight
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public int entryWidth
	{
		[CallerCount(Count = 42)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocTransform", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocClipRect", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocOpacity", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocColor", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextCoreSettings)}, ReturnType = typeof(BMPAlloc))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "CountTrailingZeroes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public BMPAlloc Allocate(BaseShaderInfoStorage storage) { }

	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1) { }

	[CalledBy(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	[CallerCount(Count = 1)]
	private static byte CountTrailingZeroes(uint val) { }

	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY) { }

	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeClipRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeOpacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Free(BMPAlloc alloc) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public int get_entryHeight() { }

	[CallerCount(Count = 42)]
	[DeduplicatedMethod]
	public int get_entryWidth() { }

	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AtlasRectMatchesPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc), typeof(RectInt)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "TransformAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ClipRectAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "OpacityAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ColorAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "TextCoreSettingsToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y) { }

}

