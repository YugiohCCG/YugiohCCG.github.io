namespace NGettext.Plural.Ast;

public class Token
{
	public const int MAX_CHILDREN_COUNT = 3; //Field offset: 0x0
	[CompilerGenerated]
	private TokenType <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <Value>k__BackingField; //Field offset: 0x18
	public readonly Token[] Children; //Field offset: 0x20

	public TokenType Type
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public long Value
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Token(TokenType type, long value = 0) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TokenType get_Type() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public long get_Value() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_Type(TokenType value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Value(long value) { }

}

