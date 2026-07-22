namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/UI Document")]
[DefaultExecutionOrder(-100)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("UIE-get-started-with-runtime-ui")]
public sealed class UIDocument : MonoBehaviour
{
	public enum WorldSpaceSizeMode
	{
		Dynamic = 0,
		Fixed = 1,
	}

	internal const string k_RootStyleClassName = "unity-ui-document__root"; //Field offset: 0x0
	internal const string k_VisualElementNameSuffix = "-container"; //Field offset: 0x0
	private const int k_DefaultSortingOrder = 0; //Field offset: 0x0
	private static int s_CurrentUIDocumentCounter; //Field offset: 0x0
	internal readonly int m_UIDocumentCreationIndex; //Field offset: 0x20
	[SerializeField]
	private PanelSettings m_PanelSettings; //Field offset: 0x28
	private PanelSettings m_PreviousPanelSettings; //Field offset: 0x30
	[SerializeField]
	private UIDocument m_ParentUI; //Field offset: 0x38
	private UIDocumentList m_ChildrenContent; //Field offset: 0x40
	private List<UIDocument> m_ChildrenContentCopy; //Field offset: 0x48
	[SerializeField]
	private VisualTreeAsset sourceAsset; //Field offset: 0x50
	private VisualElement m_RootVisualElement; //Field offset: 0x58
	private RuntimePanel m_RuntimePanel; //Field offset: 0x60
	private int m_FirstChildInsertIndex; //Field offset: 0x68
	[SerializeField]
	private float m_SortingOrder; //Field offset: 0x6C
	[SerializeField]
	private WorldSpaceSizeMode m_WorldSpaceSizeMode; //Field offset: 0x70
	[SerializeField]
	private float m_WorldSpaceWidth; //Field offset: 0x74
	[SerializeField]
	private float m_WorldSpaceHeight; //Field offset: 0x78
	private bool m_RootHasWorldTransform; //Field offset: 0x7C

	internal int firstChildInserIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	public PanelSettings panelSettings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PanelSettings), Member = "DetachUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 716
	}

	public private UIDocument parentUI
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	private float pixelsPerUnit
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 29
	}

	public VisualElement rootVisualElement
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public IRuntimePanel runtimePanel
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIDocument), Member = "ResolveRuntimePanel", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public float sortingOrder
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 25
	}

	public VisualTreeAsset visualTreeAsset
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 37
	}

	internal WorldSpaceSizeMode worldSpaceSizeMode
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private UIDocument() { }

	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocumentList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void AddChildAndInsertContentToVisualTree(UIDocument child) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void AddOrRemoveRendererComponent() { }

	[CalledBy(Type = typeof(UIDocument), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "ApplySortingOrder", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "AddChildAndInsertContentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void AddRootVisualElementToTree() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	internal void ApplySortingOrder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "SetupFromHierarchy", ReturnType = typeof(void))]
	private void Awake() { }

	[CalledBy(Type = typeof(UIDocument), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleScale), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleScale))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	private void ClearTransform() { }

	[CalledBy(Type = typeof(UIDocument), Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 1)]
	private void ComputeTransform(Transform transform, out Matrix4x4 matrix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private UIDocument FindUIDocumentParent() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_firstChildInserIndex() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PanelSettings get_panelSettings() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public UIDocument get_parentUI() { }

	[CallerCount(Count = 0)]
	private float get_pixelsPerUnit() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public VisualElement get_rootVisualElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "ResolveRuntimePanel", ReturnType = typeof(void))]
	public IRuntimePanel get_runtimePanel() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_sortingOrder() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public VisualTreeAsset get_visualTreeAsset() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal WorldSpaceSizeMode get_worldSpaceSizeMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "ClearTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "ResolveRuntimePanel", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "SetTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "ResolveRuntimePanel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTransformChildrenChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	private void OnTransformParentChanged() { }

	[CalledBy(Type = typeof(UIDocument), Member = "OnTransformChildrenChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIDocument), Member = "SetupFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "SetupRootClassList", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ReactToHierarchyChanged() { }

	[CalledBy(Type = typeof(UIDocument), Member = "set_visualTreeAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "AddChildAndInsertContentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TemplateContainer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private void RecreateUI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveChild(UIDocument child) { }

	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelSettings), Member = "DetachUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveFromHierarchy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelSettings), Member = "DetachUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "SetupFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void Reset() { }

	[CalledBy(Type = typeof(UIDocument), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "get_runtimePanel", ReturnType = typeof(IRuntimePanel))]
	[CalledBy(Type = typeof(UIDocument), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[CallsUnknownMethods(Count = 2)]
	private void ResolveRuntimePanel() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private Bounds SanitizeRendererBounds(Bounds b) { }

	[CalledBy(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelSettings), Member = "DetachUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void set_panelSettings(PanelSettings value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void set_parentUI(UIDocument value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_sortingOrder(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_visualTreeAsset(VisualTreeAsset value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(Translate), Member = "None", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(Rotate), Member = "None", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Scale), Member = "None", ReturnType = typeof(Scale))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private static void SetNoTransform(VisualElement visualElement) { }

	[CalledBy(Type = typeof(UIDocument), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(UIDocument), Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(TransformOrigin), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin)}, ReturnType = typeof(StyleTransformOrigin))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Translate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Rotate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	private void SetTransform() { }

	[CalledBy(Type = typeof(UIDocument), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetupFromHierarchy() { }

	[CalledBy(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "UpdateWorldSpaceSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetupRootClassList() { }

	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCutRenderChainFlag() { }

	[CalledBy(Type = typeof(UIDocument), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBounds3D", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Renderer), Member = "set_localBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "UpdateCutRenderChainFlag", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void UpdateRenderer() { }

	[CalledBy(Type = typeof(UIDocument), Member = "SetupRootClassList", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateWorldSpaceSize() { }

}

