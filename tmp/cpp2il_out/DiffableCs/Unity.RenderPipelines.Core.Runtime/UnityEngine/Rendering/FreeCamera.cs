namespace UnityEngine.Rendering;

public class FreeCamera : MonoBehaviour
{
	private const float k_MouseSensitivityMultiplier = 0.01; //Field offset: 0x0
	public float m_LookSpeedController; //Field offset: 0x20
	public float m_LookSpeedMouse; //Field offset: 0x24
	public float m_MoveSpeed; //Field offset: 0x28
	public float m_MoveSpeedIncrement; //Field offset: 0x2C
	public float m_Turbo; //Field offset: 0x30
	private InputAction lookAction; //Field offset: 0x38
	private InputAction moveAction; //Field offset: 0x40
	private InputAction speedAction; //Field offset: 0x48
	private InputAction yMoveAction; //Field offset: 0x50
	private float inputRotateAxisX; //Field offset: 0x58
	private float inputRotateAxisY; //Field offset: 0x5C
	private float inputChangeSpeed; //Field offset: 0x60
	private float inputVertical; //Field offset: 0x64
	private float inputHorizontal; //Field offset: 0x68
	private float inputYAxis; //Field offset: 0x6C
	private bool leftShiftBoost; //Field offset: 0x70
	private bool leftShift; //Field offset: 0x71
	private bool fire1; //Field offset: 0x72

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FreeCamera() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FreeCamera), Member = "RegisterInputs", ReturnType = typeof(void))]
	private void OnEnable() { }

	[CalledBy(Type = typeof(FreeCamera), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(BindingSyntax), Member = "WithProcessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(CompositeSyntax))]
	[Calls(Type = typeof(CompositeSyntax), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(CompositeSyntax))]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void RegisterInputs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "get_displayRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FreeCamera), Member = "UpdateInputs", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void Update() { }

	[CalledBy(Type = typeof(FreeCamera), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Keyboard), Member = "get_leftShiftKey", ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void UpdateInputs() { }

}

