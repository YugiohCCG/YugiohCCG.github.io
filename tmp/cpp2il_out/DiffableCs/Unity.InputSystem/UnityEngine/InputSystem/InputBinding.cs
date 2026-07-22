namespace UnityEngine.InputSystem;

public struct InputBinding : IEquatable<InputBinding>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__45_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <MaskByGroups>b__45_0(string x) { }

	}

	[Flags]
	internal enum DisplayStringOptions
	{
		DontUseShortDisplayNames = 1,
		DontOmitDevice = 2,
		DontIncludeInteractions = 4,
		IgnoreBindingOverrides = 8,
	}

	[Flags]
	public enum Flags
	{
		None = 0,
		Composite = 4,
		PartOfComposite = 8,
	}

	[Flags]
	public enum MatchOptions
	{
		EmptyGroupMatchesAny = 1,
	}

	public const char Separator = '\u3B'; //Field offset: 0x0
	internal const string kSeparatorString = ";"; //Field offset: 0x0
	[SerializeField]
	private string m_Name; //Field offset: 0x0
	[SerializeField]
	internal string m_Id; //Field offset: 0x8
	[SerializeField]
	[Tooltip("Path of the control to bind to. Matched at runtime to controls from InputDevices present at the time.\n\nCan either be graphically from the control picker dropdown UI or edited manually in text mode by clicking the 'T' button. Internally, both methods result in control path strings that look like, for example, \"<Gamepad>/buttonSouth\".")]
	private string m_Path; //Field offset: 0x10
	[SerializeField]
	private string m_Interactions; //Field offset: 0x18
	[SerializeField]
	private string m_Processors; //Field offset: 0x20
	[SerializeField]
	internal string m_Groups; //Field offset: 0x28
	[SerializeField]
	private string m_Action; //Field offset: 0x30
	[SerializeField]
	internal Flags m_Flags; //Field offset: 0x38
	private string m_OverridePath; //Field offset: 0x40
	private string m_OverrideInteractions; //Field offset: 0x48
	private string m_OverrideProcessors; //Field offset: 0x50

	public string action
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string effectiveInteractions
	{
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 25
	}

	public string effectivePath
	{
		[CalledBy(Type = typeof(InputActionAsset), Member = "IsUsableWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputActionMap), Member = "IsUsableWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ParameterOverride), Member = "PickMoreSpecificOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>), typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "InstantiateBindingComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(InputActionMap)}, ReturnType = typeof(InputBindingComposite))]
		[CallerCount(Count = 10)]
		 get { } //Length: 25
	}

	public string effectiveProcessors
	{
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 25
	}

	public string groups
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool hasOverrides
	{
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "AddBindingOverrideJsonTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(InputBinding), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.InputActionMap+BindingOverrideJson>), typeof(InputAction)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 26
	}

	public Guid id
	{
		[CalledBy(Type = typeof(BindingOverrideJson), Member = "FromBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(string)}, ReturnType = typeof(BindingOverrideJson))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(int)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(PrimitiveValue), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 get { } //Length: 78
		[CalledBy(Type = typeof(InputAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(int)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(PrimitiveValue), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 44
	}

	public string interactions
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool isComposite
	{
		[CalledBy(Type = typeof(BindingJson), Member = "FromBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&)}, ReturnType = typeof(BindingJson))]
		[CalledBy(Type = typeof(WriteMapJson), Member = "FromMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(WriteMapJson))]
		[CalledBy(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveToNextBinding", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "PerformInteractiveRebinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		 get { } //Length: 9
		[CalledBy(Type = typeof(BindingJson), Member = "ToBinding", ReturnType = typeof(InputBinding))]
		[CallerCount(Count = 1)]
		 set { } //Length: 25
	}

	internal bool isEmpty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		internal get { } //Length: 81
	}

	public bool isPartOfComposite
	{
		[CalledBy(Type = typeof(BindingJson), Member = "FromBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&)}, ReturnType = typeof(BindingJson))]
		[CalledBy(Type = typeof(WriteMapJson), Member = "FromMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(WriteMapJson))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		 get { } //Length: 9
		[CalledBy(Type = typeof(BindingJson), Member = "ToBinding", ReturnType = typeof(InputBinding))]
		[CallerCount(Count = 1)]
		 set { } //Length: 25
	}

	public string name
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public string overrideInteractions
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string overridePath
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string overrideProcessors
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string path
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string processors
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public InputBinding(string path, string action = null, string groups = null, string processors = null, string interactions = null, string name = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBinding), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputActionSetupExtensions+<>c__DisplayClass5_0", Member = "<RemoveAction>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputBinding), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputBinding), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputBinding)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputBinding), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputBinding)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	public override bool Equals(InputBinding other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void GenerateId() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_action() { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public string get_effectiveInteractions() { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "IsUsableWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionMap), Member = "IsUsableWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ParameterOverride), Member = "PickMoreSpecificOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>), typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "InstantiateBindingComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(InputActionMap)}, ReturnType = typeof(InputBindingComposite))]
	[CallerCount(Count = 10)]
	public string get_effectivePath() { }

	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public string get_effectiveProcessors() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_groups() { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "AddBindingOverrideJsonTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(InputBinding), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.InputActionMap+BindingOverrideJson>), typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_hasOverrides() { }

	[CalledBy(Type = typeof(BindingOverrideJson), Member = "FromBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(string)}, ReturnType = typeof(BindingOverrideJson))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(int)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(PrimitiveValue), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public Guid get_id() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_interactions() { }

	[CalledBy(Type = typeof(BindingJson), Member = "FromBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&)}, ReturnType = typeof(BindingJson))]
	[CalledBy(Type = typeof(WriteMapJson), Member = "FromMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(WriteMapJson))]
	[CalledBy(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveToNextBinding", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "PerformInteractiveRebinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	public bool get_isComposite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	internal bool get_isEmpty() { }

	[CalledBy(Type = typeof(BindingJson), Member = "FromBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&)}, ReturnType = typeof(BindingJson))]
	[CalledBy(Type = typeof(WriteMapJson), Member = "FromMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(WriteMapJson))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	public bool get_isPartOfComposite() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_overrideInteractions() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_overridePath() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_overrideProcessors() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_path() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_processors() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NameAndParameters), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameAndParameters))]
	public string GetNameOfComposite() { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(DisplayStringOptions), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static InputBinding MaskByGroup(string group) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static InputBinding MaskByGroups(String[] groups) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "FindBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputAction&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputActionMap), Member = "FindBindingRelativeToMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveToNextBinding", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringHelpers), Member = "CharacterSeparatedListsHaveAtLeastOneCommonElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Guid)}, ReturnType = typeof(bool))]
	internal bool Matches(ref InputBinding binding, MatchOptions options = 0) { }

	[CalledBy(Type = typeof(ParameterOverride), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride[]), typeof(int), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(MatchOptions)}, ReturnType = typeof(bool))]
	public bool Matches(InputBinding binding) { }

	[CalledBy(Type = typeof(InputAction), Member = "set_bindingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionAsset), Member = "set_bindingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "set_bindingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputBinding), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
	public static bool op_Equality(InputBinding left, InputBinding right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBinding), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(InputBinding left, InputBinding right) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "RemoveAllBindingOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void RemoveOverrides() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_action(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_groups(string value) { }

	[CalledBy(Type = typeof(InputAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(int)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(PrimitiveValue), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public void set_id(Guid value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_interactions(string value) { }

	[CalledBy(Type = typeof(BindingJson), Member = "ToBinding", ReturnType = typeof(InputBinding))]
	[CallerCount(Count = 1)]
	public void set_isComposite(bool value) { }

	[CalledBy(Type = typeof(BindingJson), Member = "ToBinding", ReturnType = typeof(InputBinding))]
	[CallerCount(Count = 1)]
	public void set_isPartOfComposite(bool value) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_overrideInteractions(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_overridePath(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_overrideProcessors(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_path(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_processors(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBinding), Member = "ToDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(String&), typeof(DisplayStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	public string ToDisplayString(DisplayStringOptions options = 0, InputControl control = null) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputBinding), Member = "ToDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DisplayStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NameAndParameters), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.NameAndParameters>))]
	[Calls(Type = typeof(InputInteraction), Member = "GetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public string ToDisplayString(out string deviceLayoutName, out string controlPath, DisplayStringOptions options = 0, InputControl control = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(InputAction), Member = "BindingIndexOnActionToBindingIndexOnMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "RemoveAllBindingOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "SaveBindingOverridesAsJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool TriggersAction(InputAction action) { }

}

