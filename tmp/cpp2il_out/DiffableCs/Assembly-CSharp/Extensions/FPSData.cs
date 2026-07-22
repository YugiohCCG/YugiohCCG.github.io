namespace Extensions;

public class FPSData : MonoBehaviour
{
	private const int LOW_FPS_RATE = 24; //Field offset: 0x0
	private const float fpsMeasurePeriod = 0.5; //Field offset: 0x0
	private static FPSData m_Data; //Field offset: 0x0
	public static FPSMode DisplayFPSMode; //Field offset: 0x8
	private int m_FpsAccumulator; //Field offset: 0x20
	private float m_FpsNextPeriod; //Field offset: 0x24
	private float m_CurrentFps; //Field offset: 0x28
	private TextMeshProUGUI Display; //Field offset: 0x30
	private Canvas Holder; //Field offset: 0x38

	public static int CurrentFPS
	{
		[CalledBy(Type = typeof(FPSData), Member = "get_IsLowFPS", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 140
	}

	public static bool DisplayFPS
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 58
	}

	public static bool IsLowFPS
	{
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__0", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__1", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelManager), Member = "AttackProjectileAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(Transform), typeof(float), typeof(Vector3[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(FPSData), Member = "get_CurrentFPS", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 22
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FPSData() { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(AnchorExtensions), Member = "SetAnchorAndPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(PivotPresets)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static void DefineDisplay(FPSMode anchor) { }

	[CalledBy(Type = typeof(FPSData), Member = "get_IsLowFPS", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_CurrentFPS() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool get_DisplayFPS() { }

	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "AttackProjectileAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(Transform), typeof(float), typeof(Vector3[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FPSData), Member = "get_CurrentFPS", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsLowFPS() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(AnchorExtensions), Member = "SetAnchorAndPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(PivotPresets)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update() { }

}

