namespace UnityEngine;

[NativeClass("UI::Canvas")]
[NativeHeader("Modules/UI/UIStructs.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[RequireComponent(typeof(RectTransform))]
public sealed class Canvas : Behaviour
{
	internal sealed class WillRenderCanvases : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public WillRenderCanvases(object object, IntPtr method) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static WillRenderCanvases preWillRenderCanvases; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static WillRenderCanvases willRenderCanvases; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32> <externBeginRenderOverlays>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32, Int32> <externRenderOverlaysBefore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32> <externEndRenderOverlays>k__BackingField; //Field offset: 0x20

	public static event WillRenderCanvases preWillRenderCanvases
	{
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 180
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	public static event WillRenderCanvases willRenderCanvases
	{
		[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_UpdateManager", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_UpdateRegistry", Member = "get_instance", ReturnType = "TMPro.TMP_UpdateRegistry")]
		[CalledBy(Type = "TMPro.TMP_UpdateRegistry", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 184
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 184
	}

	public AdditionalCanvasShaderChannels additionalShaderChannels
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	internal static Action<Int32> externBeginRenderOverlays
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 86
	}

	internal static Action<Int32> externEndRenderOverlays
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 86
	}

	internal static Action<Int32, Int32> externRenderOverlaysBefore
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 86
	}

	public bool isRootCanvas
	{
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "Handle", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public bool overrideSorting
	{
		[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<AnimateDeckTop>d__88", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "UpdateStatsCanvasOrdering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
		[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
		[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMaskForClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.IClippable"}, ReturnType = "UnityEngine.UI.RectMask2D")]
		[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMasksForClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.RectMask2D", "System.Collections.Generic.List`1<RectMask2D>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "Scenes.General.HandCards", Member = "PostAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetupTemplate", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "UpdateStatsCanvasOrdering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.ClientCard+<OnOverlayChanged>d__287", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<AnimateDeckTop>d__88", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "DefineLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.CardOptionList", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.CardListDisplay", Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.CardListDisplay+<Create>d__31", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.OptionBox+<Create>d__17", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.InfoBox+<Create>d__9", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.HandCards", Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSlot+<>c__DisplayClass106_0", Member = "<AddCard>b__1", ReturnType = typeof(void))]
		[CallerCount(Count = 20)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public bool pixelPerfect
	{
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public Rect pixelRect
	{
		[CalledBy(Type = "UnityEngine.InputSystem.UI.VirtualMouseInput", Member = "UpdateMotion", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 142
	}

	public float referencePixelsPerUnit
	{
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "get_AdditionalScale", ReturnType = typeof(float))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleWorldCanvas", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPixelSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "SetReferencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public Vector2 renderingDisplaySize
	{
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 135
	}

	public RenderMode renderMode
	{
		[CallerCount(Count = 23)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
		[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
		[CalledBy(Type = "Extensions.General", Member = "SetCameraRenderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public int renderOrder
	{
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public Canvas rootCanvas
	{
		[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "GetRootCanvasTransform", ReturnType = typeof(Transform))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetCanvasSpaceClippingRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 144
	}

	public float scaleFactor
	{
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CallerCount(Count = 8)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleWorldCanvas", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPixelSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "SetScaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public int sortingLayerID
	{
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public int sortingOrder
	{
		[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_sortOrderPriority", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "Card.Template", Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DeactiveChainOrder", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "UpdateStatsCanvasOrdering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "ResetState", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ParticleSystem", typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.HoverZoom", Member = "SetZoomState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnDeckTop>d__77", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<AnimateDeckTop>d__88", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "DefineLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSlot+<>c__DisplayClass106_0", Member = "<AddCard>b__1", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.CardOptionList", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.CardListDisplay", Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EdgeGlow+<Awake>d__35", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 33)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CallerCount(Count = 34)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public int targetDisplay
	{
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	[NativeProperty("Camera", False, TargetType::Function (0))]
	public Camera worldCamera
	{
		[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
		[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "GetCameraFromCanvas", ReturnType = typeof(Camera))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnContextMenuTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 144
		[CalledBy(Type = "Scenes.Battle.CardListDisplay+<Create>d__31", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.CardOptionList", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelZone", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldCenter", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSide", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.CardAnimationPlayer", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "SetCameraRenderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 177
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Canvas() { }

	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_UpdateManager", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_UpdateRegistry", Member = "get_instance", ReturnType = "TMPro.TMP_UpdateRegistry")]
	[CalledBy(Type = "TMPro.TMP_UpdateRegistry", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void EndRenderExtraOverlays(int displayIndex) { }

	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "EnsureLayoutHasRebuilt", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void ForceUpdateCanvases() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static Action<Int32> get_externBeginRenderOverlays() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static Action<Int32> get_externEndRenderOverlays() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static Action<Int32, Int32> get_externRenderOverlaysBefore() { }

	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "Handle", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_isRootCanvas() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_isRootCanvas_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<AnimateDeckTop>d__88", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "UpdateStatsCanvasOrdering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMaskForClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.IClippable"}, ReturnType = "UnityEngine.UI.RectMask2D")]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMasksForClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.RectMask2D", "System.Collections.Generic.List`1<RectMask2D>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_overrideSorting() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_overrideSorting_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_pixelPerfect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_pixelPerfect_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.VirtualMouseInput", Member = "UpdateMotion", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Rect get_pixelRect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret) { }

	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "get_AdditionalScale", ReturnType = typeof(float))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_referencePixelsPerUnit() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_referencePixelsPerUnit_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 get_renderingDisplaySize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_renderingDisplaySize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CallerCount(Count = 23)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public RenderMode get_renderMode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static RenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_renderOrder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_renderOrder_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "GetRootCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetCanvasSpaceClippingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	public Canvas get_rootCanvas() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_rootCanvas_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_scaleFactor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_scaleFactor_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_sortingLayerID() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EdgeGlow+<Awake>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay", Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardOptionList", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot+<>c__DisplayClass106_0", Member = "<AddCard>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "DefineLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<AnimateDeckTop>d__88", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnDeckTop>d__77", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.HoverZoom", Member = "SetZoomState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "UpdateStatsCanvasOrdering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DeactiveChainOrder", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_sortOrderPriority", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ParticleSystem", typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 33)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_sortingOrder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_targetDisplay() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "GetCameraFromCanvas", ReturnType = typeof(Camera))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnContextMenuTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	public Camera get_worldCamera() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_worldCamera_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_defaultMaterial", ReturnType = typeof(Material))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("UI::GetDefaultUIMaterial")]
	public static Material GetDefaultCanvasMaterial() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetDefaultCanvasMaterial_Injected() { }

	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_defaultETC1GraphicMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_material", ReturnType = typeof(Material))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	public static Material GetETC1SupportedCanvasMaterial() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetETC1SupportedCanvasMaterial_Injected() { }

	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void SendPreWillRenderCanvases() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void SendWillRenderCanvases() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_additionalShaderChannels_Injected(IntPtr _unity_self, AdditionalCanvasShaderChannels value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externBeginRenderOverlays(Action<Int32> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externEndRenderOverlays(Action<Int32> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externRenderOverlaysBefore(Action<Int32, Int32> value) { }

	[CalledBy(Type = "Scenes.General.HandCards", Member = "PostAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot+<>c__DisplayClass106_0", Member = "<AddCard>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.HandCards", Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.InfoBox+<Create>d__9", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.OptionBox+<Create>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<Create>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay", Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardOptionList", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<AnimateDeckTop>d__88", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard+<OnOverlayChanged>d__287", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "UpdateStatsCanvasOrdering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetupTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "DefineLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_overrideSorting(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_overrideSorting_Injected(IntPtr _unity_self, bool value) { }

	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleWorldCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPixelSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "SetReferencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_referencePixelsPerUnit(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_referencePixelsPerUnit_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "Extensions.General", Member = "SetCameraRenderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_renderMode(RenderMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_renderMode_Injected(IntPtr _unity_self, RenderMode value) { }

	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleWorldCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPixelSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "SetScaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_scaleFactor(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_scaleFactor_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_sortingLayerID(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	[CallerCount(Count = 34)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_sortingOrder(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<Create>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardOptionList", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldCenter", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSide", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.CardAnimationPlayer", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "SetCameraRenderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_worldCamera(Camera value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_worldCamera_Injected(IntPtr _unity_self, IntPtr value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RegisterCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.IPanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void SetExternalCanvasEnabled(bool enabled) { }

}

