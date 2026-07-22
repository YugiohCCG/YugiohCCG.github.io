namespace UnityEngine.InputSystem;

public class InputActionReference : ScriptableObject
{
	[SerializeField]
	internal InputActionAsset m_Asset; //Field offset: 0x18
	[SerializeField]
	internal string m_ActionId; //Field offset: 0x20
	private InputAction m_Action; //Field offset: 0x28

	public InputAction action
	{
		[CalledBy(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UpdateReferenceForNewAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(InputActionReference))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "HaveControlForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputActionReference)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "TryDisableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "EnableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationModel&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionReference), Member = "ToInputAction", ReturnType = typeof(InputAction))]
		[CalledBy(Type = typeof(InputActionReference), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(InputAction))]
		[CalledBy(Type = typeof(InputActionReference), Member = "ToDisplayName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputActionReference), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "HasNoActions", ReturnType = typeof(bool))]
		[CallerCount(Count = 63)]
		[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 361
	}

	public InputActionAsset asset
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 36
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public InputActionReference() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void CheckImmutableReference() { }

	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UpdateReferenceForNewAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(InputActionReference))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionReference), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static InputActionReference Create(InputAction action) { }

	[CalledBy(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "HasNoActions", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionReference), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionReference), Member = "ToDisplayName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionReference), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionReference), Member = "ToInputAction", ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationModel&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "EnableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "TryDisableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "HaveControlForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputActionReference)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UpdateReferenceForNewAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(InputActionReference))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 63)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public InputAction get_action() { }

	[CallerCount(Count = 0)]
	public InputActionAsset get_asset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string GetDisplayName(InputAction action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void Invalidate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
	[CallsUnknownMethods(Count = 4)]
	internal static void InvalidateAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	public static InputAction op_Implicit(InputActionReference reference) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionReference), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void Set(InputAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionReference), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 23)]
	public void Set(InputActionAsset asset, string mapName, string actionName) { }

	[CalledBy(Type = typeof(InputActionReference), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionReference), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionReference), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(InputActionReference))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputAction), Member = "get_id", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void SetInternal(InputActionAsset assetArg, InputAction actionArg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal string ToDisplayName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	public InputAction ToInputAction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	public virtual string ToString() { }

}

