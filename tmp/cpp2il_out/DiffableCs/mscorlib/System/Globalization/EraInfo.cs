namespace System.Globalization;

internal class EraInfo
{
	internal int era; //Field offset: 0x10
	internal long ticks; //Field offset: 0x18
	internal int yearOffset; //Field offset: 0x20
	internal int minEraYear; //Field offset: 0x24
	internal int maxEraYear; //Field offset: 0x28
	[OptionalField(VersionAdded = 4)]
	internal string eraName; //Field offset: 0x30
	[OptionalField(VersionAdded = 4)]
	internal string abbrevEraName; //Field offset: 0x38
	[OptionalField(VersionAdded = 4)]
	internal string englishEraName; //Field offset: 0x40

	[CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	[CalledBy(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }

}

