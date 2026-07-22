namespace UnityEngine.InputSystem;

internal struct InputBindingResolver : IDisposable
{
	public int totalProcessorCount; //Field offset: 0x0
	public int totalCompositeCount; //Field offset: 0x4
	public int totalInteractionCount; //Field offset: 0x8
	public InputActionMap[] maps; //Field offset: 0x10
	public InputControl[] controls; //Field offset: 0x18
	public UnmanagedMemory memory; //Field offset: 0x20
	public IInputInteraction[] interactions; //Field offset: 0xA0
	public InputProcessor[] processors; //Field offset: 0xA8
	public InputBindingComposite[] composites; //Field offset: 0xB0
	public Nullable<InputBinding> bindingMask; //Field offset: 0xB8
	private bool m_IsControlOnlyResolve; //Field offset: 0x118
	private List<NameAndParameters> m_Parameters; //Field offset: 0x120

	public int totalActionCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int totalBindingCount
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int totalControlCount
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int totalMapCount
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BindingState), Member = "set_partIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "set_mapIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "get_wantsInitialStateCheck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingResolver), Member = "InstantiateBindingComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(InputActionMap)}, ReturnType = typeof(InputBindingComposite))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBindingResolver), Member = "AssignCompositePartIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BindingState), Member = "get_actionIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(BindingState), Member = "set_wantsInitialStateCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionHelpers), Member = "IsExceptionIndicatingBugInCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnmanagedMemory), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InteractionState), Member = "set_triggerControlIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "set_compositeOrCompositeBindingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingState), Member = "get_isComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TriggerState), Member = "set_mapIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_controlIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_interactionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_isPassThrough", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_isButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_mayNeedConflictResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_bindingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendListWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValues"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(Int32&), "TValues", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BindingState), Member = "set_actionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "set_isPartOfComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnmanagedMemory), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnmanagedMemory), Member = "CopyDataFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "get_devices", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
	[Calls(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputBinding), Member = "get_isComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBinding), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "FindActionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBinding), Member = "get_effectivePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>), Member = "get_Value", ReturnType = typeof(InputBinding))]
	[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(MatchOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "FindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.InputSystem.InputControlList`1<TControl>&"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBinding), Member = "get_effectiveProcessors", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputBindingResolver), Member = "InstantiateWithParameters", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeTable), typeof(string), "TType[]&", typeof(Int32&), typeof(InputActionMap), typeof(InputBinding&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBinding), Member = "get_effectiveInteractions", ReturnType = typeof(string))]
	[Calls(Type = typeof(BindingState), Member = "get_interactionStartIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(BindingState), Member = "set_controlStartIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "set_controlCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "set_interactionStartIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "set_interactionCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "set_processorStartIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "set_processorCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "set_isComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 33)]
	[ContainsUnimplementedInstructions]
	public void AddActionMap(InputActionMap actionMap) { }

	[CalledBy(Type = typeof(InputBindingResolver), Member = "InstantiateWithParameters", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeTable), typeof(string), "TType[]&", typeof(Int32&), typeof(InputActionMap), typeof(InputBinding&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "InstantiateBindingComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(InputActionMap)}, ReturnType = typeof(InputBindingComposite))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(PrimitiveValue))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>), Member = "get_Value", ReturnType = typeof(ParameterOverride))]
	[Calls(Type = typeof(ParameterOverride), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 24)]
	private static void ApplyParameters(ReadOnlyArray<NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters) { }

	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnmanagedMemory), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_totalActionCount() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_totalBindingCount() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_totalControlCount() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_totalMapCount() { }

	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputBinding), Member = "get_effectivePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(NameAndParameters), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameAndParameters))]
	[Calls(Type = typeof(TypeTable), Member = "LookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InputBindingResolver), Member = "ApplyParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NamedValue>), typeof(object), typeof(InputActionMap), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	private static InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap) { }

	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NameAndParameters), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(List`1<NameAndParameters>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(TypeTable), Member = "LookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputBindingResolver), Member = "ApplyParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NamedValue>), typeof(object), typeof(InputActionMap), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	private int InstantiateWithParameters(TypeTable registrations, string namesAndParameters, ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public void StartWithPreviousResolve(InputActionState state, bool isFullResolve) { }

}

