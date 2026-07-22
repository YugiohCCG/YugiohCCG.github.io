namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleComplexSelector : ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<StyleSelector, String> <>9__24_0; //Field offset: 0x8
		public static Predicate<StyleSelectorPart> <>9__27_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <CalculateHashes>b__27_0(StyleSelectorPart p) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal string <ToString>b__24_0(StyleSelector x) { }

	}

	private struct PseudoStateData
	{
		public readonly PseudoStates state; //Field offset: 0x0
		public readonly bool negate; //Field offset: 0x4

		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		public PseudoStateData(PseudoStates state, bool negate) { }

	}

	private static Dictionary<String, PseudoStateData> s_PseudoStates; //Field offset: 0x0
	private static List<StyleSelectorPart> m_HashList; //Field offset: 0x8
	public Hashes ancestorHashes; //Field offset: 0x10
	[SerializeField]
	private int m_Specificity; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private StyleRule <rule>k__BackingField; //Field offset: 0x28
	private bool m_isSimple; //Field offset: 0x30
	[SerializeField]
	private StyleSelector[] m_Selectors; //Field offset: 0x38
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int ruleIndex; //Field offset: 0x40
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleComplexSelector nextInTable; //Field offset: 0x48
	internal int orderInStyleSheet; //Field offset: 0x50

	public bool isSimple
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public internal StyleRule rule
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 13
	}

	public internal StyleSelector[] selectors
	{
		[CallerCount(Count = 35)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = typeof(UQueryBuilder`1), Member = "FinishSelector", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 52
	}

	public int specificity
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static StyleComplexSelector() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public StyleComplexSelector() { }

	[CalledBy(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.StyleComplexSelector+PseudoStateData>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PseudoStateData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal void CachePseudoStateMasks() { }

	[CalledBy(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelectorPart>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.StyleSelectorPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal void CalculateHashes() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public bool get_isSimple() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public StyleRule get_rule() { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	public StyleSelector[] get_selectors() { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public int get_specificity() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void OnAfterDeserialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnBeforeSerialize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_rule(StyleRule value) { }

	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "FinishSelector", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_selectors(StyleSelector[] value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

