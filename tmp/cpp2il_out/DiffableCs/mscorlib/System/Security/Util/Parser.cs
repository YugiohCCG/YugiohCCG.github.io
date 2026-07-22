namespace System.Security.Util;

internal sealed class Parser
{
	private SecurityDocument _doc; //Field offset: 0x10
	private Tokenizer _t; //Field offset: 0x18

	[CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Parser(Tokenizer t) { }

	[CalledBy(Type = typeof(RSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(StringMaker))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	internal Parser(string input) { }

	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextFullToken", ReturnType = typeof(short))]
	[Calls(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Tokenizer), Member = "ChangeFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private int DetermineFormat(TokenizerStream stream) { }

	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextFullToken", ReturnType = typeof(short))]
	[Calls(Type = typeof(TokenizerStream), Member = "TagLastToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 47)]
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	[CalledBy(Type = typeof(RSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[CallsUnknownMethods(Count = 1)]
	internal SecurityElement GetTopElement() { }

	[CalledBy(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tokenizer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TokenizerStream), Member = "GoToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "GetRequiredSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextFullToken", ReturnType = typeof(short))]
	[Calls(Type = typeof(SecurityDocument), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextString", ReturnType = typeof(string))]
	[Calls(Type = typeof(SecurityDocument), Member = "AppendString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecurityDocument), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	private void ParseContents() { }

}

