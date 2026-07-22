namespace System.Security.Util;

internal sealed class TokenizerStream
{
	private int m_countTokens; //Field offset: 0x10
	private TokenizerShortBlock m_headTokens; //Field offset: 0x18
	private TokenizerShortBlock m_lastTokens; //Field offset: 0x20
	private TokenizerShortBlock m_currentTokens; //Field offset: 0x28
	private int m_indexTokens; //Field offset: 0x30
	private TokenizerStringBlock m_headStrings; //Field offset: 0x38
	private TokenizerStringBlock m_currentStrings; //Field offset: 0x40
	private int m_indexStrings; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	internal TokenizerStream() { }

	[CalledBy(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal void AddString(string str) { }

	[CalledBy(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void AddToken(short token) { }

	[CalledBy(Type = typeof(Parser), Member = "GetRequiredSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TokenizerStream), Member = "GetNextToken", ReturnType = typeof(short))]
	[CalledBy(Type = typeof(TokenizerStream), Member = "GoToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[CallsUnknownMethods(Count = 4)]
	internal short GetNextFullToken() { }

	[CalledBy(Type = typeof(Parser), Member = "GetRequiredSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TokenizerStream), Member = "ThrowAwayNextString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TokenizerStream), Member = "GoToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 3)]
	internal string GetNextString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextFullToken", ReturnType = typeof(short))]
	internal short GetNextToken() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	internal int GetTokenCount() { }

	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextFullToken", ReturnType = typeof(short))]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	internal void GoToPosition(int position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal void Reset() { }

	[CalledBy(Type = typeof(Parser), Member = "GetRequiredSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	internal void TagLastToken(short tag) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextString", ReturnType = typeof(string))]
	internal void ThrowAwayNextString() { }

}

