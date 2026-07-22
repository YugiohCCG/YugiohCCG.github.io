namespace UnityEngine;

internal class RuntimeTextSettings : TextSettings
{
	private static RuntimeTextSettings s_DefaultTextSettings; //Field offset: 0x0
	private static List<FontAsset> s_FallbackOSFontAssetIMGUIInternal; //Field offset: 0x8

	internal static RuntimeTextSettings defaultTextSettings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 187
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSettings), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public RuntimeTextSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal static RuntimeTextSettings get_defaultTextSettings() { }

	[CallerCount(Count = 0)]
	internal virtual List<FontAsset> GetStaticFallbackOSFontAsset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

}

