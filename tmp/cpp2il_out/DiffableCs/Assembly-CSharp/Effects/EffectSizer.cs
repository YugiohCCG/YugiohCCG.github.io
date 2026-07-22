namespace Effects;

public class EffectSizer : MonoBehaviour
{
	public float ReferenceSize; //Field offset: 0x20
	private EffectHandler Handler; //Field offset: 0x28
	private Vector3 OriginalScale; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public EffectSizer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Update() { }

}

