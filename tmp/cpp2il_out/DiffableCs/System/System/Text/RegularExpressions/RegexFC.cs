namespace System.Text.RegularExpressions;

internal sealed class RegexFC
{
	private RegexCharClass _cc; //Field offset: 0x10
	public bool _nullable; //Field offset: 0x18
	[CompilerGenerated]
	private bool <CaseInsensitive>k__BackingField; //Field offset: 0x19

	public private bool CaseInsensitive
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RegexFC(bool nullable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RegexFC(char ch, bool not, bool nullable, bool caseInsensitive) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexCharClass), Member = "ParseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(RegexCharClass))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RegexFC(string charClass, bool nullable, bool caseInsensitive) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexCharClass), Member = "AddCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexCharClass)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool AddFC(RegexFC fc, bool concatenate) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_CaseInsensitive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(RegexCharClass), Member = "AddLowercaseRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string GetFirstChars(CultureInfo culture) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CaseInsensitive(bool value) { }

}

