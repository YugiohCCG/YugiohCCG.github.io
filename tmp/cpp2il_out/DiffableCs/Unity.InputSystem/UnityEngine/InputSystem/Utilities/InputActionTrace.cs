namespace UnityEngine.InputSystem.Utilities;

public sealed class InputActionTrace : IEnumerable<ActionEventPtr>, IEnumerable, IDisposable
{
	internal struct ActionEventPtr
	{
		internal InputActionState m_State; //Field offset: 0x0
		internal ActionEvent* m_Ptr; //Field offset: 0x8

		public InputAction action
		{
			[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(InputActionState), Member = "GetActionOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputAction))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 40
		}

		public InputControl control
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 55
		}

		public double duration
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputEvent), Member = "get_time", ReturnType = typeof(double))]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 45
		}

		public IInputInteraction interaction
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ActionEvent), Member = "get_interactionIndex", ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 79
		}

		public InputActionPhase phase
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
		}

		public double startTime
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 10
		}

		public double time
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputEvent), Member = "get_time", ReturnType = typeof(double))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 29
		}

		public int valueSizeInBytes
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ActionEvent), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
			 get { } //Length: 11
		}

		[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputActionState), Member = "GetActionOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputAction))]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_action() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public InputControl get_control() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEvent), Member = "get_time", ReturnType = typeof(double))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public double get_duration() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActionEvent), Member = "get_interactionIndex", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		public IInputInteraction get_interaction() { }

		[CallerCount(Count = 0)]
		public InputActionPhase get_phase() { }

		[CallerCount(Count = 0)]
		public double get_startTime() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEvent), Member = "get_time", ReturnType = typeof(double))]
		[CallsUnknownMethods(Count = 1)]
		public double get_time() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActionEvent), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
		public int get_valueSizeInBytes() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActionEvent), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
		[Calls(Type = typeof(ActionEvent), Member = "get_valueData", ReturnType = typeof(Byte*))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public void ReadValue(Void* buffer, int bufferSize) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActionEvent), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
		[Calls(Type = typeof(ActionEvent), Member = "get_valueData", ReturnType = typeof(Byte*))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ActionEventPtr), Member = "get_action", ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 31)]
		[DeduplicatedMethod]
		public TValue ReadValue() { }

		[CalledBy(Type = typeof(ActionEventPtr), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ActionEvent), Member = "get_valueData", ReturnType = typeof(Byte*))]
		[Calls(Type = typeof(BindingState), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ActionEvent), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
		[Calls(Type = typeof(BindingState), Member = "get_compositeOrCompositeBindingIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 10)]
		public object ReadValueAsObject() { }

		[CalledBy(Type = typeof(InputActionTrace), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputActionState), Member = "GetActionOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InputEvent), Member = "get_time", ReturnType = typeof(double))]
		[Calls(Type = typeof(ActionEventPtr), Member = "ReadValueAsObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(ActionEvent), Member = "get_interactionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 31)]
		[ContainsUnimplementedInstructions]
		public virtual string ToString() { }

	}

	private struct Enumerator : IEnumerator<ActionEventPtr>, IEnumerator, IDisposable
	{
		private readonly InputActionTrace m_Trace; //Field offset: 0x0
		private readonly ActionEvent* m_Buffer; //Field offset: 0x8
		private readonly int m_EventCount; //Field offset: 0x10
		private ActionEvent* m_CurrentEvent; //Field offset: 0x18
		private int m_CurrentIndex; //Field offset: 0x20

		public override ActionEventPtr Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 131
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
			[CallsUnknownMethods(Count = 2)]
			private get { } //Length: 180
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEventBuffer), Member = "get_bufferPtr", ReturnType = typeof(InputEventPtr))]
		[CallsUnknownMethods(Count = 2)]
		public Enumerator(InputActionTrace trace) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 2)]
		public override ActionEventPtr get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEvent), Member = "GetNextInMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*)}, ReturnType = typeof(InputEvent*))]
		[ContainsUnimplementedInstructions]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 2)]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private bool m_SubscribedToAll; //Field offset: 0x10
	private bool m_OnActionChangeHooked; //Field offset: 0x11
	private InlinedArray<InputAction> m_SubscribedActions; //Field offset: 0x18
	private InlinedArray<InputActionMap> m_SubscribedActionMaps; //Field offset: 0x30
	private InputEventBuffer m_EventBuffer; //Field offset: 0x48
	private InlinedArray<InputActionState> m_ActionMapStates; //Field offset: 0x68
	private InlinedArray<InputActionState> m_ActionMapStateClones; //Field offset: 0x80
	private Action<CallbackContext> m_CallbackDelegate; //Field offset: 0x98
	private Action<Object, InputActionChange> m_ActionChangeDelegate; //Field offset: 0xA0

	public InputEventBuffer buffer
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
	}

	public int count
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public InputActionTrace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public InputActionTrace(InputAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "add_actionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public InputActionTrace(InputActionMap actionMap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventBuffer), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "ClearWithCapacity", ReturnType = typeof(void))]
	public void Clear() { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "OnActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InputActionChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionTrace), Member = "DisposeInternal", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionState), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventBuffer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Object, UnityEngine.InputSystem.InputActionChange>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void DisposeInternal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionTrace), Member = "DisposeInternal", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	public InputEventBuffer get_buffer() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_count() { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputEventBuffer), Member = "get_bufferPtr", ReturnType = typeof(InputEventPtr))]
	[CallsUnknownMethods(Count = 2)]
	public override IEnumerator<ActionEventPtr> GetEnumerator() { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeToAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Object, UnityEngine.InputSystem.InputActionChange>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void HookOnActionChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_actionMaps", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputActionMap>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionTrace), Member = "CloneActionStateBeforeBindingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnActionChange(object actionOrMapOrAsset, InputActionChange change) { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "OnActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InputActionChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActionEvent), Member = "get_valueData", ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(ActionEvent), Member = "set_interactionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "get_interactionIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(ActionEvent), Member = "set_bindingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActionEvent), Member = "set_controlIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(ActionEvent), Member = "set_stateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEvent), Member = "set_time", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActionEvent), Member = "get_Type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputEventBuffer), Member = "AllocateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Allocator)}, ReturnType = typeof(InputEvent*))]
	[Calls(Type = typeof(ActionEvent), Member = "GetEventSizeWithValueSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackContext), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionTrace), Member = "HookOnActionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void RecordAction(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void SubscribeTo(InputAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "add_actionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void SubscribeTo(InputActionMap actionMap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionTrace), Member = "HookOnActionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "remove_actionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void SubscribeToAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionTrace), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<UnityEngine.InputSystem.Utilities.InputActionTrace+ActionEventPtr>))]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(InputActionTrace), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<UnityEngine.InputSystem.Utilities.InputActionTrace+ActionEventPtr>))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ActionEventPtr), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "remove_onActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Object, UnityEngine.InputSystem.InputActionChange>)}, ReturnType = typeof(void))]
	private void UnhookOnActionChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void UnsubscribeFrom(InputAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "remove_actionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void UnsubscribeFrom(InputActionMap actionMap) { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystem), Member = "remove_onActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Object, UnityEngine.InputSystem.InputActionChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "remove_actionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void UnsubscribeFromAll() { }

}

