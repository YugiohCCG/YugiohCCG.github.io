namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleSelectorPart
{
	[SerializeField]
	private string m_Value; //Field offset: 0x0
	[SerializeField]
	private StyleSelectorType m_Type; //Field offset: 0x8
	internal object tempData; //Field offset: 0x10

	public internal StyleSelectorType type
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 4
	}

	public string value
	{
		[CallerCount(Count = 223)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "Class", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddClasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public static StyleSelectorPart CreateClass(string className) { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static StyleSelectorPart CreateId(string Id) { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "SingleBaseType", ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static StyleSelectorPart CreatePredicate(object predicate) { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public StyleSelectorType get_type() { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	public string get_value() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_type(StyleSelectorType value) { }

	[CalledBy(Type = "UnityEngine.UIElements.StyleSelector+<>c", Member = "<ToString>b__10_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSelectorPart)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 10)]
	public virtual string ToString() { }

}

