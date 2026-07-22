namespace Effects;

public class EffectsManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public EffectsManager <>4__this; //Field offset: 0x0
		public bool isStatic; //Field offset: 0x0
		public string name; //Field offset: 0x0
		public float duration; //Field offset: 0x0
		public float speedMult; //Field offset: 0x0
		public float sizeMult; //Field offset: 0x0
		public Transform target; //Field offset: 0x0
		public object dest; //Field offset: 0x0
		public string postEffect; //Field offset: 0x0
		public Action<T, Object> callback; //Field offset: 0x0
		public object data; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass54_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = typeof(Object))]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectHandler), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "RegisterEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EffectHandler), typeof(Transform)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "GetCustomEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal void <LoadEffect>b__0(object prefab, object o) { }

	}

	public const string Synchro = "SynchroMaterial"; //Field offset: 0x0
	public const string Link = "Link"; //Field offset: 0x0
	public const string Pendulum = "Pendulum"; //Field offset: 0x0
	public const string PendulumSR = "PendulumScaleRed"; //Field offset: 0x0
	public const string PendulumSB = "PendulumScaleBlue"; //Field offset: 0x0
	public const string SetCard = "SetShine"; //Field offset: 0x0
	public const string TributeMaterial = "TributeMaterial"; //Field offset: 0x0
	public const string ExtraMaterial = "ExtraMaterial"; //Field offset: 0x0
	public const string ShuffleEffect = "Shuffle"; //Field offset: 0x0
	public const string VictoryExodia = "VictoryExodia"; //Field offset: 0x0
	public const string VictoryExodiaDefender = "VictoryExodiaDef"; //Field offset: 0x0
	public const string VictoryExodius = "VictoryExodius"; //Field offset: 0x0
	public const string DestinyBoard = "VictoryDestinyboard"; //Field offset: 0x0
	public const string AttackReady = "AttackReady"; //Field offset: 0x0
	public const string TargetAim = "TargetAim"; //Field offset: 0x0
	public const string SSJImpact = "SSJImpact"; //Field offset: 0x0
	public const string DestroyMove = "DestroyMove"; //Field offset: 0x0
	public const string StatUp = "StatUp"; //Field offset: 0x0
	public const string StatDown = "StatDown"; //Field offset: 0x0
	public const string CardCrack = "CardCrack"; //Field offset: 0x0
	public const string SpineSummonDark = "FSummonDark"; //Field offset: 0x0
	public const string SpineSummonWater = "FSummonWater"; //Field offset: 0x0
	public const string SpineSummonEarth = "FSummonEarth"; //Field offset: 0x0
	public const string SpineSummonFire = "FSummonFire"; //Field offset: 0x0
	public const string Ritual = "RitualMaterial"; //Field offset: 0x0
	public const string SpineSummonLight = "FSummonLight"; //Field offset: 0x0
	public const string SpineSummonWind = "FSummonWind"; //Field offset: 0x0
	public const string Fusion = "FusionMaterial"; //Field offset: 0x0
	public static EffectsManager Instance; //Field offset: 0x0
	public const string EdgeGlow = "EdgeGlow"; //Field offset: 0x0
	public const string ChainActivate = "Activation"; //Field offset: 0x0
	public const string Negation = "Negation"; //Field offset: 0x0
	public const string SpecialSummon = "SPSummon"; //Field offset: 0x0
	public const string NormalSummon = "NSummon"; //Field offset: 0x0
	public const string Banish = "Banish"; //Field offset: 0x0
	public const string DuelStart = "DuelStart"; //Field offset: 0x0
	public const string Destroyed = "Destroy"; //Field offset: 0x0
	public const string XYZ = "XyzVortex"; //Field offset: 0x0
	public const string AttackFire = "AttackFire"; //Field offset: 0x0
	public const string AttackWind = "AttackWind"; //Field offset: 0x0
	public const string AttackWindHit = "AttackWindPost"; //Field offset: 0x0
	public const string AttackWater = "AttackWater"; //Field offset: 0x0
	public const string AttackWaterHit = "AttackWaterPost"; //Field offset: 0x0
	public const string AttackEarth = "AttackEarth"; //Field offset: 0x0
	public const string AttackEarthHit = "AttackEarthPost"; //Field offset: 0x0
	public const string AttackDark = "AttackDark"; //Field offset: 0x0
	public const string AttackDarkHit = "AttackDarkPost"; //Field offset: 0x0
	public const string AttackLight = "AttackLight"; //Field offset: 0x0
	public const string AttackLightHit = "AttackLightPost"; //Field offset: 0x0
	public const string AttackFireHit = "AttackFirePost"; //Field offset: 0x0
	public static bool DisableGFX; //Field offset: 0x8
	private static readonly Dictionary<Transform, List`1<EffectHandler>> EffectIndex; //Field offset: 0x10
	public Transform GFXParent; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static EffectsManager() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EffectsManager() { }

	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EffectsManager), Member = "LoadEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(object), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void AddEffect(string name, Transform target, float duration = 0, Action<T, Object> callback = null, object data = null, string postEffect = "", float speedMult = 1, float sizeMult = 1, bool isStatic = false) { }

	[CalledBy(Type = "Game.DuelManager+<OnSelectSum>d__182", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "UpdateActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragClone), Member = "SwapGlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "<OnMove>g__playSpecialSummonFX|133_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass133_0&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSpSummoned>d__204", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectCounter>d__169", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnCardSorting>d__143", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnAttack>d__135", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass166_0", Member = "<OnSelectChain>g__setGlow|1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "DefineGFX", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectCard>d__164", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "LoadEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(object), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static void AddEffect(string name, MonoBehaviour target, float duration = 0, Action<T, Object> callback = null, object data = null, string postEffect = "", float speedMult = 1, float sizeMult = 1, bool isStatic = false) { }

	[CalledBy(Type = "Scenes.Battle.DuelEnd+<EndReasonAnimation>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnDamage>d__130", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "<OnMove>g__playDestroyFX|133_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass133_0&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectHandler), Member = "EndLife", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(EffectsManager), Member = "LoadEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(object), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void AddEffect(string name, Transform target, float duration = 0, string postEffect = "", float speedMult = 1, float sizeMult = 1, bool isStatic = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void AddEffect(string name, MonoBehaviour target, bool isStatic) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void AddEffect(string name, MonoBehaviour target, float duration = 0, string postEffect = "", float speedMult = 1, float sizeMult = 1) { }

	[CalledBy(Type = typeof(DuelManager), Member = "AttackProjectileAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(Transform), typeof(float), typeof(Vector3[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EffectsManager), Member = "LoadEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(object), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static void AddMovingEffect(string name, Transform target, Transform dest, Vector3[] path, string postEffect = "", float speedMult = 1, float sizeMult = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsManager), Member = "LoadEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(object), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public static void AddMovingEffect(string name, Transform target, Transform dest, Vector3[] path, Action<T, Object> callback = null, object data = null, string postEffect = "", float speedMult = 1, float sizeMult = 1) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake() { }

	[CalledBy(Type = "Game.DuelManager+<OnSpSummoned>d__204", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSummoned>d__202", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void DefineFinite(String[] effectName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsManager), Member = "GetEffectByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(EffectHandler))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void DefineFinite(string name, Transform target) { }

	[CalledBy(Type = "Game.DuelManager+<OnPacket>d__72", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(EffectHandler), Member = "RemoveFX", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void EndEffect(String[] effectName) { }

	[CalledBy(Type = "Game.DuelManager+<AttackCardMoveAnimation>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnDamage>d__130", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "AttackProjectileAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(Transform), typeof(float), typeof(Vector3[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public static String[] GetAttackElement(CardAttribute att) { }

	[CalledBy(Type = typeof(HoverZoom), Member = "SetZoomState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(EffectsManager), Member = "GetCustomEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static T GetCustomEffect(GameObject target) { }

	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardListDisplay), Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "AutoModeInit", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass143_1", Member = "<OnCardSorting>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass164_1", Member = "<OnSelectCard>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass182_1", Member = "<OnSelectSum>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "<OnSelectPlace>g__setEdge|176_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	public static T GetCustomEffect(MonoBehaviour target) { }

	[CalledBy(Type = typeof(<>c__DisplayClass54_0`1), Member = "<LoadEffect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "GetCustomEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T GetCustomEffect(Transform target) { }

	[CalledBy(Type = typeof(EffectsManager), Member = "LoadEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(object), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "RunEffectMethod", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "RunEffectMethod", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "DefineFinite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EffectsManager), Member = "RemoveAllEffects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private static EffectHandler GetEffectByName(string name, Transform target) { }

	[CalledBy(Type = typeof(EffectsManager), Member = "HasAnyEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(Action)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	public static bool HasAnyEffect(Transform target, Action callback = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(EffectsManager), Member = "HasAnyEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Action)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool HasAnyEffect(MonoBehaviour target, Action callback = null) { }

	[CalledBy(Type = typeof(EffectsManager), Member = "LoadEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(object), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "AddMovingEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(Transform), typeof(Vector3[]), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "AddMovingEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(Transform), typeof(Vector3[]), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "GetEffectByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(EffectHandler))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "LoadEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(object), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_HasCopyCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	private void LoadEffect(string name, Transform target, float duration, object dest, Action<T, Object> callback, object data, string postEffect, float speedMult, float sizeMult = 1, bool isStatic = false) { }

	[CalledBy(Type = typeof(<>c__DisplayClass54_0`1), Member = "<LoadEffect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void RegisterEffect(EffectHandler effect, Transform target) { }

	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "OnStop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragClone), Member = "SwapGlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.CardPool+<DisableCard>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public static int RemoveAllEffects(MonoBehaviour target, string name = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "GetEffectByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(EffectHandler))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "UnRegisterEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EffectHandler), typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static int RemoveAllEffects(Transform target, string name = null) { }

	[CalledBy(Type = typeof(BattlePhase), Member = "ClearData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DeactiveChainOrder", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainPhase), Member = "ClearData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "PostSelectCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(System.Collections.Generic.IList`1<Card.ClientCard>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnDamageStepStart>d__96", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnDamageStepEnd>d__100", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnAttack>d__135", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass182_0", Member = "<OnSelectSum>g__clear|1", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass176_0", Member = "<OnSelectPlace>g__answer|3", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass169_1", Member = "<OnSelectCounter>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass168_0", Member = "<PostSelectChain>g__finalResponse|2", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass166_0", Member = "<OnSelectChain>g__setGlow|1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass164_0", Member = "<OnSelectCard>g__finishClick|0", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass143_0", Member = "<OnCardSorting>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>g__clear|0", ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 1)]
	public static bool RemoveEffect(string name, MonoBehaviour target) { }

	[CalledBy(Type = "Scenes.Battle.DuelEnd+<>c__DisplayClass33_0", Member = "<EndReasonAnimation>g__finishAnimation|0", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientCard), Member = "RemoveManualTarget", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "GetEffectByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(EffectHandler))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "UnRegisterEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EffectHandler), typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static bool RemoveEffect(string name, Transform target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "GetEffectByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(EffectHandler))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void RunEffectMethod(string name, Transform target, Action<T, Object> callback, object state) { }

	[CalledBy(Type = typeof(Template), Member = "set_SelectedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(EffectsManager), Member = "GetEffectByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(EffectHandler))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static void RunEffectMethod(string name, MonoBehaviour target, Action<T, Object> callback, object state) { }

	[CalledBy(Type = typeof(EffectHandler), Member = "RemoveFX", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EffectsManager), Member = "RemoveAllEffects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public static void UnRegisterEffect(EffectHandler effect, Transform target) { }

}

