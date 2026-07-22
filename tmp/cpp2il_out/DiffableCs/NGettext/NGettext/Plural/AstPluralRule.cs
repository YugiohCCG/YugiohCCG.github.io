namespace NGettext.Plural;

public class AstPluralRule : IPluralRule
{
	[CompilerGenerated]
	private int <NumPlurals>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Token <AstRoot>k__BackingField; //Field offset: 0x18

	protected Token AstRoot
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

	public override int NumPlurals
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public AstPluralRule(int numPlurals, Token astRoot) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstPluralRule), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(long)}, ReturnType = typeof(long))]
	public override int Evaluate(long number) { }

	[CalledBy(Type = typeof(AstPluralRule), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AstPluralRule), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(long)}, ReturnType = typeof(long))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(AstPluralRule), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	protected long Evaluate(Token node, long number) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected Token get_AstRoot() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override int get_NumPlurals() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_AstRoot(Token value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_NumPlurals(int value) { }

}

