namespace Effects;

public class EffectColor : MonoBehaviour
{
	private const float DARK_THRESHOLD = 0.8; //Field offset: 0x0
	private ParticleSystem EffectSystem; //Field offset: 0x20

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EffectColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainModule), Member = "get_startColor", ReturnType = typeof(MinMaxGradient))]
	[Calls(Type = typeof(MainModule), Member = "set_startColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxGradient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorOverLifetimeModule), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxGradient)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public static void DefineColor(EffectColor color, object state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainModule), Member = "get_startColor", ReturnType = typeof(MinMaxGradient))]
	[Calls(Type = typeof(MainModule), Member = "set_startColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxGradient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorOverLifetimeModule), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxGradient)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private void DefineColor(Color color) { }

	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static Color GetColorForAttribute(CardAttribute at) { }

}

