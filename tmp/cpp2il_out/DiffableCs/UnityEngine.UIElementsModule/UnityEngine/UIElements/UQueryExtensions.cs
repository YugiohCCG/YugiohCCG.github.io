namespace UnityEngine.UIElements;

[Extension]
public static class UQueryExtensions
{
	private static UQueryState<VisualElement> SingleElementEmptyQuery; //Field offset: 0x0
	private static UQueryState<VisualElement> SingleElementNameQuery; //Field offset: 0x10
	private static UQueryState<VisualElement> SingleElementClassQuery; //Field offset: 0x20
	private static UQueryState<VisualElement> SingleElementNameAndClassQuery; //Field offset: 0x30
	private static UQueryState<VisualElement> SingleElementTypeQuery; //Field offset: 0x40
	private static UQueryState<VisualElement> SingleElementTypeAndNameQuery; //Field offset: 0x50
	private static UQueryState<VisualElement> SingleElementTypeAndClassQuery; //Field offset: 0x60
	private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery; //Field offset: 0x70

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "Build", ReturnType = "UnityEngine.UIElements.UQueryState`1<T>")]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "Class", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "SingleBaseType", ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CallsUnknownMethods(Count = 8)]
	private static UQueryExtensions() { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "GetLargestItemWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UQueryExtensions), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(String[])}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "Build", ReturnType = "UnityEngine.UIElements.UQueryState`1<T>")]
	[Calls(Type = typeof(UQueryState`1), Member = "First", ReturnType = "T")]
	[Extension]
	public static VisualElement Q(VisualElement e, string name = null, String[] classes) { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseReorderableDragAndDropController), Member = "SetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(StartDragArgs))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DefaultBindHeaderContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UQueryState`1), Member = "RebuildOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = "UnityEngine.UIElements.UQueryState`1<T>")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreatePredicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreateId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreateClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(UQueryState`1), Member = "First", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static T Q(VisualElement e, string name = null, string className = null) { }

	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "InitExpandHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "PreAttachElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "DetachElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryState`1), Member = "RebuildOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = "UnityEngine.UIElements.UQueryState`1<T>")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreateId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreateClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(UQueryState`1), Member = "First", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static VisualElement Q(VisualElement e, string name = null, string className = null) { }

	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(String[])}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static UQueryBuilder<T> Query(VisualElement e, string name = null, String[] classes) { }

	[CalledBy(Type = typeof(RadioButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static UQueryBuilder<T> Query(VisualElement e, string name = null, string className = null) { }

}

