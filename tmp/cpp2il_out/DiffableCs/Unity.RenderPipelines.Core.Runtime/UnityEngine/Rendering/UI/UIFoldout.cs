namespace UnityEngine.Rendering.UI;

[ExecuteAlways]
public class UIFoldout : Toggle
{
	public GameObject content; //Field offset: 0x128
	public GameObject arrowOpened; //Field offset: 0x130
	public GameObject arrowClosed; //Field offset: 0x138

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "ClassifyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public UIFoldout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFoldout), Member = "SetState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	private void OnValidate() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public void SetState(bool state) { }

	[CalledBy(Type = typeof(UIFoldout), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIFoldout), Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "ForceRebuildLayoutImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetState(bool state, bool rebuildLayout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIFoldout), Member = "SetState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Start() { }

}

