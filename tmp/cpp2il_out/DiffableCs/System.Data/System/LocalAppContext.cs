namespace System;

internal class LocalAppContext
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__6_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AppContext), Member = "TryGetSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
		internal bool <get_DisableCaching>b__6_0() { }

	}

	private static bool s_isDisableCachingInitialized; //Field offset: 0x0
	private static bool s_disableCaching; //Field offset: 0x1
	private static object s_syncObject; //Field offset: 0x8

	private static bool DisableCaching
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Boolean&), typeof(Object&), "System.Func`1<T>"}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 330
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Boolean&), typeof(Object&), "System.Func`1<T>"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool get_DisableCaching() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalAppContext), Member = "GetCachedSwitchValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	internal static bool GetCachedSwitchValue(string switchName, ref int switchValue) { }

	[CalledBy(Type = typeof(LocalAppContext), Member = "GetCachedSwitchValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TypeLimiter), Member = "get_IsTypeLimitingDisabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TypeLimiter), Member = "EnterRestrictedScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(IDisposable))]
	[CalledBy(Type = typeof(TypeLimiter), Member = "EnterRestrictedScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(IDisposable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AppContext), Member = "TryGetSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Boolean&), typeof(Object&), "System.Func`1<T>"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue) { }

}

