namespace System;

internal struct DateTimeRawInfo
{
	private Int32* num; //Field offset: 0x0
	internal int numCount; //Field offset: 0x8
	internal int month; //Field offset: 0xC
	internal int year; //Field offset: 0x10
	internal int dayOfWeek; //Field offset: 0x14
	internal int era; //Field offset: 0x18
	internal TM timeMark; //Field offset: 0x1C
	internal double fraction; //Field offset: 0x20
	internal bool hasSameDateAndTimeSeparators; //Field offset: 0x28

	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	internal void AddNumber(int value) { }

	[CallerCount(Count = 43)]
	[DeduplicatedMethod]
	internal int GetNumber(int index) { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	internal void Init(Int32* numberBuffer) { }

}

