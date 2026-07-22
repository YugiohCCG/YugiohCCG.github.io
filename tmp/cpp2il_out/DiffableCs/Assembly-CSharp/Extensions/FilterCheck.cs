namespace Extensions;

public class FilterCheck : AudibleObject
{
	public TMP_Text Label; //Field offset: 0x28
	public Toggle Self; //Field offset: 0x30

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FilterCheck() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FilterCheck), Member = "ChangeState", ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__2_0(bool enabled) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "TryResetFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "LoadToggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "TryLoadFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "ResetToggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FilterCheck), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FilterCheck), Member = "<Start>b__2_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyles)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ChangeState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilterCheck), Member = "ChangeState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start() { }

}

