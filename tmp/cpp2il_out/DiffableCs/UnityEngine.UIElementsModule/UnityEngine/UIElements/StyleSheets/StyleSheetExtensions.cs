namespace UnityEngine.UIElements.StyleSheets;

[Extension]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StyleSheetExtensions
{

	[CalledBy(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.StyleVariableResolver+Result")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.StyleVariableResolver+Result")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsVarFunction(StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchCustomIdent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color>), typeof(Color&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.String>), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadListStylePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue>)}, ReturnType = typeof(MatchResult))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchColor", ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StyleSheet), Member = "ReadVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadFunctionName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(ScalableImage), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadScalableImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(ScalableImage))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadAssetReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Dimension), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleValueKeywordExtension), Member = "ToUssString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueKeyword)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadResourcePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static string ReadAsString(StyleSheet sheet, StyleValueHandle handle) { }

}

