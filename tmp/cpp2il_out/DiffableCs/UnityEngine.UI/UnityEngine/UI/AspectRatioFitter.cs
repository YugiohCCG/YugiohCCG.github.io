namespace UnityEngine.UI;

[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
{
	internal enum AspectMode
	{
		None = 0,
		WidthControlsHeight = 1,
		HeightControlsWidth = 2,
		FitInParent = 3,
		EnvelopeParent = 4,
	}

	[SerializeField]
	private AspectMode m_AspectMode; //Field offset: 0x20
	[SerializeField]
	private float m_AspectRatio; //Field offset: 0x24
	private RectTransform m_Rect; //Field offset: 0x28
	private bool m_DelayedSetDirty; //Field offset: 0x30
	private bool m_DoesParentExist; //Field offset: 0x31
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x32

	public AspectMode aspectMode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		 set { } //Length: 86
	}

	public float aspectRatio
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		 set { } //Length: 89
	}

	private RectTransform rectTransform
	{
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "GetSizeDeltaToProduceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 141
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected AspectRatioFitter() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool DoesParentExists() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public AspectMode get_aspectMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_aspectRatio() { }

	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "GetSizeDeltaToProduceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private RectTransform get_rectTransform() { }

	[CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "GetSizeDeltaToProduceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Vector2 GetParentSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool IsAspectModeValid() { }

	[CalledBy(Type = typeof(AspectRatioFitter), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_isRootCanvas", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsComponentValidOnObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected virtual void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	protected virtual void OnTransformParentChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	public void set_aspectMode(AspectMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	public void set_aspectRatio(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected void SetDirty() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void SetLayoutHorizontal() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void SetLayoutVertical() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	protected override void Update() { }

	[CalledBy(Type = typeof(AspectRatioFitter), Member = "set_aspectMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AspectMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "set_aspectRatio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "SetDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void UpdateRect() { }

}

