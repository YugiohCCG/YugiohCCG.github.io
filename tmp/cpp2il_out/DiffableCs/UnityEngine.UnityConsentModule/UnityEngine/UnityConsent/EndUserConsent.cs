namespace UnityEngine.UnityConsent;

[NativeHeader("Modules/UnityConsent/EndUserConsent.h")]
public static class EndUserConsent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<ConsentState> consentStateChanged; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod("GetConsentStateStatic")]
	public static ConsentState GetConsentState() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetConsentState_Injected(out ConsentState ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	private static void OnConsentStateChanged() { }

}

