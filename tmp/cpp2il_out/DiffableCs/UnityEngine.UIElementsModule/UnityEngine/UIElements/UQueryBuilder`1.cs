namespace UnityEngine.UIElements;

public struct UQueryBuilder : IEquatable<UQueryBuilder`1<T>>
{
	private List<StyleSelector> m_StyleSelectors; //Field offset: 0x0
	private List<StyleSelectorPart> m_Parts; //Field offset: 0x0
	private VisualElement m_Element; //Field offset: 0x0
	private List<RuleMatcher> m_Matchers; //Field offset: 0x0
	private StyleSelectorRelationship m_Relationship; //Field offset: 0x0
	private int pseudoStatesMask; //Field offset: 0x0
	private int negatedPseudoStatesMask; //Field offset: 0x0

	private List<StyleSelectorPart> parts
	{
		[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 123
	}

	private List<StyleSelector> styleSelectors
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 120
	}

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddRelationship", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSelectorRelationship)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(String[])}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CalledBy(Type = typeof(UQueryExtensions), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public UQueryBuilder`1(VisualElement visualElement) { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreateClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void AddClass(string c) { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreateClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private void AddClasses(String[] classes) { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreateId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void AddName(string id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void AddPseudoStatesRuleIfNecessasy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private UQueryBuilder<T2> AddRelationship(StyleSelectorRelationship relationship) { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T2>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "get_parts", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelectorPart>))]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreatePredicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private void AddType() { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "ToList", ReturnType = "System.Collections.Generic.List`1<T>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(String[])}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(UQueryExtensions), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "FinishSelector", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public UQueryState<T> Build() { }

	[CalledBy(Type = typeof(UQueryExtensions), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreateClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public UQueryBuilder<T> Class(string classname) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool CurrentSelectorEmpty() { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(UQueryBuilder<T> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UQueryBuilder`1<T>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "FinishSelector", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSelector), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private void FinishCurrentSelector() { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "Build", ReturnType = "UnityEngine.UIElements.UQueryState`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "FinishCurrentSelector", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(StyleComplexSelector), Member = "set_selectors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSelector[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	private void FinishSelector() { }

	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RadioButtonValueChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "GetAllRadioButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.RadioButton>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "UpdateRadioButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RegisterRadioButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadioButton)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "Build", ReturnType = "UnityEngine.UIElements.UQueryState`1<T>")]
	[Calls(Type = typeof(UQueryState`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void ForEach(Action<T> funcCall) { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private List<StyleSelectorPart> get_parts() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private List<StyleSelector> get_styleSelectors() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(UQueryExtensions), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreateId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public UQueryBuilder<T> Name(string id) { }

	[CalledBy(Type = typeof(UQueryExtensions), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "AddType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "AddClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public UQueryBuilder<T2> OfType(string name = null, string className = null) { }

	[CalledBy(Type = typeof(UQueryExtensions), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(String[])}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "AddType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "AddClasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public UQueryBuilder<T2> OfType(string name = null, String[] classes) { }

	[CalledBy(Type = typeof(UQueryExtensions), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleSelectorPart), Member = "CreatePredicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StyleSelectorPart))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	internal UQueryBuilder<T> SingleBaseType() { }

	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "Build", ReturnType = "UnityEngine.UIElements.UQueryState`1<T>")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public List<T> ToList() { }

}

