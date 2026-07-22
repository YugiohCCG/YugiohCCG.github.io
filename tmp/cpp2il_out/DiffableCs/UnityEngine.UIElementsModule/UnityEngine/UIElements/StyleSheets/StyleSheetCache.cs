namespace UnityEngine.UIElements.StyleSheets;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StyleSheetCache
{
	private struct SheetHandleKey
	{
		public readonly int sheetInstanceID; //Field offset: 0x0
		public readonly int index; //Field offset: 0x4

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		public SheetHandleKey(StyleSheet sheet, int index) { }

	}

	private class SheetHandleKeyComparer : IEqualityComparer<SheetHandleKey>
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SheetHandleKeyComparer() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public override bool Equals(SheetHandleKey x, SheetHandleKey y) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public override int GetHashCode(SheetHandleKey key) { }

	}

	private static SheetHandleKeyComparer s_Comparer; //Field offset: 0x0
	private static Dictionary<SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StyleSheets.StyleSheetCache+SheetHandleKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<UnityEngine.UIElements.StyleSheets.StyleSheetCache+SheetHandleKey>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static StyleSheetCache() { }

	[CalledBy(Type = typeof(StyleSheetCache), Member = "GetPropertyIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(int)}, ReturnType = typeof(StylePropertyId[]))]
	[CalledBy(Type = typeof(StyleSheetCache), Member = "GetPropertyIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRule)}, ReturnType = typeof(StylePropertyId[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static StylePropertyId GetPropertyId(StyleRule rule, int index) { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "SetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleComplexSelector), typeof(StyleVariableContext), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StyleSheets.StyleSheetCache+SheetHandleKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SheetHandleKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheetCache), Member = "GetPropertyId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRule), typeof(int)}, ReturnType = typeof(StylePropertyId))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StyleSheets.StyleSheetCache+SheetHandleKey, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SheetHandleKey), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSheetCache), Member = "GetPropertyId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRule), typeof(int)}, ReturnType = typeof(StylePropertyId))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static StylePropertyId[] GetPropertyIds(StyleRule rule) { }

}

