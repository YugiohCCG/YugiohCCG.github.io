namespace UnityEngine.InputForUI;

internal struct EventSanitizer
{
	private interface IEventSanitizer
	{

		public void AfterProviderUpdate() { }

		public void BeforeProviderUpdate() { }

		public void Inspect(in Event ev) { }

		public void Reset() { }

	}

	private IEventSanitizer[] _sanitizers; //Field offset: 0x0

	[CalledBy(Type = typeof(EventProvider), Member = "NotifyUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventSanitizer), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void AfterProviderUpdate() { }

	[CalledBy(Type = typeof(EventProvider), Member = "NotifyUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventSanitizer), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void BeforeProviderUpdate() { }

	[CalledBy(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventSanitizer), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Inspect(in Event ev) { }

	[CalledBy(Type = typeof(EventProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSanitizer), Member = "BeforeProviderUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSanitizer), Member = "AfterProviderUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSanitizer), Member = "Inspect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Reset() { }

}

