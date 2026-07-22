namespace UnityEngine.TextCore.Text;

[Extension]
internal static class TextUtilities
{

	[CalledBy(Type = typeof(FontAsset), Member = "get_familyNameHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FontAsset), Member = "get_styleNameHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextAsset), Member = "get_hashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextAsset), Member = "get_materialHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextStyle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextStyle), Member = "RefreshStyle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TextStyle))]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static int GetHashCodeCaseInSensitive(string s) { }

	[CalledBy(Type = typeof(FontAsset), Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "AddCharacterToLookupCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Character), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetCharacterInLookupCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "RemoveCharacterInLookupCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ContainsCharacterInLookupCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateCompositeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[CallerCount(Count = 11)]
	internal static int GetTextFontWeightIndex(TextFontWeight fontWeight) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	internal static char ToUpperFast(char c) { }

}

