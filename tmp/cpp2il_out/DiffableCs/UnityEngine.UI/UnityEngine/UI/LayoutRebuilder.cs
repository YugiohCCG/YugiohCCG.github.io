namespace UnityEngine.UI;

public class LayoutRebuilder : ICanvasElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Component> <>9__10_0; //Field offset: 0x8
		public static UnityAction<Component> <>9__12_0; //Field offset: 0x10
		public static UnityAction<Component> <>9__12_1; //Field offset: 0x18
		public static UnityAction<Component> <>9__12_2; //Field offset: 0x20
		public static UnityAction<Component> <>9__12_3; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal LayoutRebuilder <.cctor>b__5_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal void <.cctor>b__5_1(LayoutRebuilder x) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		internal void <Rebuild>b__12_0(Component e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		internal void <Rebuild>b__12_1(Component e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		internal void <Rebuild>b__12_2(Component e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		internal void <Rebuild>b__12_3(Component e) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	}

	private static ObjectPool<LayoutRebuilder> s_Rebuilders; //Field offset: 0x0
	private RectTransform m_ToRebuild; //Field offset: 0x10
	private int m_CachedHashFromTransform; //Field offset: 0x18

	public override Transform transform
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "add_reapplyDrivenProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReapplyDrivenProperties)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static LayoutRebuilder() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LayoutRebuilder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Clear() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "UnityEngine.Rendering.UI.UIFoldout", Member = "SetState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LayoutRebuilder), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override Transform get_transform() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void GraphicUpdateComplete() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Initialize(RectTransform controller) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override bool IsDestroyed() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void LayoutComplete() { }

	[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup+<DelayedSetDirty>d__57", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "ReapplyDrivenProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnBeforeTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "SetLayoutDirty", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetLayoutDirty", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetLayoutDirty", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "ValidController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Collections.Generic.List`1<UnityEngine.Component>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	[CalledBy(Type = typeof(LayoutRebuilder), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "StripDisabledBehavioursFromList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Component&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	[CalledBy(Type = typeof(LayoutRebuilder), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "StripDisabledBehavioursFromList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	[CalledBy(Type = typeof(LayoutRebuilder), Member = "ForceRebuildLayoutImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public override void Rebuild(CanvasUpdate executing) { }

	[CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

}

