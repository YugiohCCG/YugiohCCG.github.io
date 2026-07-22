namespace UnityEngine.UI;

public class CanvasUpdateRegistry
{
	private static CanvasUpdateRegistry s_Instance; //Field offset: 0x0
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull"; //Field offset: 0x0
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; //Field offset: 0x8
	private bool m_PerformingLayoutUpdate; //Field offset: 0x10
	private bool m_PerformingGraphicUpdate; //Field offset: 0x11
	private String[] m_CanvasUpdateProfilerStrings; //Field offset: 0x18
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; //Field offset: 0x20
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; //Field offset: 0x28

	public static CanvasUpdateRegistry instance
	{
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Graphic), Member = "OnCullingChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Graphic), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Graphic), Member = "SetMaterialDirty", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Graphic), Member = "SetVerticesDirty", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingGraphics", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalDisableCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalDisableCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalUnRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "DisableCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalUnRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 219
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static CanvasUpdateRegistry() { }

	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IndexedSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "add_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	protected CanvasUpdateRegistry() { }

	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IndexedSet`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(IndexedSet`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void CleanInvalidItems() { }

	[CalledBy(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "DisableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalUnRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "DisableCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalDisableCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalUnRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingGraphics", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Graphic), Member = "SetVerticesDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "SetMaterialDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnCullingChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalDisableCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static CanvasUpdateRegistry get_instance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "DisableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "DisableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Graphic), Member = "SetVerticesDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "SetMaterialDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnCullingChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(IndexedSet`1), Member = "AddUnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IndexedSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndexedSet`1), Member = "AddUnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetVerticesDirty", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetMaterialDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "FontTextureChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsRebuildingGraphics() { }

	[CalledBy(Type = typeof(LayoutGroup), Member = "OnChildRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "EnsureLayoutHasRebuilt", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "FontTextureChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsRebuildingLayout() { }

	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "SortLayoutList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement), typeof(ICanvasElement)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static int ParentCount(Transform child) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SampleType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "CleanInvalidItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexedSet`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "ObjectValidForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SampleType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void PerformUpdate() { }

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "set_autoSizeTextContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "ParentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[CalledBy(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "MarkLayoutRootForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

}

