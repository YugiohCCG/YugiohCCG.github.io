namespace UnityEngine.UI;

public class GraphicRegistry
{
	private static GraphicRegistry s_Instance; //Field offset: 0x0
	private static readonly List<Graphic> s_EmptyList; //Field offset: 0x8
	private readonly Dictionary<Canvas, IndexedSet`1<Graphic>> m_Graphics; //Field offset: 0x10
	private readonly Dictionary<Canvas, IndexedSet`1<Graphic>> m_RaycastableGraphics; //Field offset: 0x18

	public static GraphicRegistry instance
	{
		[CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicRegistry), Member = "DisableGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicRegistry), Member = "DisableRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicRegistry), Member = "GetGraphicsForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UI.Graphic>))]
		[CalledBy(Type = typeof(GraphicRegistry), Member = "GetRaycastableGraphicsForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UI.Graphic>))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 593
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static GraphicRegistry() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	protected GraphicRegistry() { }

	[CalledBy(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndexedSet`1), Member = "DisableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndexedSet`1), Member = "DisableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	[CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "DisableGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "DisableRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "GetGraphicsForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UI.Graphic>))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "GetRaycastableGraphicsForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UI.Graphic>))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static GraphicRegistry get_instance() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "SortedRaycastGraphics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Ray), "System.Collections.Generic.List`1<RaycastHitData>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndexedSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexedSet`1), Member = "AddUnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	[CalledBy(Type = typeof(Graphic), Member = "set_raycastTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndexedSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexedSet`1), Member = "AddUnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnBeforeTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	[CalledBy(Type = typeof(Graphic), Member = "set_raycastTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

}

