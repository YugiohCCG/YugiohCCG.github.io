namespace Scenes.Battle;

public class FieldBG : MonoBehaviour
{
	private const string MATERIAL_TEXTURE_NAME = "_MainTex"; //Field offset: 0x0
	private ParticleSystem PlayerMat; //Field offset: 0x20
	private ParticleSystem OpponentMat; //Field offset: 0x28
	[CompilerGenerated]
	private ParticleSystem <FieldMask>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ParticleSystem <OpponentMask>k__BackingField; //Field offset: 0x38
	private ParticleSystem FieldActivationBlink; //Field offset: 0x40
	private ParticleSystem OpponentActivationBlink; //Field offset: 0x48
	private bool ShowSpellBG; //Field offset: 0x50
	private bool OppSpellBG; //Field offset: 0x51
	private bool FullSpellBG; //Field offset: 0x52

	public Texture FieldBGTex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Texture))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 147
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldBG), Member = "SetTexOnPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Texture)}, ReturnType = typeof(void))]
		 set { } //Length: 15
	}

	public private ParticleSystem FieldMask
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public bool FieldMaskActive
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
	}

	public Texture OpponentBGTex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Texture))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 147
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldBG), Member = "SetTexOnPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Texture)}, ReturnType = typeof(void))]
		 set { } //Length: 15
	}

	public bool OpponentFieldMaskActive
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
	}

	public private ParticleSystem OpponentMask
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FieldBG() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DisablePlaymats() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldBG), Member = "SetPSSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EnableOpponentPlaymat(Player owner) { }

	[CalledBy(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldBG), Member = "SetPSSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EnablePlayerPlaymat(Player owner) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldBG), Member = "SetPSSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnablePlaymat(ParticleSystem mat, Player owner) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Texture))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Texture get_FieldBGTex() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ParticleSystem get_FieldMask() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_FieldMaskActive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Texture))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Texture get_OpponentBGTex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_OpponentFieldMaskActive() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ParticleSystem get_OpponentMask() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Texture))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Texture GetTexFromPS(ParticleSystem ps) { }

	[CalledBy(Type = typeof(FieldBG), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CustomTheme), Member = "ReloadTexturizables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldBG), Member = "SetTexOnPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Texture)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Restart() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldBG), Member = "SetTexOnPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Texture)}, ReturnType = typeof(void))]
	public void set_FieldBGTex(Texture value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_FieldMask(ParticleSystem value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldBG), Member = "SetTexOnPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Texture)}, ReturnType = typeof(void))]
	public void set_OpponentBGTex(Texture value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_OpponentMask(ParticleSystem value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetFieldBGTex(Texture spr) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<SetFieldBackground>d__101", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "DefineBGState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "SetFieldSpellState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "SetPSMaskState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SetFieldSpellMaskState(bool state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldBG), Member = "SetFieldSpellMaskState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldBG), Member = "SetOpponentFieldSpellState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void SetFieldSpellState(bool state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetOpponentBGTex(Texture spr) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<SetFieldBackground>d__101", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "DefineBGState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "SetFieldSpellState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "SetPSMaskState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SetOpponentFieldSpellState(bool state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldBG), Member = "SetOpponentFieldSpellState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldBG), Member = "SetFieldSpellMaskState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void SetPSMaskState(ParticleSystem ps, bool state) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<SetFieldBackground>d__101", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "EnablePlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Player)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "EnablePlayerPlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "EnableOpponentPlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetPSSprite(ParticleSystem ps, Sprite spr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetPSTex(ParticleSystem ps, Texture tex) { }

	[CalledBy(Type = typeof(FieldBG), Member = "set_OpponentBGTex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "set_FieldBGTex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "Restart", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetTexOnPS(ParticleSystem ps, Texture tex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(FieldBG), Member = "Restart", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void Start() { }

}

