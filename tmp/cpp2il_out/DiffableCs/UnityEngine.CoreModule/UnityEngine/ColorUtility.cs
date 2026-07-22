namespace UnityEngine;

[NativeHeader("Runtime/Math/ColorUtility.h")]
public class ColorUtility
{

	[CalledBy(Type = typeof(ColorUtility), Member = "TryParseHtmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("TryParseHtmlColor", True)]
	internal static bool DoTryParseHtmlColor(string htmlString, out Color32 color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool DoTryParseHtmlColor_Injected(ref ManagedSpanWrapper htmlString, out Color32 color) { }

	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser", Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<ParseError>"}, ReturnType = "System.Collections.Generic.List`1<Tag>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ColorUtility), Member = "DoTryParseHtmlColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color32&)}, ReturnType = typeof(bool))]
	public static bool TryParseHtmlString(string htmlString, out Color color) { }

}

