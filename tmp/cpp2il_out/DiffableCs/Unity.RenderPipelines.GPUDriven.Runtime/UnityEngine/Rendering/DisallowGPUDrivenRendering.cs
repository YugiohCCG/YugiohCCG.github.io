namespace UnityEngine.Rendering;

[ExecuteInEditMode]
internal class DisallowGPUDrivenRendering : MonoBehaviour
{
	private bool m_AppliedRecursively; //Field offset: 0x20
	[FormerlySerializedAs("applyToChildrenRecursively")]
	public bool m_applyToChildrenRecursively; //Field offset: 0x21

	public bool applyToChildrenRecursively
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DisallowGPUDrivenRendering), Member = "OnDisable", ReturnType = typeof(void))]
		[Calls(Type = typeof(DisallowGPUDrivenRendering), Member = "OnEnable", ReturnType = typeof(void))]
		 set { } //Length: 34
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DisallowGPUDrivenRendering() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_allowGPUDrivenRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void AllowGPUDrivenRendering(Transform transform, bool allow) { }

	[CalledBy(Type = typeof(DisallowGPUDrivenRendering), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisallowGPUDrivenRendering), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisallowGPUDrivenRendering), Member = "AllowGPUDrivenRenderingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_allowGPUDrivenRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(DisallowGPUDrivenRendering), Member = "AllowGPUDrivenRenderingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void AllowGPUDrivenRenderingRecursively(Transform transform, bool allow) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_applyToChildrenRecursively() { }

	[CalledBy(Type = typeof(DisallowGPUDrivenRendering), Member = "set_applyToChildrenRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisallowGPUDrivenRendering), Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_allowGPUDrivenRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisallowGPUDrivenRendering), Member = "AllowGPUDrivenRenderingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable() { }

	[CalledBy(Type = typeof(DisallowGPUDrivenRendering), Member = "set_applyToChildrenRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisallowGPUDrivenRendering), Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_allowGPUDrivenRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisallowGPUDrivenRendering), Member = "AllowGPUDrivenRenderingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DisallowGPUDrivenRendering), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DisallowGPUDrivenRendering), Member = "OnEnable", ReturnType = typeof(void))]
	private void OnValidate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DisallowGPUDrivenRendering), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(DisallowGPUDrivenRendering), Member = "OnEnable", ReturnType = typeof(void))]
	public void set_applyToChildrenRecursively(bool value) { }

}

