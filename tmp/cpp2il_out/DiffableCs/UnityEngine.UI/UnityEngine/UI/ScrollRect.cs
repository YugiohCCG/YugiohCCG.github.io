namespace UnityEngine.UI;

[AddComponentMenu("UI/Scroll Rect", 37)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[SelectionBase]
public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
{
	internal enum MovementType
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2,
	}

	internal enum ScrollbarVisibility
	{
		Permanent = 0,
		AutoHide = 1,
		AutoHideAndExpandViewport = 2,
	}

	internal class ScrollRectEvent : UnityEvent<Vector2>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ScrollRectEvent() { }

	}

	[SerializeField]
	private RectTransform m_Content; //Field offset: 0x20
	[SerializeField]
	private bool m_Horizontal; //Field offset: 0x28
	[SerializeField]
	private bool m_Vertical; //Field offset: 0x29
	[SerializeField]
	private MovementType m_MovementType; //Field offset: 0x2C
	[SerializeField]
	private float m_Elasticity; //Field offset: 0x30
	[SerializeField]
	private bool m_Inertia; //Field offset: 0x34
	[SerializeField]
	private float m_DecelerationRate; //Field offset: 0x38
	[SerializeField]
	private float m_ScrollSensitivity; //Field offset: 0x3C
	[SerializeField]
	private RectTransform m_Viewport; //Field offset: 0x40
	[SerializeField]
	private Scrollbar m_HorizontalScrollbar; //Field offset: 0x48
	[SerializeField]
	private Scrollbar m_VerticalScrollbar; //Field offset: 0x50
	[SerializeField]
	private ScrollbarVisibility m_HorizontalScrollbarVisibility; //Field offset: 0x58
	[SerializeField]
	private ScrollbarVisibility m_VerticalScrollbarVisibility; //Field offset: 0x5C
	[SerializeField]
	private float m_HorizontalScrollbarSpacing; //Field offset: 0x60
	[SerializeField]
	private float m_VerticalScrollbarSpacing; //Field offset: 0x64
	[SerializeField]
	private ScrollRectEvent m_OnValueChanged; //Field offset: 0x68
	private Vector2 m_PointerStartLocalCursor; //Field offset: 0x70
	protected Vector2 m_ContentStartPosition; //Field offset: 0x78
	private RectTransform m_ViewRect; //Field offset: 0x80
	protected Bounds m_ContentBounds; //Field offset: 0x88
	private Bounds m_ViewBounds; //Field offset: 0xA0
	private Vector2 m_Velocity; //Field offset: 0xB8
	private bool m_Dragging; //Field offset: 0xC0
	private bool m_Scrolling; //Field offset: 0xC1
	private Vector2 m_PrevPosition; //Field offset: 0xC4
	private Bounds m_PrevContentBounds; //Field offset: 0xCC
	private Bounds m_PrevViewBounds; //Field offset: 0xE4
	private bool m_HasRebuiltLayout; //Field offset: 0xFC
	private bool m_HSliderExpand; //Field offset: 0xFD
	private bool m_VSliderExpand; //Field offset: 0xFE
	private float m_HSliderHeight; //Field offset: 0x100
	private float m_VSliderWidth; //Field offset: 0x104
	private RectTransform m_Rect; //Field offset: 0x108
	private RectTransform m_HorizontalScrollbarRect; //Field offset: 0x110
	private RectTransform m_VerticalScrollbarRect; //Field offset: 0x118
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x120
	private readonly Vector3[] m_Corners; //Field offset: 0x128

	public RectTransform content
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float decelerationRate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float elasticity
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public override float flexibleHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public override float flexibleWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public bool horizontal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float horizontalNormalizedPosition
	{
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "GetScrollRectNormalizedPosition", ReturnType = typeof(float))]
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectController", Member = "UpdateContent", ReturnType = typeof(void))]
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateContent", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass30_0", Member = "<DONormalizedPos>b__0", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass31_0", Member = "<DOHorizontalNormalizedPos>b__0", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "get_normalizedPosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetHorizontalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 215
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "ResetPosition", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass30_0", Member = "<DONormalizedPos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass31_0", Member = "<DOHorizontalNormalizedPos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 20
	}

	public Scrollbar horizontalScrollbar
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 395
	}

	public float horizontalScrollbarSpacing
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
		 set { } //Length: 12
	}

	public ScrollbarVisibility horizontalScrollbarVisibility
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		 set { } //Length: 10
	}

	private bool hScrollingNeeded
	{
		[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 121
	}

	public bool inertia
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override int layoutPriority
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public override float minHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public override float minWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public MovementType movementType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Vector2 normalizedPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
		 get { } //Length: 53
		[CalledBy(Type = "Extensions.General", Member = "ScrollToTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollRect)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "ScrollToBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollRect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 76
	}

	public ScrollRectEvent onValueChanged
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public override float preferredHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public override float preferredWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	private RectTransform rectTransform
	{
		[CalledBy(Type = typeof(ScrollRect), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 153
	}

	public float scrollSensitivity
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Vector2 velocity
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		 set { } //Length: 8
	}

	public bool vertical
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float verticalNormalizedPosition
	{
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "GetScrollRectNormalizedPosition", ReturnType = typeof(float))]
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectController", Member = "UpdateContent", ReturnType = typeof(void))]
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateContent", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass30_0", Member = "<DONormalizedPos>b__0", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass32_0", Member = "<DOVerticalNormalizedPos>b__0", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerPanel", Member = "UpdateScroll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "get_normalizedPosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetVerticalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "EnsureScrollViewIsWithinBounds", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 215
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "ResetPosition", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass30_0", Member = "<DONormalizedPos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass32_0", Member = "<DOVerticalNormalizedPos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerPanel", Member = "UpdateScroll", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<CreateNewFolderCoroutine>d__226", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RenameSelectedFile", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "EnsureScrollViewIsWithinBounds", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "<CreateNewFolderCoroutine>b__226_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 23
	}

	public Scrollbar verticalScrollbar
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 395
	}

	public float verticalScrollbarSpacing
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
		 set { } //Length: 12
	}

	public ScrollbarVisibility verticalScrollbarVisibility
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		 set { } //Length: 10
	}

	public RectTransform viewport
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 37
	}

	protected RectTransform viewRect
	{
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateCachedData", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 293
	}

	private bool vScrollingNeeded
	{
		[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 121
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected ScrollRect() { }

	[CallerCount(Count = 0)]
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputHorizontal() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputVertical() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	private Vector2 CalculateOffset(Vector2 delta) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	private void EnsureLayoutHasRebuilt() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public RectTransform get_content() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_decelerationRate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_elasticity() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_flexibleHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_flexibleWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_horizontal() { }

	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "GetScrollRectNormalizedPosition", ReturnType = typeof(float))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectController", Member = "UpdateContent", ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateContent", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass30_0", Member = "<DONormalizedPos>b__0", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass31_0", Member = "<DOHorizontalNormalizedPos>b__0", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "get_normalizedPosition", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetHorizontalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public float get_horizontalNormalizedPosition() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public Scrollbar get_horizontalScrollbar() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_horizontalScrollbarSpacing() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool get_hScrollingNeeded() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_inertia() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override int get_layoutPriority() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_minHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_minWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MovementType get_movementType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	public Vector2 get_normalizedPosition() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public ScrollRectEvent get_onValueChanged() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_preferredHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_preferredWidth() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private RectTransform get_rectTransform() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_scrollSensitivity() { }

	[CallerCount(Count = 0)]
	public Vector2 get_velocity() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_vertical() { }

	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "GetScrollRectNormalizedPosition", ReturnType = typeof(float))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectController", Member = "UpdateContent", ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateContent", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass30_0", Member = "<DONormalizedPos>b__0", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass32_0", Member = "<DOVerticalNormalizedPos>b__0", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerPanel", Member = "UpdateScroll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "get_normalizedPosition", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetVerticalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "EnsureScrollViewIsWithinBounds", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public float get_verticalNormalizedPosition() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public Scrollbar get_verticalScrollbar() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_verticalScrollbarSpacing() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public ScrollbarVisibility get_verticalScrollbarVisibility() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public RectTransform get_viewport() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateCachedData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 4)]
	protected RectTransform get_viewRect() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool get_vScrollingNeeded() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(ScrollRect), Member = "InternalGetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(Matrix4x4&)}, ReturnType = typeof(Bounds))]
	[CallsUnknownMethods(Count = 1)]
	private Bounds GetBounds() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void GraphicUpdateComplete() { }

	[CallerCount(Count = 0)]
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta) { }

	[CalledBy(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 2)]
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIBehaviour), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public virtual bool IsActive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateOneScrollbarVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(ScrollbarVisibility), typeof(Scrollbar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdatePrevData", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<UnityEngine.Vector2>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "CalculateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	protected override void LateUpdate() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void LayoutComplete() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "CalculateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "RubberDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void OnDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnEndDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	protected virtual void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventData), Member = "IsScrolling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "CalculateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnScroll(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateCachedData", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdatePrevData", ReturnType = typeof(void))]
	public override void Rebuild(CanvasUpdate executing) { }

	[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private static float RubberDelta(float overStretching, float viewSize) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_content(RectTransform value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_decelerationRate(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_elasticity(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_horizontal(bool value) { }

	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "ResetPosition", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass30_0", Member = "<DONormalizedPos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass31_0", Member = "<DOHorizontalNormalizedPos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_horizontalNormalizedPosition(float value) { }

	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void set_horizontalScrollbar(Scrollbar value) { }

	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	public void set_horizontalScrollbarSpacing(float value) { }

	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	public void set_horizontalScrollbarVisibility(ScrollbarVisibility value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_inertia(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_movementType(MovementType value) { }

	[CalledBy(Type = "Extensions.General", Member = "ScrollToTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollRect)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "ScrollToBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollRect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_normalizedPosition(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_onValueChanged(ScrollRectEvent value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_scrollSensitivity(float value) { }

	[CallerCount(Count = 0)]
	public void set_velocity(Vector2 value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_vertical(bool value) { }

	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "ResetPosition", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass30_0", Member = "<DONormalizedPos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass32_0", Member = "<DOVerticalNormalizedPos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerPanel", Member = "UpdateScroll", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<CreateNewFolderCoroutine>d__226", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RenameSelectedFile", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "EnsureScrollViewIsWithinBounds", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "<CreateNewFolderCoroutine>b__226_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_verticalNormalizedPosition(float value) { }

	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void set_verticalScrollbar(Scrollbar value) { }

	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	public void set_verticalScrollbarSpacing(float value) { }

	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	public void set_verticalScrollbarVisibility(ScrollbarVisibility value) { }

	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_viewport(RectTransform value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected override void SetContentAnchoredPosition(Vector2 position) { }

	[CalledBy(Type = typeof(ScrollRect), Member = "set_horizontalScrollbarSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_verticalScrollbarSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScrollRect), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void SetDirty() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "set_viewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_horizontalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scrollbar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_verticalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scrollbar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_horizontalScrollbarVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollbarVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_verticalScrollbarVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollbarVisibility)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void SetDirtyCaching() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetHorizontalNormalizedPosition(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateCachedData", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "ForceRebuildLayoutImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void SetLayoutHorizontal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
	[CallsUnknownMethods(Count = 1)]
	public override void SetLayoutVertical() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 33)]
	protected override void SetNormalizedPosition(float value, int axis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetVerticalNormalizedPosition(float value) { }

	[CallerCount(Count = 0)]
	public override void StopMovement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetContentAnchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdateBounds() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void UpdateCachedData() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	[CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdatePrevData() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateScrollbarLayout() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateScrollbars(Vector2 offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateOneScrollbarVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(ScrollbarVisibility), typeof(Scrollbar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
	private void UpdateScrollbarVisibility() { }

}

