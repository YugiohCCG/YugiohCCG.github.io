namespace UnityEngine.TextCore.Text;

internal class TextResourceManager
{
	private struct FontAssetRef
	{
		public int nameHashCode; //Field offset: 0x0
		public int familyNameHashCode; //Field offset: 0x4
		public int styleNameHashCode; //Field offset: 0x8
		public long familyNameAndStyleHashCode; //Field offset: 0x10
		public readonly FontAsset fontAsset; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset) { }

	}

	private static readonly Dictionary<Int32, FontAssetRef> s_FontAssetReferences; //Field offset: 0x0
	private static readonly Dictionary<Int32, FontAsset> s_FontAssetNameReferenceLookup; //Field offset: 0x8
	private static readonly Dictionary<Int64, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; //Field offset: 0x10
	private static readonly List<Int32> s_FontAssetRemovalList; //Field offset: 0x18
	private static readonly int k_RegularStyleHashCode; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 5)]
	private static TextResourceManager() { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(TextAsset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_familyNameHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_styleNameHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TextCore.Text.TextResourceManager+FontAssetRef>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAssetRef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TextCore.Text.TextResourceManager+FontAssetRef>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAssetRef)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void AddFontAsset(FontAsset fontAsset) { }

}

