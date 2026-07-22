namespace System.Text.RegularExpressions;

[IsReadOnly]
internal struct RegexPrefix
{
	[CompilerGenerated]
	private static readonly RegexPrefix <Empty>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <CaseInsensitive>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Prefix>k__BackingField; //Field offset: 0x8

	internal bool CaseInsensitive
	{
		[CallerCount(Count = 89)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal static RegexPrefix Empty
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 90
	}

	internal string Prefix
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static RegexPrefix() { }

	[CalledBy(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(System.Nullable`1<System.Text.RegularExpressions.RegexPrefix>))]
	[CalledBy(Type = typeof(RegexFCD), Member = "Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexPrefix))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal RegexPrefix(string prefix, bool ci) { }

	[CallerCount(Count = 89)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_CaseInsensitive() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static RegexPrefix get_Empty() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal string get_Prefix() { }

}

