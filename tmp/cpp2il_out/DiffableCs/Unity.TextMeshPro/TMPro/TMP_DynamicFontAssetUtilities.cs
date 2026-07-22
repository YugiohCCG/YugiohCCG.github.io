namespace TMPro;

internal class TMP_DynamicFontAssetUtilities
{
	internal struct FontReference
	{
		public string familyName; //Field offset: 0x0
		public string styleName; //Field offset: 0x8
		public int faceIndex; //Field offset: 0x10
		public string filePath; //Field offset: 0x18
		public ulong hashCode; //Field offset: 0x20

		[CalledBy(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "InitializeSystemFontReferenceCache", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(TMP_TextUtilities), Member = "ToUpperFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 7)]
		public FontReference(string fontFilePath, string faceNameAndStyle, int index) { }

	}

	private static TMP_DynamicFontAssetUtilities s_Instance; //Field offset: 0x0
	private Dictionary<UInt64, FontReference> s_SystemFontLookup; //Field offset: 0x10
	private String[] s_SystemFontPaths; //Field offset: 0x18
	private uint s_RegularStyleNameHashCode; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static TMP_DynamicFontAssetUtilities() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TMP_DynamicFontAssetUtilities() { }

	[CalledBy(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "TryGetSystemFontReferenceInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(FontEngine), Member = "UnloadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ulong), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(FontReference)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetFontFaces", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(Font), Member = "GetPathsToOSFonts", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 24)]
	private void InitializeSystemFontReferenceCache() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "TryGetSystemFontReferenceInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryGetSystemFontReference(string familyName, out FontReference fontRef) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "TryGetSystemFontReferenceInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	[CalledBy(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "InitializeSystemFontReferenceCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(FontReference))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private bool TryGetSystemFontReferenceInternal(string familyName, string styleName, out FontReference fontRef) { }

}

