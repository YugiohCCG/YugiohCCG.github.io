namespace UnityEngine.UI;

public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
{
	internal class CullStateChangedEvent : UnityEvent<Boolean>
	{

		[CalledBy(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		public CullStateChangedEvent() { }

	}

	protected bool m_ShouldRecalculateStencil; //Field offset: 0xA8
	protected Material m_MaskMaterial; //Field offset: 0xB0
	private RectMask2D m_ParentMask; //Field offset: 0xB8
	[SerializeField]
	private bool m_Maskable; //Field offset: 0xC0
	private bool m_IsMaskingGraphic; //Field offset: 0xC1
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore.", True)]
	protected bool m_IncludeForMasking; //Field offset: 0xC2
	[SerializeField]
	private CullStateChangedEvent m_OnCullStateChanged; //Field offset: 0xC8
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore", True)]
	protected bool m_ShouldRecalculate; //Field offset: 0xD0
	protected int m_StencilValue; //Field offset: 0xD4
	private readonly Vector3[] m_Corners; //Field offset: 0xD8

	public bool isMaskingGraphic
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 15
	}

	public bool maskable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshProUGUI", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMeshUI")]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "SyncSubmeshGraphicsWithCanvasRenderers", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "EnsureCanvasRendererCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public CullStateChangedEvent onCullStateChanged
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	private Rect rootCanvasRect
	{
		[CalledBy(Type = typeof(MaskableGraphic), Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 705
	}

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SelectionCaret", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawImage), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonSubmeshGraphic", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CullStateChangedEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected MaskableGraphic() { }

	[CalledBy(Type = "TMPro.TMP_SelectionCaret", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaskableGraphic), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public override void Cull(Rect clipRect, bool validRect) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isMaskingGraphic() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_maskable() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public CullStateChangedEvent get_onCullStateChanged() { }

	[CalledBy(Type = typeof(MaskableGraphic), Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 2)]
	private Rect get_rootCanvasRect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MaskUtilities), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MaskUtilities), Member = "GetStencilDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StencilMaterial), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int), typeof(StencilOp), typeof(CompareFunction), typeof(ColorWriteMask), typeof(int), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnCanvasHierarchyChanged() { }

	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskUtilities), Member = "NotifyStencilStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CalledBy(Type = typeof(Image), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphic), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskUtilities), Member = "NotifyStencilStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnEnable() { }

	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnTransformParentChanged() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore.", True)]
	public override void ParentMaskStateChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "RecalculateClipping", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "RecalculateClipping", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	public override void RecalculateClipping() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void RecalculateMasking() { }

	[CallerCount(Count = 0)]
	public void set_isMaskingGraphic(bool value) { }

	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshProUGUI", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMeshUI")]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "SyncSubmeshGraphicsWithCanvasRenderers", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "EnsureCanvasRendererCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_maskable(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_onCullStateChanged(CullStateChangedEvent value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "DisableRectClipping", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "EnableRectClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void SetClipRect(Rect clipRect, bool validRect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_clippingSoftness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void SetClipSoftness(Vector2 clipSoftness) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	private override GameObject UnityEngine.UI.IClippable.get_gameObject() { }

	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "RecalculateClipping", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MaskUtilities), Member = "GetRectMaskForClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClippable)}, ReturnType = typeof(RectMask2D))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectMask2D), Member = "RemoveClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClippable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectMask2D), Member = "AddClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClippable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateClipParent() { }

	[CalledBy(Type = typeof(MaskableGraphic), Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCull(bool cull) { }

}

