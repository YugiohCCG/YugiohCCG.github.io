namespace UnityEngine.Rendering;

public class CameraSwitcher : MonoBehaviour
{
	public Camera[] m_Cameras; //Field offset: 0x20
	private int m_CurrentCameraIndex; //Field offset: 0x28
	private Camera m_OriginalCamera; //Field offset: 0x30
	private Vector3 m_OriginalCameraPosition; //Field offset: 0x38
	private Quaternion m_OriginalCameraRotation; //Field offset: 0x44
	private Camera m_CurrentCamera; //Field offset: 0x58
	private GUIContent[] m_CameraNames; //Field offset: 0x60
	private Int32[] m_CameraIndices; //Field offset: 0x68
	private EnumField m_DebugEntry; //Field offset: 0x70
	private int m_DebugEntryEnumIndex; //Field offset: 0x78

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CameraSwitcher() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private int <OnEnable>b__10_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraSwitcher), Member = "SetCameraIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <OnEnable>b__10_1(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private int <OnEnable>b__10_2() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <OnEnable>b__10_3(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int GetCameraCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private Camera GetNextCamera() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObservableList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(EnumField`1), Member = "set_enumValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(Panel))]
	[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 24)]
	private void OnEnable() { }

	[CalledBy(Type = typeof(CameraSwitcher), Member = "<OnEnable>b__10_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SetCameraIndex(int index) { }

}

