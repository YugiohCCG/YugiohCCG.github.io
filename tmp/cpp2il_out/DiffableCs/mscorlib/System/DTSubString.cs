namespace System;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct DTSubString
{
	internal ReadOnlySpan<Char> s; //Field offset: 0x0
	internal int index; //Field offset: 0x10
	internal int length; //Field offset: 0x14
	internal DTSubStringType type; //Field offset: 0x18
	internal int value; //Field offset: 0x1C

	internal char Item
	{
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 38
	}

	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal char get_Item(int relativeIndex) { }

}

