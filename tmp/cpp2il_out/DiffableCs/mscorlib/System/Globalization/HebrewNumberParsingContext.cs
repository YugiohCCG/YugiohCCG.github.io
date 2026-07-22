namespace System.Globalization;

internal struct HebrewNumberParsingContext
{
	internal HS state; //Field offset: 0x0
	internal int result; //Field offset: 0x4

	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchHebrewDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "TryParseHebrewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(Boolean&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	public HebrewNumberParsingContext(int result) { }

}

