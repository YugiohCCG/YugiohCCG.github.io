namespace System.Net.Configuration;

internal sealed class SettingsSectionInternal
{
	private static readonly SettingsSectionInternal instance; //Field offset: 0x0
	internal readonly bool HttpListenerUnescapeRequestUrl; //Field offset: 0x10
	internal readonly IPProtectionLevel IPProtectionLevel; //Field offset: 0x14

	internal bool Ipv6Enabled
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	internal static SettingsSectionInternal Section
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static SettingsSectionInternal() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public SettingsSectionInternal() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal bool get_Ipv6Enabled() { }

	[CallerCount(Count = 0)]
	internal static SettingsSectionInternal get_Section() { }

}

