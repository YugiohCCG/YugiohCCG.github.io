namespace UnityEngine.InputSystem;

public struct InputActionProperty : IEquatable<InputActionProperty>, IEquatable<InputAction>, IEquatable<InputActionReference>
{
	[SerializeField]
	private bool m_UseReference; //Field offset: 0x0
	[SerializeField]
	private InputAction m_Action; //Field offset: 0x8
	[SerializeField]
	private InputActionReference m_Reference; //Field offset: 0x10

	public InputAction action
	{
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 138
	}

	public InputActionReference reference
	{
		[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		 get { } //Length: 13
	}

	internal InputAction serializedAction
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal InputActionReference serializedReference
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_positionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_rotationAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public InputActionProperty(InputAction action) { }

	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public InputActionProperty(InputActionReference reference) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(InputActionProperty other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(InputAction other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override bool Equals(InputActionReference other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 72)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[CallsUnknownMethods(Count = 1)]
	public InputAction get_action() { }

	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	public InputActionReference get_reference() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal InputAction get_serializedAction() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal InputActionReference get_serializedReference() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(PlayerInputManager), Member = "set_joinAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(InputActionProperty left, InputActionProperty right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(InputActionProperty left, InputActionProperty right) { }

}

