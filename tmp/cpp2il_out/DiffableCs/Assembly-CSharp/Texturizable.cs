//Type is in global namespace

public class Texturizable : MonoBehaviour
{
	public AssetType SpriteType; //Field offset: 0x20
	public bool SkipButton; //Field offset: 0x24
	public bool SkipImage; //Field offset: 0x25
	public bool CheckDisabled; //Field offset: 0x26
	private Image ImageTarget; //Field offset: 0x28
	private Button ButtonTarget; //Field offset: 0x30
	private Image ButtonTargetImage; //Field offset: 0x38
	private EventTrigger StateHandler; //Field offset: 0x40
	private string IMGSprite; //Field offset: 0x48
	private string BTNSprite; //Field offset: 0x50
	public bool CurrentState; //Field offset: 0x58

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Texturizable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texturizable), Member = "SetSpriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <InitializeButtonHandler>b__12_0(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texturizable), Member = "SetSpriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <InitializeButtonHandler>b__12_1(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texturizable), Member = "SetSpriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <InitializeButtonHandler>b__12_2(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texturizable), Member = "SetSpriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <InitializeButtonHandler>b__12_3(PointerEventData data) { }

	[CalledBy(Type = typeof(Texturizable), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texturizable), Member = "Restart", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Texturizable), Member = "InitializeImageHandler", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTrigger), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void InitializeButtonHandler(bool addHandler) { }

	[CalledBy(Type = typeof(Texturizable), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texturizable), Member = "InitializeButtonHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texturizable), Member = "Restart", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void InitializeImageHandler() { }

	[CalledBy(Type = typeof(CustomTheme), Member = "ReloadTexturizables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texturizable), Member = "InitializeImageHandler", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texturizable), Member = "InitializeButtonHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	public void Restart() { }

	[CalledBy(Type = typeof(Texturizable), Member = "<InitializeButtonHandler>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texturizable), Member = "<InitializeButtonHandler>b__12_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texturizable), Member = "<InitializeButtonHandler>b__12_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texturizable), Member = "<InitializeButtonHandler>b__12_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetSpriteState(bool active, bool force) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texturizable), Member = "InitializeImageHandler", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texturizable), Member = "InitializeButtonHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private void Start() { }

}

