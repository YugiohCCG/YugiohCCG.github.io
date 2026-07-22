namespace System;

internal static class AppContextDefaultValues
{
	internal static readonly string SwitchEnforceJapaneseEraYearRanges; //Field offset: 0x0
	internal static readonly string SwitchFormatJapaneseFirstYearAsANumber; //Field offset: 0x8
	internal static readonly string SwitchEnforceLegacyJapaneseDateParsing; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static AppContextDefaultValues() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void PopulateDefaultValues() { }

	[CalledBy(Type = typeof(AppContext), Member = "TryGetSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	public static bool TryGetSwitchOverride(string switchName, out bool overrideValue) { }

}

