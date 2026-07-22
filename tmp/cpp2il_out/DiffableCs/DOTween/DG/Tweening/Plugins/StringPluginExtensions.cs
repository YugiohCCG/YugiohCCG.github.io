namespace DG.Tweening.Plugins;

[Extension]
internal static class StringPluginExtensions
{
	public static readonly Char[] ScrambledCharsAll; //Field offset: 0x0
	public static readonly Char[] ScrambledCharsUppercase; //Field offset: 0x8
	public static readonly Char[] ScrambledCharsLowercase; //Field offset: 0x10
	public static readonly Char[] ScrambledCharsNumerals; //Field offset: 0x18
	private static int _lastRndSeed; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private static StringPluginExtensions() { }

	[CalledBy(Type = typeof(StringPlugin), Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringOptions), typeof(Tween), typeof(bool), typeof(DG.Tweening.Core.DOGetter`1<System.String>), typeof(DG.Tweening.Core.DOSetter`1<System.String>), typeof(float), typeof(string), typeof(string), typeof(float), typeof(bool), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	internal static StringBuilder AppendScrambledChars(StringBuilder buffer, int length, Char[] chars) { }

	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<System.String, System.String, DG.Tweening.Plugins.Options.StringOptions>), typeof(bool), typeof(ScrambleMode), typeof(string)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	internal static void ScrambleChars(Char[] chars) { }

}

