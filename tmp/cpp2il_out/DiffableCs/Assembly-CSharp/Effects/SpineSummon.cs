namespace Effects;

public class SpineSummon : MonoBehaviour
{
	[SerializeField]
	private SynchroSummon Synchro; //Field offset: 0x20
	[SerializeField]
	private FusionSummon Fusion; //Field offset: 0x28
	[SerializeField]
	private LinkSummon Link; //Field offset: 0x30
	[SerializeField]
	private RitualSummon Ritual; //Field offset: 0x38
	[SerializeField]
	private ParticleSystem SPNormal; //Field offset: 0x40
	[SerializeField]
	private ParticleSystem Pendulum; //Field offset: 0x48
	[SerializeField]
	private ParticleSystem Xyz; //Field offset: 0x50

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SpineSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpineSummon), Member = "DefineData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void DefineData(SpineSummon target, object callback) { }

	[CalledBy(Type = typeof(SpineSummon), Member = "DefineData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpineSummon), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpineSummon), Member = "TryPassToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SynchroSummon), Member = "SetLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FusionSummon), Member = "SetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkSummon), Member = "SetArrows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "get_LinkMarker", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(RitualSummon), Member = "SetFlames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "GetComponentInChildrenOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void DefineData(Card card, int extraData, bool tryPass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(General), Member = "GetComponentInChildrenOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpineSummon), Member = "DefineData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool TryPassToChildren(Card card, int extraData) { }

}

