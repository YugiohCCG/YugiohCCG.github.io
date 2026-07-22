namespace System;

[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<TimeZoneInfo> <>9__49_0; //Field offset: 0x8
		public static Comparison<TimeZoneInfo> <>9__110_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
		[CallsUnknownMethods(Count = 4)]
		internal bool <.cctor>b__157_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TimeSpan), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <GetSystemTimeZones>b__110_0(TimeZoneInfo x, TimeZoneInfo y) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TimeSpan), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <GetSystemTimeZonesWinRTFallback>b__49_0(TimeZoneInfo x, TimeZoneInfo y) { }

	}

	internal sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback
	{
		private readonly DateTime _dateStart; //Field offset: 0x10
		private readonly DateTime _dateEnd; //Field offset: 0x18
		private readonly TimeSpan _daylightDelta; //Field offset: 0x20
		private readonly TransitionTime _daylightTransitionStart; //Field offset: 0x28
		private readonly TransitionTime _daylightTransitionEnd; //Field offset: 0x40
		private readonly TimeSpan _baseUtcOffsetDelta; //Field offset: 0x58
		private readonly bool _noDaylightTransitions; //Field offset: 0x60

		internal TimeSpan BaseUtcOffsetDelta
		{
			[CallerCount(Count = 10)]
			[DeduplicatedMethod]
			internal get { } //Length: 5
		}

		public DateTime DateEnd
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public DateTime DateStart
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public TimeSpan DaylightDelta
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public TransitionTime DaylightTransitionEnd
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 21
		}

		public TransitionTime DaylightTransitionStart
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 21
		}

		internal bool HasDaylightSaving
		{
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeSpan))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(TimeSpan))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 7)]
			[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(DateTime), Member = "AddMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal get { } //Length: 688
		}

		internal bool NoDaylightTransitions
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal get { } //Length: 5
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal AdjustmentRule() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		private AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		private AdjustmentRule(SerializationInfo info, StreamingContext context) { }

		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		public override bool Equals(AdjustmentRule other) { }

		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal TimeSpan get_BaseUtcOffsetDelta() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public DateTime get_DateEnd() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public DateTime get_DateStart() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public TimeSpan get_DaylightDelta() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public TransitionTime get_DaylightTransitionEnd() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public TransitionTime get_DaylightTransitionStart() { }

		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "AddMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool get_HasDaylightSaving() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal bool get_NoDaylightTransitions() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "GetHashCode", ReturnType = typeof(int))]
		public virtual int GetHashCode() { }

		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		internal bool IsEndDateMarkerForEndOfYear() { }

		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		internal bool IsStartDateMarkerForBeginningOfYear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		[CalledBy(Type = typeof(AdjustmentRule), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(AdjustmentRule))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TimeSpan), Member = "get_TotalHours", ReturnType = typeof(double))]
		[Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "get_TimeOfDay", ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 41)]
		[ContainsUnimplementedInstructions]
		private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, bool noDaylightTransitions) { }

	}

	private sealed class CachedData
	{
		private OffsetAndRule _oneYearLocalFromUtc; //Field offset: 0x10
		private TimeZoneInfo _localTimeZone; //Field offset: 0x18
		public Dictionary<String, TimeZoneInfo> _systemTimeZones; //Field offset: 0x20
		public ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones; //Field offset: 0x28
		public bool _allSystemTimeZonesRead; //Field offset: 0x30

		public TimeZoneInfo Local
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 61
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CachedData() { }

		[CalledBy(Type = typeof(CachedData), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
		[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private TimeZoneInfo CreateLocal() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
		[CallsUnknownMethods(Count = 1)]
		public TimeZoneInfo get_Local() { }

		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Kernel32), Member = "GetTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
		[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
		[CallsUnknownMethods(Count = 1)]
		private static TimeZoneInfo GetCurrentOneYearLocal() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Kernel32), Member = "GetTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
		[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public OffsetAndRule GetOneYearLocalFromUtc(int year) { }

	}

	public struct DYNAMIC_TIME_ZONE_INFORMATION
	{
		internal TIME_ZONE_INFORMATION TZI; //Field offset: 0x0
		internal string TimeZoneKeyName; //Field offset: 0xB0
		internal byte DynamicDaylightTimeDisabled; //Field offset: 0xB8

	}

	private sealed class OffsetAndRule
	{
		public readonly int Year; //Field offset: 0x10
		public readonly TimeSpan Offset; //Field offset: 0x18
		public readonly AdjustmentRule Rule; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public OffsetAndRule(int year, TimeSpan offset, AdjustmentRule rule) { }

	}

	private enum TimeZoneInfoResult
	{
		Success = 0,
		TimeZoneNotFoundException = 1,
		InvalidTimeZoneException = 2,
		SecurityException = 3,
	}

	[IsReadOnly]
	internal struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback
	{
		private readonly DateTime _timeOfDay; //Field offset: 0x0
		private readonly byte _month; //Field offset: 0x8
		private readonly byte _week; //Field offset: 0x9
		private readonly byte _day; //Field offset: 0xA
		private readonly DayOfWeek _dayOfWeek; //Field offset: 0xC
		private readonly bool _isFixedDateRule; //Field offset: 0x10

		public int Day
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public DayOfWeek DayOfWeek
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public bool IsFixedDateRule
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public int Month
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public DateTime TimeOfDay
		{
			[CallerCount(Count = 138)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public int Week
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 11)]
		private TransitionTime(SerializationInfo info, StreamingContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
		private TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
		public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
		public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public virtual bool Equals(object obj) { }

		[CalledBy(Type = typeof(AdjustmentRule), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TransitionTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime), typeof(TransitionTime)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "HasSameRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		public override bool Equals(TransitionTime other) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int get_Day() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public DayOfWeek get_DayOfWeek() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool get_IsFixedDateRule() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int get_Month() { }

		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		public DateTime get_TimeOfDay() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int get_Week() { }

		[CallerCount(Count = 0)]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
		public static bool op_Inequality(TransitionTime t1, TransitionTime t2) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		[CalledBy(Type = typeof(TransitionTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TransitionTime), Member = "CreateFixedDateRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int)}, ReturnType = typeof(TransitionTime))]
		[CalledBy(Type = typeof(TransitionTime), Member = "CreateFloatingDateRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(TransitionTime))]
		[CalledBy(Type = typeof(TransitionTime), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 30)]
		[ContainsUnimplementedInstructions]
		private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	}

	private static Lazy<Boolean> lazyHaveRegistry; //Field offset: 0x0
	private static readonly TimeZoneInfo s_utcTimeZone; //Field offset: 0x8
	private static CachedData s_cachedData; //Field offset: 0x10
	private static readonly DateTime s_maxDateOnly; //Field offset: 0x18
	private static readonly DateTime s_minDateOnly; //Field offset: 0x20
	private static readonly TimeSpan MaxOffset; //Field offset: 0x28
	private static readonly TimeSpan MinOffset; //Field offset: 0x30
	private readonly string _id; //Field offset: 0x10
	private readonly string _displayName; //Field offset: 0x18
	private readonly string _standardDisplayName; //Field offset: 0x20
	private readonly string _daylightDisplayName; //Field offset: 0x28
	private readonly TimeSpan _baseUtcOffset; //Field offset: 0x30
	private readonly bool _supportsDaylightSavingTime; //Field offset: 0x38
	private readonly AdjustmentRule[] _adjustmentRules; //Field offset: 0x40

	public TimeSpan BaseUtcOffset
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string DisplayName
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	private static bool HaveRegistry
	{
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Lazy`1), Member = "get_Value", ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 111
	}

	public string Id
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static TimeZoneInfo Local
	{
		[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = "ZXing.Client.Result.CalendarParsedResult", Member = "parseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool)}, ReturnType = typeof(long))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(long))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZonesWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool)}, ReturnType = typeof(long))]
		[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 132
	}

	public static TimeZoneInfo Utc
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lazy`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = "FromHours", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static TimeZoneInfo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal TimeZoneInfo() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetStandardName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(REG_TZI_FORMAT), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetDaylightName", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private TimeZoneInfo(in TIME_ZONE_INFORMATION zone, bool dstDisabled) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	private TimeZoneInfo(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData), typeof(bool)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SYSTEMTIME), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SYSTEMTIME&)}, ReturnType = typeof(bool))]
	private static bool CheckDaylightSavingTimeNotSupported(in TIME_ZONE_INFORMATION timeZone) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, AdjustmentRule rule) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearCachedData() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private int CompareAdjustmentRuleToDateTime(AdjustmentRule rule, AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags) { }

	[CalledBy(Type = "ZXing.Client.Result.CalendarParsedResult", Member = "parseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo destinationTimeZone) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertUtcToTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeZoneInfo), typeof(Boolean&)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CachedData), Member = "GetCorrespondingKind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[CallsUnknownMethods(Count = 19)]
	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, CachedData cachedData) { }

	[CalledBy(Type = typeof(DateTime), Member = "ToFileTime", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTime), Member = "ToFileTimeUtc", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToFileTime", ReturnType = typeof(long))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 2)]
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(AdjustmentRule), typeof(DateTime), typeof(DateTime), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "Negate", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "AddMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	private static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(in REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "AddMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	internal static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	[CalledBy(Type = typeof(CachedData), Member = "GetCurrentOneYearLocal", ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(CachedData), Member = "GetOneYearLocalFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OffsetAndRule))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData), typeof(bool)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	internal static uint EnumDynamicTimeZoneInformation(uint dwIndex, out DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "HasSameRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "HasSameRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	public override bool Equals(TimeZoneInfo other) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryCompareTimeZoneInformationToRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static string FindIdFromTimeZoneInformation(in TIME_ZONE_INFORMATION timeZone, out bool dstDisabled) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeZoneNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public TimeSpan get_BaseUtcOffset() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public string get_DisplayName() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Lazy`1), Member = "get_Value", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private static bool get_HaveRegistry() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Id() { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZonesWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.Client.Result.CalendarParsedResult", Member = "parseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static TimeZoneInfo get_Local() { }

	[CallerCount(Count = 0)]
	public static TimeZoneInfo get_Utc() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(AdjustmentRule), typeof(DateTime), typeof(DateTime), typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out Nullable<Int32>& ruleIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out Nullable<Int32>& ruleIndex) { }

	[CalledBy(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(Kernel32), Member = "GetTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[CallsUnknownMethods(Count = 1)]
	private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetPreviousAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(AdjustmentRule))]
	[CallsUnknownMethods(Count = 1)]
	private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetPreviousAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private DaylightTimeStruct GetDaylightTime(int year, AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	internal static uint GetDynamicTimeZoneInformation(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static uint GetDynamicTimeZoneInformationEffectiveYears(ref DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool GetIsAmbiguousTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "IsAmbiguousDaylightSavingTime", ReturnType = typeof(bool))]
	private static bool GetIsDaylightSavings(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetPreviousAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 1)]
	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, AdjustmentRule rule, Nullable<Int32> ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool GetIsInvalidTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 10)]
	private static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName) { }

	[CalledBy(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Kernel32), Member = "GetDynamicTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_DYNAMIC_ZONE_INFORMATION&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TIME_DYNAMIC_ZONE_INFORMATION), Member = "GetTimeZoneKeyName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData), typeof(bool)}, ReturnType = typeof(TimeZoneInfoResult))]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_DYNAMIC_ZONE_INFORMATION&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "FindIdFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneInfoWinRTFallback", ReturnType = typeof(TimeZoneInfo))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static TimeZoneInfo GetLocalTimeZone(CachedData cachedData) { }

	[CalledBy(Type = typeof(CachedData), Member = "GetCurrentOneYearLocal", ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(CachedData), Member = "GetOneYearLocalFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OffsetAndRule))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(in TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CallsUnknownMethods(Count = 9)]
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	[CalledBy(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DateTimeOffsetTimeZonePostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CallsUnknownMethods(Count = 2)]
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightSavingsStartOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private AdjustmentRule GetPreviousAdjustmentRule(AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "FindSystemTimeZoneByIdWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZonesWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZonesFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	private static void GetSystemTimeZonesWinRTFallback(CachedData cachedData) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal static bool GetTimeZoneInformationForYear(ushort wYear, ref DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TIME_ZONE_INFORMATION ptzi) { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CachedData), Member = "GetCorrespondingKind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 3)]
	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertUtcToTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeZoneInfo), typeof(Boolean&)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public bool HasSameRules(TimeZoneInfo other) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZonesWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZonesFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	private static void PopulateAllSystemTimeZones(CachedData cachedData) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData), typeof(bool)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static void PopulateAllSystemTimeZonesFromRegistry(CachedData cachedData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	private static bool TransitionTimeFromTimeZoneInformation(in REG_TZI_FORMAT timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private static bool TransitionTimeFromTimeZoneInformation(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Millisecond", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_DayOfWeek", ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	internal static DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SYSTEMTIME), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SYSTEMTIME&)}, ReturnType = typeof(bool))]
	private static bool TryCompareStandardDate(in TIME_ZONE_INFORMATION timeZone, in REG_TZI_FORMAT registryTimeZoneInfo) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "FindIdFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SYSTEMTIME), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SYSTEMTIME&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetStandardName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 11)]
	private static bool TryCompareTimeZoneInformationToRegistry(in TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneEntryFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryKey), typeof(string), typeof(REG_TZI_FORMAT&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 38)]
	private static bool TryCreateAdjustmentRules(string id, in REG_TZI_FORMAT defaultTimeZoneInformation, out AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneInfoWinRTFallback", ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZonesWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetTimeZoneInformationForYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetStandardName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetDaylightName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	internal static TimeZoneInfo TryCreateTimeZone(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalizedNamesByRegistryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryKey), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Environment), Member = "get_SystemDirectory", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Kernel32), Member = "GetFileMUIPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), typeof(StringBuilder), typeof(Int32&), typeof(StringBuilder), typeof(Int32&), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	private static string TryGetLocalizedNameByMuiNativeResource(string resource) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Kernel32), Member = "LoadLibraryEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr), typeof(int)}, ReturnType = typeof(SafeLibraryHandle))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(User32), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeLibraryHandle), typeof(int), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static string TryGetLocalizedNameByNativeResource(string filePath, int resource) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZonesFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallsUnknownMethods(Count = 4)]
	private static TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData, bool alwaysFallbackToLocalMachine = false) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 3)]
	private static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out REG_TZI_FORMAT dtzi) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "FindSystemTimeZoneByIdWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData), typeof(bool)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "FindSystemTimeZoneByIdWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalizedNamesByRegistryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryKey), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	private static TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpan), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidTimeZoneException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 32)]
	[ContainsUnimplementedInstructions]
	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst) { }

}

