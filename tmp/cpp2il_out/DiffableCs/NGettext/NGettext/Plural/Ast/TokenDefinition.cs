namespace NGettext.Plural.Ast;

public class TokenDefinition
{
	internal sealed class LeftDenotationGetterDelegate : MulticastDelegate
	{

		[CallerCount(Count = 79)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public LeftDenotationGetterDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(Token self, Token left, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override Token EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override Token Invoke(Token self, Token left) { }

	}

	internal sealed class NullDenotationGetterDelegate : MulticastDelegate
	{

		[CallerCount(Count = 39)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public NullDenotationGetterDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(Token self, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override Token EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override Token Invoke(Token self) { }

	}

	[CompilerGenerated]
	private TokenType <TokenType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <LeftBindingPower>k__BackingField; //Field offset: 0x14
	protected NullDenotationGetterDelegate NullDenotationGetter; //Field offset: 0x18
	protected LeftDenotationGetterDelegate LeftDenotationGetter; //Field offset: 0x20

	public int LeftBindingPower
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public TokenType TokenType
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

	[CallerCount(Count = 79)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public TokenDefinition(TokenType tokenType, int leftBindingPower) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LeftBindingPower() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TokenType get_TokenType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public Token GetLeftDenotation(Token self, Token left) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public Token GetNullDenotation(Token self) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_LeftBindingPower(int value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_TokenType(TokenType value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TokenDefinition SetLeftDenotationGetter(LeftDenotationGetterDelegate leftDenotationGetter) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TokenDefinition SetNullDenotationGetter(NullDenotationGetterDelegate nullDenotationGetter) { }

}

