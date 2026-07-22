namespace UnityEngine.InputSystem;

public struct InputControlScheme : IEquatable<InputControlScheme>
{
	internal struct DeviceRequirement : IEquatable<DeviceRequirement>
	{
		[Flags]
		public enum Flags
		{
			None = 0,
			Optional = 1,
			Or = 2,
		}

		[SerializeField]
		internal string m_ControlPath; //Field offset: 0x0
		[SerializeField]
		internal Flags m_Flags; //Field offset: 0x8

		public string controlPath
		{
			[CallerCount(Count = 138)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 5)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 8
		}

		public bool isAND
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			 set { } //Length: 25
		}

		public bool isOptional
		{
			[CalledBy(Type = typeof(InputControlScheme), Member = "PickDevicesFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", typeof(InputDevice)}, ReturnType = typeof(MatchResult))]
			[CallerCount(Count = 1)]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			 set { } //Length: 25
		}

		public bool isOR
		{
			[CallerCount(Count = 6)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 25
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public override bool Equals(DeviceRequirement other) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		public string get_controlPath() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_isAND() { }

		[CalledBy(Type = typeof(InputControlScheme), Member = "PickDevicesFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", typeof(InputDevice)}, ReturnType = typeof(MatchResult))]
		[CallerCount(Count = 1)]
		public bool get_isOptional() { }

		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_isOR() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public static bool op_Equality(DeviceRequirement left, DeviceRequirement right) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public static bool op_Inequality(DeviceRequirement left, DeviceRequirement right) { }

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_controlPath(string value) { }

		[CallerCount(Count = 0)]
		public void set_isAND(bool value) { }

		[CallerCount(Count = 0)]
		public void set_isOptional(bool value) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public void set_isOR(bool value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		public virtual string ToString() { }

	}

	[DefaultMember("Item")]
	internal struct MatchResult : IEnumerable<Match>, IEnumerable, IDisposable
	{
		private struct Enumerator : IEnumerator<Match>, IEnumerator, IDisposable
		{
			internal int m_Index; //Field offset: 0x0
			internal DeviceRequirement[] m_Requirements; //Field offset: 0x8
			internal InputControlList<InputControl> m_Controls; //Field offset: 0x10

			public override Match Current
			{
				[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
				[CallerCount(Count = 1)]
				[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[CallsUnknownMethods(Count = 5)]
				 get { } //Length: 176
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(Match))]
				private get { } //Length: 108
			}

			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			public override void Dispose() { }

			[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 5)]
			public override Match get_Current() { }

			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			public override bool MoveNext() { }

			[CallerCount(Count = 0)]
			public override void Reset() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(Match))]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		internal struct Match
		{
			internal int m_RequirementIndex; //Field offset: 0x0
			internal DeviceRequirement[] m_Requirements; //Field offset: 0x8
			internal InputControlList<InputControl> m_Controls; //Field offset: 0x10

			public InputControl control
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
				 get { } //Length: 60
			}

			public InputDevice device
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
				 get { } //Length: 76
			}

			public bool isOptional
			{
				[CallerCount(Count = 0)]
				[CallsUnknownMethods(Count = 2)]
				[ContainsUnimplementedInstructions]
				 get { } //Length: 48
			}

			public DeviceRequirement requirement
			{
				[CallerCount(Count = 0)]
				[CallsUnknownMethods(Count = 2)]
				 get { } //Length: 56
			}

			public int requirementIndex
			{
				[CallerCount(Count = 173)]
				[DeduplicatedMethod]
				 get { } //Length: 3
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
			public InputControl get_control() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
			public InputDevice get_device() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			public bool get_isOptional() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public DeviceRequirement get_requirement() { }

			[CallerCount(Count = 173)]
			[DeduplicatedMethod]
			public int get_requirementIndex() { }

		}

		public enum Result
		{
			AllSatisfied = 0,
			MissingRequired = 1,
			MissingOptional = 2,
		}

		internal Result m_Result; //Field offset: 0x0
		internal float m_Score; //Field offset: 0x4
		internal InputControlList<InputDevice> m_Devices; //Field offset: 0x8
		internal InputControlList<InputControl> m_Controls; //Field offset: 0x28
		internal DeviceRequirement[] m_Requirements; //Field offset: 0x48

		public InputControlList<InputDevice> devices
		{
			[CalledBy(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputControlScheme&), typeof(MatchResult&), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(InputControlList`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
			[Calls(Type = typeof(InputControlList`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
			 get { } //Length: 320
		}

		public bool hasMissingOptionalDevices
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 7
		}

		public bool hasMissingRequiredDevices
		{
			[CallerCount(Count = 5)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		public bool isSuccessfulMatch
		{
			[CalledBy(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputControlScheme&), typeof(MatchResult&), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(InputUser), Member = "ActivateControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputControlScheme)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 7
		}

		public Match Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 5)]
			 get { } //Length: 174
		}

		public float score
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
		}

		[CalledBy(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputDevice), typeof(bool)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
		[CalledBy(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputControlScheme&), typeof(MatchResult&), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "ActivateControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputControlScheme)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "RemoveUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "DisposeAndResetGlobalState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "ResetGlobals", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(InputControlList`1), Member = "Dispose", ReturnType = typeof(void))]
		public override void Dispose() { }

		[CalledBy(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputControlScheme&), typeof(MatchResult&), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputControlList`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
		[Calls(Type = typeof(InputControlList`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
		public InputControlList<InputDevice> get_devices() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_hasMissingOptionalDevices() { }

		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_hasMissingRequiredDevices() { }

		[CalledBy(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputControlScheme&), typeof(MatchResult&), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputUser), Member = "ActivateControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputControlScheme)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		public bool get_isSuccessfulMatch() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public Match get_Item(int index) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float get_score() { }

		[CalledBy(Type = typeof(MatchResult), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override IEnumerator<Match> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MatchResult), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<UnityEngine.InputSystem.InputControlScheme+MatchResult+Match>))]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	public struct SchemeJson
	{
		internal struct DeviceJson
		{
			public string devicePath; //Field offset: 0x0
			public bool isOptional; //Field offset: 0x8
			public bool isOR; //Field offset: 0x9

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			public static DeviceJson From(DeviceRequirement requirement) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public DeviceRequirement ToDeviceEntry() { }

		}

		public string name; //Field offset: 0x0
		public string bindingGroup; //Field offset: 0x8
		public DeviceJson[] devices; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		public static SchemeJson ToJson(InputControlScheme scheme) { }

		[CalledBy(Type = typeof(InputActionAsset), Member = "ToJson", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		public static SchemeJson[] ToJson(InputControlScheme[] schemes) { }

		[CalledBy(Type = typeof(SchemeJson), Member = "ToSchemes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemeJson[])}, ReturnType = typeof(InputControlScheme[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 8)]
		public InputControlScheme ToScheme() { }

		[CalledBy(Type = typeof(ReadFileJson), Member = "ToAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SchemeJson), Member = "ToScheme", ReturnType = typeof(InputControlScheme))]
		[CallsUnknownMethods(Count = 4)]
		public static InputControlScheme[] ToSchemes(SchemeJson[] schemes) { }

	}

	[SerializeField]
	internal string m_Name; //Field offset: 0x0
	[SerializeField]
	internal string m_BindingGroup; //Field offset: 0x8
	[SerializeField]
	internal DeviceRequirement[] m_DeviceRequirements; //Field offset: 0x10

	public string bindingGroup
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public ReadOnlyArray<DeviceRequirement> deviceRequirements
	{
		[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		 get { } //Length: 83
	}

	public string name
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlScheme), Member = "SetNameAndBindingGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeviceRequirement)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputControlScheme+DeviceRequirement>)}, ReturnType = typeof(DeviceRequirement[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public InputControlScheme(string name, IEnumerable<DeviceRequirement> devices = null, string bindingGroup = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlScheme), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(InputControlScheme), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlScheme), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlScheme), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(InputControlScheme other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OneOrMore`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public static Nullable<InputControlScheme> FindControlSchemeForDevice(InputDevice device, TSchemes schemes) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputControlScheme&), typeof(MatchResult&), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MatchResult), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static Nullable<InputControlScheme> FindControlSchemeForDevices(TDevices devices, TSchemes schemes, InputDevice mustIncludeDevice = null, bool allowUnsuccesfulMatch = false) { }

	[CalledBy(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputDevice), typeof(bool)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlScheme), Member = "PickDevicesFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", typeof(InputDevice)}, ReturnType = typeof(MatchResult))]
	[Calls(Type = typeof(MatchResult), Member = "get_isSuccessfulMatch", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MatchResult), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MatchResult), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(InputControlList`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme+MatchResult>), Member = "get_Value", ReturnType = typeof(MatchResult))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme+MatchResult>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public static bool FindControlSchemeForDevices(TDevices devices, TSchemes schemes, out InputControlScheme controlScheme, out MatchResult matchResult, InputDevice mustIncludeDevice = null, bool allowUnsuccessfulMatch = false) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_bindingGroup() { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	public ReadOnlyArray<DeviceRequirement> get_deviceRequirements() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[CalledBy(Type = typeof(InputUser), Member = "ActivateControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputControlScheme)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlScheme), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	public static bool op_Equality(InputControlScheme left, InputControlScheme right) { }

	[CalledBy(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControlScheme), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(InputControlScheme left, InputControlScheme right) { }

	[CalledBy(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputControlScheme&), typeof(MatchResult&), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceRequirement), Member = "get_isOptional", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputControlList`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "TryGetDeviceLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collection), Member = "ComputeDistanceInInheritanceHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	[DeduplicatedMethod]
	public MatchResult PickDevicesFrom(TDevices devices, InputDevice favorDevice = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_bindingGroup(string value) { }

	[CalledBy(Type = typeof(InputControlScheme), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputControlScheme+DeviceRequirement>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	internal void SetNameAndBindingGroup(string name, string bindingGroup = null) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "IsUsableWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "TryToActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public bool SupportsDevice(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

