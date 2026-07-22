namespace UnityEngine.UIElements;

internal class DynamicAtlas : AtlasBase
{
	public class TextureInfo : LinkedPoolItem<TextureInfo>
	{
		public static readonly LinkedPool<TextureInfo> pool; //Field offset: 0x0
		public DynamicAtlasPage page; //Field offset: 0x18
		public int counter; //Field offset: 0x20
		public Alloc2D alloc; //Field offset: 0x28
		public RectInt rect; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private static TextureInfo() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public TextureInfo() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private static TextureInfo Create() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static void Reset(TextureInfo info) { }

	}

	private Dictionary<Texture, TextureInfo> m_Database; //Field offset: 0x18
	private DynamicAtlasPage m_PointPage; //Field offset: 0x20
	private DynamicAtlasPage m_BilinearPage; //Field offset: 0x28
	private ColorSpace m_ColorSpace; //Field offset: 0x30
	private List<IPanel> m_Panels; //Field offset: 0x38
	private int m_MinAtlasSize; //Field offset: 0x40
	private int m_MaxAtlasSize; //Field offset: 0x44
	private int m_MaxSubTextureSize; //Field offset: 0x48
	private DynamicAtlasFilters m_ActiveFilters; //Field offset: 0x4C
	private DynamicAtlasCustomFilter m_CustomFilter; //Field offset: 0x50

	public DynamicAtlasFilters activeFilters
	{
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 26
	}

	public DynamicAtlasCustomFilter customFilter
	{
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 78
	}

	public static DynamicAtlasFilters defaultFilters
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	internal bool isInitialized
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 23
	}

	public int maxAtlasSize
	{
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 26
	}

	public int maxSubTextureSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 26
	}

	public int minAtlasSize
	{
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 26
	}

	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public DynamicAtlas() { }

	[CalledBy(Type = typeof(DynamicAtlas), Member = "OnRemovedFromPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicAtlas), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicAtlasPage), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void DestroyPages() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static DynamicAtlasFilters get_defaultFilters() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_isInitialized() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_maxSubTextureSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicAtlasPage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(FilterMode), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InitPages() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	internal static bool IsTextureFormatSupported(TextureFormat format) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsInvalidInstructions]
	public override bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void OnAssignedToPanel(IPanel panel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicAtlas), Member = "DestroyPages", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnRemovedFromPanel(IPanel panel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicAtlasPage), Member = "Commit", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureRegistry), Member = "UpdateDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(Texture)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnUpdateDynamicTextures(IPanel panel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicAtlas), Member = "DestroyPages", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "RepaintTexturedElements", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicAtlasPage), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas) { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_activeFilters(DynamicAtlasFilters value) { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_maxAtlasSize(int value) { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_maxSubTextureSize(int value) { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_minAtlasSize(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicAtlasPage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(FilterMode), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicAtlasPage), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Alloc2D&), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public virtual bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

}

