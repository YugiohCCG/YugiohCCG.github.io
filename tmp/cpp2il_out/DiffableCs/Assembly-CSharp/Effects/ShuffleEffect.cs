namespace Effects;

public class ShuffleEffect : MonoBehaviour
{
	public ParticleSystem RMSystem; //Field offset: 0x20
	public ParticleSystemRenderer RMSystemRenderer; //Field offset: 0x28

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ShuffleEffect() { }

	[CalledBy(Type = typeof(ShuffleEffect), Member = "SetSleeveMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShuffleEffect), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSleeveMaterial(Player owner) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShuffleEffect), Member = "SetSleeveMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SetSleeveMaterial(ShuffleEffect target, object callback) { }

}

