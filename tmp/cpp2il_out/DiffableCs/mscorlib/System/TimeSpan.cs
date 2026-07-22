namespace System;

[IsReadOnly]
public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable
{
	public static readonly TimeSpan Zero; //Field offset: 0x0
	public static readonly TimeSpan MaxValue; //Field offset: 0x8
	public static readonly TimeSpan MinValue; //Field offset: 0x10
	internal readonly long _ticks; //Field offset: 0x0

	public int Days
	{
		[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = "FromTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = "System.Data.SqlTypes.SqlDateTime")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 19
	}

	public int Hours
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(TimeSpan)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(TimeSpan), "Newtonsoft.Json.DateFormatHandling"}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
		[CallerCount(Count = 10)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 63
	}

	public int Minutes
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(TimeSpan)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(TimeSpan), "Newtonsoft.Json.DateFormatHandling"}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
		[CallerCount(Count = 9)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 71
	}

	public long Ticks
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public double TotalDays
	{
		[CalledBy(Type = "Data.User", Member = "get_PassDaysLeft", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	public double TotalHours
	{
		[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	public double TotalMilliseconds
	{
		[CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Diagnostics.Stopwatch", Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
		[CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.RegularExpressions.Regex", typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = "System.Text.RegularExpressions.Match")]
		[CalledBy(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[CalledBy(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(Task))]
		[CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "BlockUntilRecvMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
		[CalledBy(Type = typeof(CancellationTokenSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Sound", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.DiscordController", Member = "IsMessageBlocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "SQLite.SQLiteConnection", Member = "set_BusyTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SQLite.SQLiteConnection", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.SQLiteConnectionString"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.ChatWindow", Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
		[CalledBy(Type = "System.Net.FtpWebRequest", Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 48
	}

	public double TotalMinutes
	{
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	public double TotalSeconds
	{
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "EnableButtonsForUI", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "OnClickLeave", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "OnRefreshRoomList", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.LPChange+<>c__DisplayClass17_0", Member = "<Animation>b__0", ReturnType = typeof(bool))]
		[CalledBy(Type = "Scenes.General.LifePoints", Member = "OnTickRateIncreased", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.LifePoints", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnAutoDeck>d__370", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Converters.UnixDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<TrySeamlessAuth>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Data.RoomData", Member = "get_EOMPTimeLeft", ReturnType = typeof(double))]
		[CalledBy(Type = "Data.Tournament", Member = "get_NextRoundTimeLeft", ReturnType = typeof(double))]
		[CalledBy(Type = "Data.Tournament", Member = "get_RoundTimeLeft", ReturnType = typeof(double))]
		[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	[CallerCount(Count = 0)]
	private static TimeSpan() { }

	[CalledBy(Type = typeof(Timeout), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(uint), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[CalledBy(Type = "ZXing.Client.Result.CalendarParsedResult", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), "System.String[]", typeof(string), typeof(double), typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public TimeSpan(long ticks) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public TimeSpan(int hours, int minutes, int seconds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public TimeSpan Add(TimeSpan ts) { }

	[CalledBy(Type = "System.Xml.Schema.DurationFacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.DurationFacetsChecker", Member = "MatchEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(ArrayList)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	[CalledBy(Type = "System.Xml.Schema.Datatype_duration", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public override int CompareTo(object value) { }

	[CalledBy(Type = "System.TimeZoneInfo+<>c", Member = "<GetSystemTimeZonesWinRTFallback>b__49_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo), typeof(TimeZoneInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.TimeZoneInfo+<>c", Member = "<GetSystemTimeZones>b__110_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo), typeof(TimeZoneInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override int CompareTo(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(TimeSpan obj) { }

	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnection", Member = "StartOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebOperation", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeSpan), Member = "Interval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(TimeSpan))]
	public static TimeSpan FromDays(double value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseMicrosoftDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&), typeof(TimeSpan&), typeof(DateTimeKind&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpConstants", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TimeSpan), Member = "Interval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(TimeSpan))]
	public static TimeSpan FromHours(double value) { }

	[CalledBy(Type = "Mono.Nat.Pmp.PmpConstants", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.AsyncExtensions+<Await>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.RegularExpressions.Regex", typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = "System.Text.RegularExpressions.Match")]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "CheckTimeout", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "DoCheckTimeout", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_HasTimedOut", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_HostEntry", ReturnType = "System.Net.IPHostEntry")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(TimeSpan), Member = "Interval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(TimeSpan))]
	public static TimeSpan FromMilliseconds(double value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseMicrosoftDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&), typeof(TimeSpan&), typeof(DateTimeKind&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Nat.Searcher", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(LifetimeServices), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TimeSpan), Member = "Interval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(TimeSpan))]
	public static TimeSpan FromMinutes(double value) { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "OnJoinTournamentButton", ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteConnection", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.SQLiteConnectionString"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<HandleMessageReceived>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(LifetimeServices), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Utilities.Async.Awaiters+<WaitUntil>d__6`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsInvalidInstructions]
	public static TimeSpan FromSeconds(double value) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static TimeSpan FromTicks(long value) { }

	[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = "FromTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = "System.Data.SqlTypes.SqlDateTime")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int get_Days() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(TimeSpan), "Newtonsoft.Json.DateFormatHandling"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	public int get_Hours() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(TimeSpan), "Newtonsoft.Json.DateFormatHandling"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	public int get_Minutes() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public long get_Ticks() { }

	[CalledBy(Type = "Data.User", Member = "get_PassDaysLeft", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public double get_TotalDays() { }

	[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public double get_TotalHours() { }

	[CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteConnection", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.SQLiteConnectionString"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "set_BusyTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.DiscordController", Member = "IsMessageBlocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Sound", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "BlockUntilRecvMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.RegularExpressions.Regex", typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = "System.Text.RegularExpressions.Match")]
	[CalledBy(Type = "System.Diagnostics.Stopwatch", Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[CallerCount(Count = 22)]
	[ContainsUnimplementedInstructions]
	public double get_TotalMilliseconds() { }

	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public double get_TotalMinutes() { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "EnableButtonsForUI", ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Data.Tournament", Member = "get_RoundTimeLeft", ReturnType = typeof(double))]
	[CalledBy(Type = "Data.Tournament", Member = "get_NextRoundTimeLeft", ReturnType = typeof(double))]
	[CalledBy(Type = "Data.RoomData", Member = "get_EOMPTimeLeft", ReturnType = typeof(double))]
	[CalledBy(Type = "Manager.Network+<TrySeamlessAuth>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.UnixDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnAutoDeck>d__370", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints", Member = "OnTickRateIncreased", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LPChange+<>c__DisplayClass17_0", Member = "<Animation>b__0", ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "OnRefreshRoomList", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "OnClickLeave", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	public double get_TotalSeconds() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(TimeSpan), Member = "FromDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeSpan), Member = "FromHours", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeSpan), Member = "FromMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private static TimeSpan Interval(double value, int scale) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseMicrosoftDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&), typeof(TimeSpan&), typeof(DateTimeKind&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZoneOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public TimeSpan Negate() { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseMicrosoftDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&), typeof(TimeSpan&), typeof(DateTimeKind&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightSavingsEndOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightSavingsStartOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Lease), Member = "UpdateState", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = "FromTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = "System.Data.SqlTypes.SqlDateTime")]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	[CallerCount(Count = 544)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "OnJoinTournamentButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<HandleMessageReceived>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LeaseSink), Member = "RenewLease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "ValidateMatchTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = "FromTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = "System.Data.SqlTypes.SqlDateTime")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "ValidateMatchTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static TimeSpan op_UnaryNegation(TimeSpan t) { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), "SQLite.SQLite3+ColType", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "ConvertToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	public static TimeSpan Parse(string s) { }

	[CalledBy(Type = "System.ComponentModel.TimeSpanConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public TimeSpan Subtract(TimeSpan ts) { }

	[CalledBy(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Calendar), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(GregorianCalendarHelper), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static long TimeToTicks(int hour, int minute, int second) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpanFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(char)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TimeSpanFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpanFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider formatProvider = null) { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), "SQLite.SQLite3+ColType", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(TimeSpanParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpanStyles), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ValidateStyles(TimeSpanStyles style, string parameterName) { }

}

