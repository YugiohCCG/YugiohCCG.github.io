namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
public sealed class InputActionMap : ICloneable, ISerializationCallbackReceiver, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	public struct BindingJson
	{
		public string name; //Field offset: 0x0
		public string id; //Field offset: 0x8
		public string path; //Field offset: 0x10
		public string interactions; //Field offset: 0x18
		public string processors; //Field offset: 0x20
		public string groups; //Field offset: 0x28
		public string action; //Field offset: 0x30
		public bool isComposite; //Field offset: 0x38
		public bool isPartOfComposite; //Field offset: 0x39

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputBinding), Member = "get_isComposite", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputBinding), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 7)]
		public static BindingJson FromBinding(ref InputBinding binding) { }

		[CalledBy(Type = typeof(ReadFileJson), Member = "ToMaps", ReturnType = typeof(InputActionMap[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputBinding), Member = "set_isComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputBinding), Member = "set_isPartOfComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		public InputBinding ToBinding() { }

	}

	public struct BindingOverrideJson
	{
		public string action; //Field offset: 0x0
		public string id; //Field offset: 0x8
		public string path; //Field offset: 0x10
		public string interactions; //Field offset: 0x18
		public string processors; //Field offset: 0x20

		[CalledBy(Type = typeof(BindingOverrideJson), Member = "FromBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(BindingOverrideJson))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "AddBindingOverrideJsonTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(InputBinding), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.InputActionMap+BindingOverrideJson>), typeof(InputAction)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputBinding), Member = "get_id", ReturnType = typeof(Guid))]
		[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 5)]
		public static BindingOverrideJson FromBinding(InputBinding binding, string actionName) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BindingOverrideJson), Member = "FromBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(string)}, ReturnType = typeof(BindingOverrideJson))]
		public static BindingOverrideJson FromBinding(InputBinding binding) { }

		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJsonInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 3)]
		public static InputBinding ToBinding(BindingOverrideJson bindingOverride) { }

	}

	public struct BindingOverrideListJson
	{
		public List<BindingOverrideJson> bindings; //Field offset: 0x0

	}

	public struct DeviceArray
	{
		private bool m_HaveValue; //Field offset: 0x0
		private int m_DeviceCount; //Field offset: 0x4
		private InputDevice[] m_DeviceArray; //Field offset: 0x8

		[CalledBy(Type = typeof(InputAction), Member = "ActiveControlIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputActionAsset), Member = "get_devices", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
		[CalledBy(Type = typeof(InputActionMap), Member = "get_devices", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public Nullable<ReadOnlyArray`1<InputDevice>> Get() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
		public int IndexOf(InputDevice device) { }

		[CalledBy(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
		public bool Remove(InputDevice device) { }

		[CalledBy(Type = typeof(InputActionAsset), Member = "set_devices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionMap), Member = "set_devices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "HaveEqualReferences", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "System.Collections.Generic.IReadOnlyList`1<TValue>", typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArrayHelpers), Member = "Clear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendListWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<System.Object>), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		public bool Set(Nullable<ReadOnlyArray`1<InputDevice>> devices) { }

	}

	[Flags]
	private enum Flags
	{
		NeedToResolveBindings = 1,
		BindingResolutionNeedsFullReResolve = 2,
		ControlsForEachActionInitialized = 4,
		BindingsForEachActionInitialized = 8,
	}

	public struct ReadActionJson
	{
		public string name; //Field offset: 0x0
		public string type; //Field offset: 0x8
		public string id; //Field offset: 0x10
		public string expectedControlType; //Field offset: 0x18
		public string expectedControlLayout; //Field offset: 0x20
		public string processors; //Field offset: 0x28
		public string interactions; //Field offset: 0x30
		public bool passThrough; //Field offset: 0x38
		public bool initialStateCheck; //Field offset: 0x39
		public BindingJson[] bindings; //Field offset: 0x40

		[CalledBy(Type = typeof(ReadFileJson), Member = "ToMaps", ReturnType = typeof(InputActionMap[]))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(InputAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		public InputAction ToAction(string actionName = null) { }

	}

	public struct ReadFileJson
	{
		public ReadActionJson[] actions; //Field offset: 0x0
		public ReadMapJson[] maps; //Field offset: 0x8

		[CalledBy(Type = typeof(ReadFileJson), Member = "ToAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionMap), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputActionMap[]))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(BindingJson), Member = "ToBinding", ReturnType = typeof(InputBinding))]
		[Calls(Type = typeof(InputActionMap), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReadActionJson), Member = "ToAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputAction))]
		[CallsDeduplicatedMethods(Count = 19)]
		[CallsUnknownMethods(Count = 41)]
		public InputActionMap[] ToMaps() { }

	}

	public struct ReadMapJson
	{
		public string name; //Field offset: 0x0
		public string id; //Field offset: 0x8
		public ReadActionJson[] actions; //Field offset: 0x10
		public BindingJson[] bindings; //Field offset: 0x18

	}

	public struct WriteActionJson
	{
		public string name; //Field offset: 0x0
		public string type; //Field offset: 0x8
		public string id; //Field offset: 0x10
		public string expectedControlType; //Field offset: 0x18
		public string processors; //Field offset: 0x20
		public string interactions; //Field offset: 0x28
		public bool initialStateCheck; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		public static WriteActionJson FromAction(InputAction action) { }

	}

	public struct WriteFileJson
	{
		public WriteMapJson[] maps; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WriteMapJson), Member = "FromMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(WriteMapJson))]
		[CallsUnknownMethods(Count = 4)]
		public static WriteFileJson FromMap(InputActionMap map) { }

		[CalledBy(Type = typeof(InputActionAsset), Member = "ToJson", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputActionMap), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputActionMap>)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(WriteMapJson), Member = "FromMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(WriteMapJson))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 13)]
		public static WriteFileJson FromMaps(IEnumerable<InputActionMap> maps) { }

	}

	public struct WriteMapJson
	{
		public string name; //Field offset: 0x0
		public string id; //Field offset: 0x8
		public WriteActionJson[] actions; //Field offset: 0x10
		public BindingJson[] bindings; //Field offset: 0x18

		[CalledBy(Type = typeof(WriteFileJson), Member = "FromMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(WriteFileJson))]
		[CalledBy(Type = typeof(WriteFileJson), Member = "FromMaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputActionMap>)}, ReturnType = typeof(WriteFileJson))]
		[CalledBy(Type = typeof(InputActionMap), Member = "ToJson", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(InputBinding), Member = "get_isComposite", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputBinding), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
		[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 24)]
		[ContainsUnimplementedInstructions]
		public static WriteMapJson FromMap(InputActionMap map) { }

	}

	private static readonly ProfilerMarker k_ResolveBindingsProfilerMarker; //Field offset: 0x0
	internal static int s_DeferBindingResolution; //Field offset: 0x8
	internal static bool s_NeedToResolveBindings; //Field offset: 0xC
	[SerializeField]
	internal string m_Name; //Field offset: 0x10
	[SerializeField]
	internal string m_Id; //Field offset: 0x18
	[SerializeField]
	internal InputActionAsset m_Asset; //Field offset: 0x20
	[SerializeField]
	internal InputAction[] m_Actions; //Field offset: 0x28
	[SerializeField]
	internal InputBinding[] m_Bindings; //Field offset: 0x30
	private InputBinding[] m_BindingsForEachAction; //Field offset: 0x38
	private InputControl[] m_ControlsForEachAction; //Field offset: 0x40
	internal int m_EnabledActionsCount; //Field offset: 0x48
	internal InputAction m_SingletonAction; //Field offset: 0x50
	internal int m_MapIndexInState; //Field offset: 0x58
	internal InputActionState m_State; //Field offset: 0x60
	internal Nullable<InputBinding> m_BindingMask; //Field offset: 0x68
	private Flags m_Flags; //Field offset: 0xC8
	internal int m_ParameterOverridesCount; //Field offset: 0xCC
	internal ParameterOverride[] m_ParameterOverrides; //Field offset: 0xD0
	internal DeviceArray m_Devices; //Field offset: 0xD8
	internal CallbackArray<Action`1<CallbackContext>> m_ActionCallbacks; //Field offset: 0xE8
	internal Dictionary<String, Int32> m_ActionIndexByNameOrId; //Field offset: 0x138

	public event Action<CallbackContext> actionTriggered
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "InstallOnActionTriggeredHook", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(PlayerInput), Member = "UninstallOnActionTriggeredHook", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeToAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public ReadOnlyArray<InputAction> actions
	{
		[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		 get { } //Length: 83
	}

	public InputActionAsset asset
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override Nullable<InputBinding> bindingMask
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 63
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputBinding), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputBinding)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 540
	}

	private bool bindingResolutionNeedsFullReResolve
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 11
		[CallerCount(Count = 0)]
		private set { } //Length: 31
	}

	public ReadOnlyArray<InputBinding> bindings
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "CopyActionAssetAndApplyBindingOverrides", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		 get { } //Length: 83
	}

	private bool bindingsForEachActionInitialized
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 11
		[CallerCount(Count = 0)]
		private set { } //Length: 31
	}

	public override ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 193
	}

	private bool controlsForEachActionInitialized
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 11
		[CallerCount(Count = 0)]
		private set { } //Length: 31
	}

	public override Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		[CalledBy(Type = typeof(InputActionState), Member = "IsUsingDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputActionState), Member = "CanUseDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DeviceArray), Member = "Get", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
		 get { } //Length: 190
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DeviceArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		 set { } //Length: 76
	}

	public bool enabled
	{
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Guid id
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
		[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 122
	}

	internal Guid idDontGenerate
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		internal get { } //Length: 78
	}

	public InputAction Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionMap), Member = "FindActionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 11)]
		 get { } //Length: 263
	}

	public string name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private bool needToResolveBindings
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 10
		[CallerCount(Count = 0)]
		private set { } //Length: 31
	}

	private override IEnumerable<InputBinding> UnityEngine.InputSystem.IInputActionCollection2.bindings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		private get { } //Length: 128
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static InputActionMap() { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(InputActionMap))]
	[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "RegisterInputs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionMap), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public InputActionMap(string name) { }

	[CalledBy(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[CalledBy(Type = typeof(InputAction), Member = "CreateInternalActionMapForSingletonAction", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadFileJson), Member = "ToMaps", ReturnType = typeof(InputActionMap[]))]
	[CalledBy(Type = typeof(InputActionMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "Clone", ReturnType = typeof(InputActionMap))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	public InputActionMap() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "InstallOnActionTriggeredHook", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_actionTriggered(Action<CallbackContext> value) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "Rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	internal void ClearActionLookupTable() { }

	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void ClearCachedActionData(bool onlyControls = false) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "System.ICloneable.Clone", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionMap), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public InputActionMap Clone() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Contains(InputAction action) { }

	[CalledBy(Type = typeof(InputActionState), Member = "DisableAllActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerActions), Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIActions), Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "set_currentActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "DeactivateInput", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "PassivateInput", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchCurrentActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InputActionState), Member = "DisableAllActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Disable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(PlayerActions), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIActions), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "set_currentActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "ActivateInput", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchCurrentActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterActions", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "EnableAllActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Enable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public InputAction FindAction(Guid id) { }

	[CalledBy(Type = typeof(InputActionReference), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "Rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UpdateReferenceForNewAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(InputActionReference))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "RegisterActions", ReturnType = typeof(void))]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(InputActionMap), Member = "FindActionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public override InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionMap), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionMap), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "FindBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputAction&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal int FindActionIndex(string nameOrId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int FindActionIndex(Guid id) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "FindBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputAction&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(MatchOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionMap), Member = "FindActionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "BindingIndexOnMapToBindingIndexOnAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public override int FindBinding(InputBinding mask, out InputAction action) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(MatchOptions)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal int FindBindingRelativeToMap(InputBinding mask) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(ReadFileJson), Member = "ToMaps", ReturnType = typeof(InputActionMap[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static InputActionMap[] FromJson(string json) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(InputActionMap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void GenerateId() { }

	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	public ReadOnlyArray<InputAction> get_actions() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public InputActionAsset get_asset() { }

	[CallerCount(Count = 0)]
	public override Nullable<InputBinding> get_bindingMask() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_bindingResolutionNeedsFullReResolve() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "CopyActionAssetAndApplyBindingOverrides", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	public ReadOnlyArray<InputBinding> get_bindings() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_bindingsForEachActionInitialized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_controlsForEachActionInitialized() { }

	[CalledBy(Type = typeof(InputActionState), Member = "IsUsingDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionState), Member = "CanUseDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DeviceArray), Member = "Get", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
	public override Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_enabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public Guid get_id() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal Guid get_idDontGenerate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "FindActionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public InputAction get_Item(string actionNameOrId) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 0)]
	private bool get_needToResolveBindings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ReadOnlyArray<InputBinding> GetBindingsForSingleAction(InputAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ReadOnlyArray<InputControl> GetControlsForSingleAction(InputAction action) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[DeduplicatedMethod]
	public override IEnumerator<InputAction> GetEnumerator() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "HaveBindingForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputBinding), Member = "get_effectivePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public bool IsUsableWithDevice(InputDevice device) { }

	[CalledBy(Type = typeof(InputAction), Member = "set_bindingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionAsset), Member = "set_bindingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionAsset), Member = "set_devices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionAsset), Member = "ReResolveIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "set_bindingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "set_devices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "RemoveAllBindingOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal bool LazyResolveBindings(bool fullResolve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public override void OnAfterDeserialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnBeforeSerialize() { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(int), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "RemoveAllBindingOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "WithName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "WithPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "WithGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "WithInteractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "WithProcessors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "Triggering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "Erase", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBindingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	internal void OnBindingModified() { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "OnSetupChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	internal void OnSetupChanged() { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "OnWantToChangeSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	internal void OnWantToChangeSetup() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "UninstallOnActionTriggeredHook", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeToAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_actionTriggered(Action<CallbackContext> value) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(PrimitiveValue), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputAction), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[CalledBy(Type = typeof(InputAction), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionAsset), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionAsset), Member = "ResolveBindingsIfNecessary", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "OnSetupChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindingsIfNecessary", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(ParameterOverride)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string), typeof(PrimitiveValue), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(PrimitiveValue), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndexForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(int))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(InputActionState), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ClaimDataFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnmanagedMemory), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputBindingResolver), Member = "StartWithPreviousResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnmanagedMemory), Member = "Clone", ReturnType = typeof(UnmanagedMemory))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OneOrMore`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<TValue>")]
	[Calls(Type = typeof(OneOrMore`2), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList"}, ReturnType = "UnityEngine.InputSystem.Utilities.OneOrMore`2<TValue, TList>")]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(InputActionState), Member = "FinishBindingResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OneOrMore`2), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.OneOrMore`2<TValue, TList>")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 42)]
	[ContainsUnimplementedInstructions]
	internal void ResolveBindings() { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", "TValue", typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", "TValue", typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DeferredResolutionOfBindings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "HasResolvedControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	internal bool ResolveBindingsIfNecessary() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBinding), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputBinding)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void set_bindingMask(Nullable<InputBinding> value) { }

	[CallerCount(Count = 0)]
	private void set_bindingResolutionNeedsFullReResolve(bool value) { }

	[CallerCount(Count = 0)]
	private void set_bindingsForEachActionInitialized(bool value) { }

	[CallerCount(Count = 0)]
	private void set_controlsForEachActionInitialized(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeviceArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	public override void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

	[CallerCount(Count = 0)]
	private void set_needToResolveBindings(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void SetUpActionLookupTable() { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "PerformInteractiveRebinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "SaveBindingOverridesAsJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverridesOnMatchingControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "Start", ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionMap), Member = "GetControlsForSingleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(InputAction), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[CalledBy(Type = typeof(InputAction), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputAction), Member = "get_bindings", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputBinding>))]
	[CalledBy(Type = typeof(InputAction), Member = "Clone", ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputAction), Member = "System.ICloneable.Clone", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(InputActionMap), Member = "GetBindingsForSingleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputBinding>))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(InputActionState), Member = "FetchMapIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(ActionMapIndices))]
	[Calls(Type = typeof(InputActionMap), Member = "FindActionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputBinding), Member = "get_isComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", typeof(int), typeof(int), "TSecond"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "HaveDuplicateReferences", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 35)]
	[ContainsUnimplementedInstructions]
	private void SetUpPerActionControlAndBindingArrays() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "Clone", ReturnType = typeof(InputActionMap))]
	private override object System.ICloneable.Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WriteFileJson), Member = "FromMaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputActionMap>)}, ReturnType = typeof(WriteFileJson))]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static string ToJson(IEnumerable<InputActionMap> maps) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WriteMapJson), Member = "FromMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(WriteMapJson))]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public string ToJson() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	private override IEnumerable<InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings() { }

}

