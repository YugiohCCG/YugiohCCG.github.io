namespace UnityEngine.Rendering;

[ExecuteInEditMode]
internal class DisallowSmallMeshCulling : MonoBehaviour
{
	private bool m_AppliedRecursively; //Field offset: 0x20
	public bool m_applyToChildrenRecursively; //Field offset: 0x21

	public bool applyToChildrenRecursively
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DisallowSmallMeshCulling), Member = "OnDisable", ReturnType = typeof(void))]
		[Calls(Type = typeof(DisallowSmallMeshCulling), Member = "OnEnable", ReturnType = typeof(void))]
		 set { } //Length: 34
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DisallowSmallMeshCulling() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_smallMeshCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void AllowSmallMeshCulling(Transform transform, bool allow) { }

	[CalledBy(Type = typeof(DisallowSmallMeshCulling), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisallowSmallMeshCulling), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisallowSmallMeshCulling), Member = "AllowSmallMeshCullingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_smallMeshCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(DisallowSmallMeshCulling), Member = "AllowSmallMeshCullingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void AllowSmallMeshCullingRecursively(Transform transform, bool allow) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_applyToChildrenRecursively() { }

	[CalledBy(Type = typeof(DisallowSmallMeshCulling), Member = "set_applyToChildrenRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisallowSmallMeshCulling), Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_smallMeshCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisallowSmallMeshCulling), Member = "AllowSmallMeshCullingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable() { }

	[CalledBy(Type = typeof(DisallowSmallMeshCulling), Member = "set_applyToChildrenRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisallowSmallMeshCulling), Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_smallMeshCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisallowSmallMeshCulling), Member = "AllowSmallMeshCullingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DisallowSmallMeshCulling), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(DisallowSmallMeshCulling), Member = "OnEnable", ReturnType = typeof(void))]
	private void OnValidate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DisallowSmallMeshCulling), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(DisallowSmallMeshCulling), Member = "OnEnable", ReturnType = typeof(void))]
	public void set_applyToChildrenRecursively(bool value) { }

}

