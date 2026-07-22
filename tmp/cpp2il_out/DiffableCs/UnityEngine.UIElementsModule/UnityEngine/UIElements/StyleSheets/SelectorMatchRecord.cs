namespace UnityEngine.UIElements.StyleSheets;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct SelectorMatchRecord
{
	public StyleSheet sheet; //Field offset: 0x0
	public int styleSheetIndexInStack; //Field offset: 0x8
	public StyleComplexSelector complexSelector; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack) { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal+<>c", Member = "<ProcessMatchedRules>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectorMatchRecord), typeof(SelectorMatchRecord)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSheet), Member = "get_isDefaultStyleSheet", ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b) { }

}

