namespace UnityEngine.UI;

[AddComponentMenu("UI/Rect Mask 2D", 14)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
{
	private readonly RectangularVertexClipper m_VertexClipper; //Field offset: 0x20
	private RectTransform m_RectTransform; //Field offset: 0x28
	private HashSet<MaskableGraphic> m_MaskableTargets; //Field offset: 0x30
	private HashSet<IClippable> m_ClipTargets; //Field offset: 0x38
	private bool m_ShouldRecalculateClipRects; //Field offset: 0x40
	private List<RectMask2D> m_Clippers; //Field offset: 0x48
	private Rect m_LastClipRectCanvasSpace; //Field offset: 0x50
	private bool m_ForceClip; //Field offset: 0x60
	[SerializeField]
	private Vector4 m_Padding; //Field offset: 0x64
	[SerializeField]
	private Vector2Int m_Softness; //Field offset: 0x74
	private Canvas m_Canvas; //Field offset: 0x80
	private Vector3[] m_Corners; //Field offset: 0x88

	internal Canvas Canvas
	{
		[CalledBy(Type = typeof(RectMask2D), Member = "get_canvasRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(RectMask2D), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RectMask2D), Member = "UpdateClipSoftness", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 358
	}

	public Rect canvasRect
	{
		[CalledBy(Type = typeof(Clipping), Member = "FindCullAndClipWorldRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D>), typeof(Boolean&)}, ReturnType = typeof(Rect))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(RectangularVertexClipper), Member = "GetCanvasRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Canvas)}, ReturnType = typeof(Rect))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 157
	}

	public Vector4 padding
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
		 set { } //Length: 14
	}

	public RectTransform rectTransform
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 99
	}

	private Rect rootCanvasRect
	{
		[CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 480
	}

	public Vector2Int softness
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
		 set { } //Length: 33
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectangularVertexClipper), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected RectMask2D() { }

	[CalledBy(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddClippable(IClippable clippable) { }

	[CalledBy(Type = typeof(RectMask2D), Member = "get_canvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(RectMask2D), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RectMask2D), Member = "UpdateClipSoftness", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal Canvas get_Canvas() { }

	[CalledBy(Type = typeof(Clipping), Member = "FindCullAndClipWorldRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D>), typeof(Boolean&)}, ReturnType = typeof(Rect))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(RectangularVertexClipper), Member = "GetCanvasRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Canvas)}, ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 2)]
	public Rect get_canvasRect() { }

	[CallerCount(Count = 0)]
	public Vector4 get_padding() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public RectTransform get_rectTransform() { }

	[CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 3)]
	private Rect get_rootCanvasRect() { }

	[CallerCount(Count = 0)]
	public Vector2Int get_softness() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector4)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void OnCanvasHierarchyChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClipperRegistry), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClipperRegistry), Member = "Disable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClipperRegistry), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void OnTransformParentChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(MaskUtilities), Member = "GetRectMasksForClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectMask2D), typeof(System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Clipping), Member = "FindCullAndClipWorldRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D>), typeof(Boolean&)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(RectMask2D), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_hasMoved", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	public override void PerformClipping() { }

	[CalledBy(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveClippable(IClippable clippable) { }

	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	public void set_padding(Vector4 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	public void set_softness(Vector2Int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public override void UpdateClipSoftness() { }

}

