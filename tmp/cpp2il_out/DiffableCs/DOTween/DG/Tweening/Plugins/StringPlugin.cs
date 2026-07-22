namespace DG.Tweening.Plugins;

public class StringPlugin : ABSTweenPlugin<String, String, StringOptions>
{
	private static readonly StringBuilder _Buffer; //Field offset: 0x0
	private static readonly List<Char> _OpenedTags; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static StringPlugin() { }

	[CalledBy(Type = typeof(PluginsManager), Member = "GetDefaultPlugin", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public StringPlugin() { }

	[CalledBy(Type = typeof(StringPlugin), Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringOptions), typeof(Tween), typeof(bool), typeof(DG.Tweening.Core.DOGetter`1<System.String>), typeof(DG.Tweening.Core.DOSetter`1<System.String>), typeof(float), typeof(string), typeof(string), typeof(float), typeof(bool), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string ConvertToStartValue(TweenerCore<String, String, StringOptions> t, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StringPlugin), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringPlugin), Member = "ScrambledCharsToUse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringOptions)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(StringPluginExtensions), Member = "AppendScrambledChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<String> getter, DOSetter<String> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Reset(TweenerCore<String, String, StringOptions> t) { }

	[CalledBy(Type = typeof(StringPlugin), Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringOptions), typeof(Tween), typeof(bool), typeof(DG.Tweening.Core.DOGetter`1<System.String>), typeof(DG.Tweening.Core.DOSetter`1<System.String>), typeof(float), typeof(string), typeof(string), typeof(float), typeof(bool), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	private Char[] ScrambledCharsToUse(StringOptions options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void SetChangeValue(TweenerCore<String, String, StringOptions> t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void SetFrom(TweenerCore<String, String, StringOptions> t, bool isRelative) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void SetFrom(TweenerCore<String, String, StringOptions> t, string fromValue, bool setImmediately, bool isRelative) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetRelativeEndValue(TweenerCore<String, String, StringOptions> t) { }

}

