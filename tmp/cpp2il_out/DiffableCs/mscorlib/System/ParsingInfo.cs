namespace System;

internal struct ParsingInfo
{
	internal Calendar calendar; //Field offset: 0x0
	internal int dayOfWeek; //Field offset: 0x8
	internal TM timeMark; //Field offset: 0xC
	internal bool fUseHour12; //Field offset: 0x10
	internal bool fUseTwoDigitYear; //Field offset: 0x11
	internal bool fAllowInnerWhite; //Field offset: 0x12
	internal bool fAllowTrailingWhite; //Field offset: 0x13
	internal bool fCustomNumberParser; //Field offset: 0x14
	internal MatchNumberDelegate parseNumberDelegate; //Field offset: 0x18

	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	internal void Init() { }

}

