//Type is in global namespace

public class RandomParticleRotation : MonoBehaviour
{
	public bool x; //Field offset: 0x20
	public bool y; //Field offset: 0x21
	public bool z; //Field offset: 0x22

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RandomParticleRotation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Random), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable() { }

}

