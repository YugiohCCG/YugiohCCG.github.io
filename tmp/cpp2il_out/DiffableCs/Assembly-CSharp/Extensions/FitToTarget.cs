namespace Extensions;

[ExecuteInEditMode]
public class FitToTarget : MonoBehaviour
{
	public RectTransform Target; //Field offset: 0x20
	private RectTransform Self; //Field offset: 0x28
	public bool Vertically; //Field offset: 0x30
	public bool Horizontally; //Field offset: 0x31
	public float HorizontalOffset; //Field offset: 0x34
	public float VerticalOffset; //Field offset: 0x38
	public float MinX; //Field offset: 0x3C
	public float MinY; //Field offset: 0x40

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FitToTarget() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 5)]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Update() { }

}

