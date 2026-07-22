namespace UnityEngine.InputSystem.UI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/UISupport.html#multiplayer-uis")]
public class MultiplayerEventSystem : EventSystem
{
	[SerializeField]
	[Tooltip("If set, only process mouse and navigation events for any game objects which are children of this game object.")]
	private GameObject m_PlayerRoot; //Field offset: 0x60

	public GameObject playerRoot
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MultiplayerEventSystem), Member = "InitializePlayerRoot", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 37
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = ".ctor", ReturnType = typeof(void))]
	public MultiplayerEventSystem() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public GameObject get_playerRoot() { }

	[CalledBy(Type = typeof(MultiplayerEventSystem), Member = "set_playerRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiplayerEventSystem), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void InitializePlayerRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "OnDisable", ReturnType = typeof(void))]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiplayerEventSystem), Member = "InitializePlayerRoot", ReturnType = typeof(void))]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiplayerEventSystem), Member = "InitializePlayerRoot", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_playerRoot(GameObject value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(EventSystem), Member = "set_current", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "Update", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Update() { }

}

