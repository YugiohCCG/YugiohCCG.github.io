namespace UnityEngine.InputSystem.LowLevel;

[Extension]
internal static class InputUpdate
{
	internal struct SerializedState
	{
		public InputUpdateType lastUpdateType; //Field offset: 0x0
		public UpdateStepCount playerUpdateStepCount; //Field offset: 0x4

	}

	internal struct UpdateStepCount
	{
		private bool m_WasUpdated; //Field offset: 0x0
		[CompilerGenerated]
		private uint <value>k__BackingField; //Field offset: 0x4

		public private uint value
		{
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 4
			[CallerCount(Count = 9)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public uint get_value() { }

		[CallerCount(Count = 0)]
		public void OnBeforeUpdate() { }

		[CallerCount(Count = 0)]
		public void OnUpdate() { }

		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_value(uint value) { }

	}

	public static uint s_UpdateStepCount; //Field offset: 0x0
	public static InputUpdateType s_LatestUpdateType; //Field offset: 0x4
	public static UpdateStepCount s_PlayerUpdateStepCount; //Field offset: 0x8

	[CalledBy(Type = typeof(InputManager), Member = "get_defaultUpdateType", ReturnType = typeof(InputUpdateType))]
	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ReallocateStateBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static InputUpdateType GetUpdateTypeForPlayer(InputUpdateType mask) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsPlayerUpdate(InputUpdateType updateType) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static void OnBeforeUpdate(InputUpdateType type) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static void OnUpdate(InputUpdateType type) { }

	[CalledBy(Type = typeof(InputManager), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "InstallGlobals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public static void Restore(SerializedState state) { }

	[CallerCount(Count = 0)]
	public static SerializedState Save() { }

}

