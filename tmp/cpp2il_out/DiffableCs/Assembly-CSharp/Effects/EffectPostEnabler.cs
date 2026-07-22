namespace Effects;

public class EffectPostEnabler : MonoBehaviour
{
	private ParticleSystem Particles; //Field offset: 0x20

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EffectPostEnabler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable() { }

}

