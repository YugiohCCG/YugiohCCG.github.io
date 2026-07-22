namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
public sealed class LifetimeServices
{
	private static TimeSpan _leaseManagerPollTime; //Field offset: 0x0
	private static TimeSpan _leaseTime; //Field offset: 0x8
	private static TimeSpan _renewOnCallTime; //Field offset: 0x10
	private static TimeSpan _sponsorshipTimeout; //Field offset: 0x18
	private static LeaseManager _leaseManager; //Field offset: 0x20

	public static TimeSpan LeaseManagerPollTime
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
		[CalledBy(Type = typeof(ConfigHandler), Member = "ReadLifetine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LeaseManager), Member = "SetPollTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	public static TimeSpan LeaseTime
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		 set { } //Length: 85
	}

	public static TimeSpan RenewOnCallTime
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		 set { } //Length: 85
	}

	public static TimeSpan SponsorshipTimeout
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		 set { } //Length: 85
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "FromMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static LifetimeServices() { }

	[CallerCount(Count = 0)]
	public static TimeSpan get_LeaseManagerPollTime() { }

	[CallerCount(Count = 0)]
	public static TimeSpan get_LeaseTime() { }

	[CallerCount(Count = 0)]
	public static TimeSpan get_RenewOnCallTime() { }

	[CallerCount(Count = 0)]
	public static TimeSpan get_SponsorshipTimeout() { }

	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadLifetine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LeaseManager), Member = "SetPollTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	[CallerCount(Count = 0)]
	public static void set_LeaseTime(TimeSpan value) { }

	[CallerCount(Count = 0)]
	public static void set_RenewOnCallTime(TimeSpan value) { }

	[CallerCount(Count = 0)]
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaseManager), Member = "TrackLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServerIdentity)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void TrackLifetime(ServerIdentity identity) { }

}

