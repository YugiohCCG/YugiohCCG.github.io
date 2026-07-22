namespace UnityEngine.Analytics;

[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[RequiredByNativeCode]
public static class AnalyticsSessionInfo
{
	internal sealed class IdentityTokenChanged : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public IdentityTokenChanged(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(string token) { }

	}

	internal sealed class SessionStateChanged : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public SessionStateChanged(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static SessionStateChanged sessionStateChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static IdentityTokenChanged identityTokenChanged; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void CallIdentityTokenChanged(string token) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

}

