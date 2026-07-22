namespace NGettext.Plural;

public class AstPluralRuleGenerator : DefaultPluralRuleGenerator, IPluralRuleTextParser, IPluralRuleGenerator
{
	private static readonly Regex NPluralsRegex; //Field offset: 0x0
	private static readonly Regex PluralRegex; //Field offset: 0x8
	[CompilerGenerated]
	private string <PluralRuleText>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private AstTokenParser <Parser>k__BackingField; //Field offset: 0x18

	public AstTokenParser Parser
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	protected private string PluralRuleText
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static AstPluralRuleGenerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AstPluralRuleGenerator() { }

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public AstPluralRuleGenerator(AstTokenParser parser) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public AstPluralRuleGenerator(string pluralRuleText) { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public AstPluralRuleGenerator(string pluralRuleText, AstTokenParser parser) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultPluralRuleGenerator), Member = "CreateRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(IPluralRule))]
	[Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Group))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AstTokenParser), Member = "GetNextToken", ReturnType = typeof(Token))]
	[Calls(Type = typeof(AstTokenParser), Member = "ParseNextExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 20)]
	public virtual IPluralRule CreateRule(CultureInfo cultureInfo) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AstTokenParser get_Parser() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected string get_PluralRuleText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Group))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public int ParseNumPlurals(string input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Group))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public string ParsePluralFormulaText(string input) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_Parser(AstTokenParser value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_PluralRuleText(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetPluralRuleText(string pluralRuleText) { }

}

