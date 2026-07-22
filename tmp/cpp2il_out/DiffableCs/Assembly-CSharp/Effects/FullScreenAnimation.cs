namespace Effects;

public class FullScreenAnimation : MonoBehaviour
{
	private const float SCALE_MULT = 53; //Field offset: 0x0
	private const float BASE_RATIO = 1.7777778; //Field offset: 0x0
	[SerializeField]
	private RectTransform[] StretchTargets; //Field offset: 0x20
	[SerializeField]
	private RectTransform[] PreserveRatioTargets; //Field offset: 0x28
	[SerializeField]
	private bool Stretch; //Field offset: 0x30
	private readonly Dictionary<RectTransform, Vector3> OriginalRatios; //Field offset: 0x38

	private bool HasPreserveTargets
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 22
	}

	private bool HasStretchTargets
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 22
	}

	private bool ShouldStretch
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 35
	}

	private float StretchRatio
	{
		[CalledBy(Type = typeof(FullScreenAnimation), Member = "get_StretchX", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FullScreenAnimation), Member = "get_StretchY", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FullScreenAnimation), Member = "get_StretchYRatio", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(FullScreenAnimation), Member = "get_StretchXRatio", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(FullScreenAnimation), Member = "SetupAnimation", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FullScreenAnimation), Member = "ApplyStretching", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FullScreenAnimation), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 257
	}

	private bool StretchX
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 26
	}

	private float StretchXRatio
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
		private get { } //Length: 53
	}

	private bool StretchY
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 30
	}

	private float StretchYRatio
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
		private get { } //Length: 83
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public FullScreenAnimation() { }

	[CalledBy(Type = typeof(FullScreenAnimation), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyPreserving() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Vector3>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyStretching() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_HasPreserveTargets() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_HasStretchTargets() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_ShouldStretch() { }

	[CalledBy(Type = typeof(FullScreenAnimation), Member = "get_StretchX", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FullScreenAnimation), Member = "get_StretchY", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FullScreenAnimation), Member = "get_StretchYRatio", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(FullScreenAnimation), Member = "get_StretchXRatio", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(FullScreenAnimation), Member = "SetupAnimation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FullScreenAnimation), Member = "ApplyStretching", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FullScreenAnimation), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private float get_StretchRatio() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	private bool get_StretchX() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
	private float get_StretchXRatio() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	private bool get_StretchY() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
	private float get_StretchYRatio() { }

	[CalledBy(Type = typeof(FullScreenAnimation), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetupAnimation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Vector3>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FullScreenAnimation), Member = "SetupAnimation", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Vector3>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(FullScreenAnimation), Member = "get_StretchRatio", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FullScreenAnimation), Member = "ApplyPreserving", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Update() { }

}

