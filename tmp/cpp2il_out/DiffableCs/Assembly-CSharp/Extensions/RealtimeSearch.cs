namespace Extensions;

public class RealtimeSearch : MonoBehaviour
{
	private const float TYPE_SEARCH_COOLTIME = 0.1; //Field offset: 0x0
	public static bool SearchAsType; //Field offset: 0x0
	private float SearchCooldown; //Field offset: 0x20
	private bool HasSearchQueued; //Field offset: 0x24
	private Action SearchAction; //Field offset: 0x28

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RealtimeSearch() { }

	[CalledBy(Type = typeof(RealtimeSearch), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DoTypeSearch() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EndEditSearch(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(RealtimeSearch), Member = "DoTypeSearch", ReturnType = typeof(void))]
	private void FixedUpdate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SearchOnType(string s) { }

	[CalledBy(Type = typeof(ReplayList), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static RealtimeSearch Setup(GameObject target, Action search, TMP_InputField field) { }

}

