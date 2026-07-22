namespace UnityEngine.UnityConsent;

public struct ConsentState
{
	public ConsentStatus AdsIntent; //Field offset: 0x0
	public ConsentStatus AnalyticsIntent; //Field offset: 0x4

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ConsentState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public virtual string ToString() { }

}

