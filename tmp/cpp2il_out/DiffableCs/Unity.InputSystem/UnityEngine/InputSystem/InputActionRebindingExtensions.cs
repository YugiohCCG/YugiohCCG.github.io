namespace UnityEngine.InputSystem;

[Extension]
public static class InputActionRebindingExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public ReadOnlyArray<InputBinding> bindings; //Field offset: 0x10
		public int firstPartIndex; //Field offset: 0x20
		public String[] partStrings; //Field offset: 0x28
		public int partCount; //Field offset: 0x30

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass25_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		internal string <GetBindingDisplayString>b__0(string fragment) { }

	}

	public class DeferBindingResolutionWrapper : IDisposable
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DeferBindingResolutionWrapper() { }

		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
		[CallerCount(Count = 1)]
		public void Acquire() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionState), Member = "DeferredResolutionOfBindings", ReturnType = typeof(void))]
		public override void Dispose() { }

	}

	public struct Parameter
	{
		public object instance; //Field offset: 0x0
		public FieldInfo field; //Field offset: 0x8
		public int bindingIndex; //Field offset: 0x10

	}

	private struct ParameterEnumerable : IEnumerable<Parameter>, IEnumerable
	{
		private InputActionState m_State; //Field offset: 0x0
		private ParameterOverride m_Parameter; //Field offset: 0x8
		private int m_MapIndex; //Field offset: 0x80

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public ParameterEnumerable(InputActionState state, ParameterOverride parameter, int mapIndex = -1) { }

		[CalledBy(Type = typeof(ParameterEnumerable), Member = "System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<UnityEngine.InputSystem.InputActionRebindingExtensions+Parameter>))]
		[CalledBy(Type = typeof(ParameterEnumerable), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(ParameterOverride)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(ParameterOverride), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ParameterEnumerator GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ParameterEnumerable), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator")]
		private override IEnumerator<Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ParameterEnumerable), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private struct ParameterEnumerator : IEnumerator<Parameter>, IEnumerator, IDisposable
	{
		private InputActionState m_State; //Field offset: 0x0
		private int m_MapIndex; //Field offset: 0x8
		private int m_BindingCurrentIndex; //Field offset: 0xC
		private int m_BindingEndIndex; //Field offset: 0x10
		private int m_InteractionCurrentIndex; //Field offset: 0x14
		private int m_InteractionEndIndex; //Field offset: 0x18
		private int m_ProcessorCurrentIndex; //Field offset: 0x1C
		private int m_ProcessorEndIndex; //Field offset: 0x20
		private InputBinding m_BindingMask; //Field offset: 0x28
		private Type m_ObjectType; //Field offset: 0x80
		private string m_ParameterName; //Field offset: 0x88
		private bool m_MayBeInteraction; //Field offset: 0x90
		private bool m_MayBeProcessor; //Field offset: 0x91
		private bool m_MayBeComposite; //Field offset: 0x92
		private bool m_CurrentBindingIsComposite; //Field offset: 0x93
		private object m_CurrentObject; //Field offset: 0x98
		private FieldInfo m_CurrentParameter; //Field offset: 0xA0

		public override Parameter Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 83
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			private get { } //Length: 142
		}

		[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerable", Member = "GetEnumerator", ReturnType = typeof(ParameterEnumerator))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ParameterOverride), Member = "get_objectType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ParameterEnumerator), Member = "Reset", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		public ParameterEnumerator(InputActionState state, ParameterOverride parameter, int mapIndex = -1) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CalledBy(Type = typeof(ParameterEnumerator), Member = "MoveToNextInteraction", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ParameterEnumerator), Member = "MoveToNextProcessor", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ParameterEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private bool FindParameter(object instance) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public override Parameter get_Current() { }

		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(ParameterOverride)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ParameterEnumerator), Member = "FindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ParameterEnumerator), Member = "MoveToNextBinding", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputActionState), Member = "GetBindingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BindingState&))]
		[Calls(Type = typeof(BindingState), Member = "get_compositeOrCompositeBindingIndex", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		public override bool MoveNext() { }

		[CalledBy(Type = typeof(ParameterEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputActionState), Member = "GetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputBinding&))]
		[Calls(Type = typeof(InputActionState), Member = "GetBindingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BindingState&))]
		[Calls(Type = typeof(InputBinding), Member = "get_isComposite", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(MatchOptions)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BindingState), Member = "get_processorStartIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(BindingState), Member = "get_interactionStartIndex", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveToNextBinding() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ParameterEnumerator), Member = "FindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveToNextInteraction() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ParameterEnumerator), Member = "FindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveToNextProcessor() { }

		[CalledBy(Type = typeof(ParameterEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(ParameterOverride), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	public struct ParameterOverride
	{
		public string objectRegistrationName; //Field offset: 0x0
		public string parameter; //Field offset: 0x8
		public InputBinding bindingMask; //Field offset: 0x10
		public PrimitiveValue value; //Field offset: 0x68

		public Type objectType
		{
			[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(ParameterOverride), typeof(int)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(TypeTable), Member = "LookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
			 get { } //Length: 157
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 5)]
		public ParameterOverride(string parameterName, InputBinding bindingMask, PrimitiveValue value = null) { }

		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ExtractParameterOverride", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", typeof(InputBinding), typeof(PrimitiveValue)}, ReturnType = typeof(ParameterOverride))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public ParameterOverride(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value = null) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "ApplyParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NamedValue>), typeof(object), typeof(InputActionMap), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ParameterOverride), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride[]), typeof(int), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ParameterOverride), Member = "PickMoreSpecificOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>), typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
		[CallsUnknownMethods(Count = 1)]
		public static Nullable<ParameterOverride> Find(InputActionMap actionMap, ref InputBinding binding, string parameterName, string objectRegistrationName) { }

		[CalledBy(Type = typeof(ParameterOverride), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ParameterOverride), Member = "PickMoreSpecificOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>), typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
		[CallsUnknownMethods(Count = 2)]
		private static Nullable<ParameterOverride> Find(ParameterOverride[] overrides, int overrideCount, ref InputBinding binding, string parameterName, string objectRegistrationName) { }

		[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(ParameterOverride), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TypeTable), Member = "LookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
		public Type get_objectType() { }

		[CalledBy(Type = typeof(ParameterOverride), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
		[CalledBy(Type = typeof(ParameterOverride), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride[]), typeof(int), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>), Member = "get_Value", ReturnType = typeof(ParameterOverride))]
		[Calls(Type = typeof(InputBinding), Member = "get_effectivePath", ReturnType = typeof(string))]
		private static Nullable<ParameterOverride> PickMoreSpecificOne(Nullable<ParameterOverride> first, Nullable<ParameterOverride> second) { }

	}

	internal sealed class RebindingOperation : IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass32_0
		{
			public string group; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass32_0() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			internal bool <WithTargetBinding>b__0(InputControlScheme x) { }

		}

		[Flags]
		private enum Flags
		{
			Started = 1,
			Completed = 2,
			Canceled = 4,
			OnEventHooked = 8,
			OnAfterUpdateHooked = 16,
			DontIgnoreNoisyControls = 64,
			DontGeneralizePathOfSelectedControl = 128,
			AddNewBinding = 256,
			SuppressMatchingEvents = 512,
		}

		public const float kDefaultMagnitudeThreshold = 0.2; //Field offset: 0x0
		private InputAction m_ActionToRebind; //Field offset: 0x10
		private Nullable<InputBinding> m_BindingMask; //Field offset: 0x18
		private Type m_ControlType; //Field offset: 0x78
		private InternedString m_ExpectedLayout; //Field offset: 0x80
		private int m_IncludePathCount; //Field offset: 0x90
		private String[] m_IncludePaths; //Field offset: 0x98
		private int m_ExcludePathCount; //Field offset: 0xA0
		private String[] m_ExcludePaths; //Field offset: 0xA8
		private int m_TargetBindingIndex; //Field offset: 0xB0
		private string m_BindingGroupForNewBinding; //Field offset: 0xB8
		private string m_CancelBinding; //Field offset: 0xC0
		private float m_MagnitudeThreshold; //Field offset: 0xC8
		private Single[] m_Scores; //Field offset: 0xD0
		private Single[] m_Magnitudes; //Field offset: 0xD8
		private double m_LastMatchTime; //Field offset: 0xE0
		private double m_StartTime; //Field offset: 0xE8
		private float m_Timeout; //Field offset: 0xF0
		private float m_WaitSecondsAfterMatch; //Field offset: 0xF4
		private InputEventHandledPolicy m_SavedInputEventHandledPolicy; //Field offset: 0xF8
		private InputEventHandledPolicy m_TargetInputEventHandledPolicy; //Field offset: 0xFC
		private InputControlList<InputControl> m_Candidates; //Field offset: 0x100
		private Action<RebindingOperation> m_OnComplete; //Field offset: 0x120
		private Action<RebindingOperation> m_OnCancel; //Field offset: 0x128
		private Action<RebindingOperation> m_OnPotentialMatch; //Field offset: 0x130
		private Func<InputControl, String> m_OnGeneratePath; //Field offset: 0x138
		private Func<InputControl, InputEventPtr, Single> m_OnComputeScore; //Field offset: 0x140
		private Action<RebindingOperation, String> m_OnApplyBinding; //Field offset: 0x148
		private Action<InputEventPtr, InputDevice> m_OnEventDelegate; //Field offset: 0x150
		private Action m_OnAfterUpdateDelegate; //Field offset: 0x158
		private Cache m_LayoutCache; //Field offset: 0x160
		private StringBuilder m_PathBuilder; //Field offset: 0x168
		private Flags m_Flags; //Field offset: 0x170
		private Dictionary<InputControl, Single> m_StartingActuations; //Field offset: 0x178

		public InputAction action
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public Nullable<InputBinding> bindingMask
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 51
		}

		public bool canceled
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 11
		}

		public InputControlList<InputControl> candidates
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 25
		}

		public bool completed
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 11
		}

		public string expectedControlType
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 33
		}

		public ReadOnlyArray<Single> magnitudes
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 113
		}

		public ReadOnlyArray<Single> scores
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 113
		}

		public InputControl selectedControl
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
			 get { } //Length: 92
		}

		public bool started
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 10
		}

		public double startTime
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
		}

		public float timeout
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public RebindingOperation() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControlList`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]&), typeof(Int32&), typeof(float), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(RebindingOperation), Member = "SortCandidatesByScore", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		public void AddCandidate(InputControl control, float score, float magnitude = -1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public void Cancel() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
		public void Complete() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RebindingOperation), Member = "UnhookOnEvent", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystem), Member = "remove_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputControlList`1), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RebindingOperation), Member = "UnhookOnEvent", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystem), Member = "remove_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputControlList`1), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		protected virtual void Finalize() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Collection), Member = "FindLayoutThatIntroducesControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Cache)}, ReturnType = typeof(InternedString))]
		[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputControlExtensions), Member = "BuildPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(StringBuilder)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private string GeneratePathForControl(InputControl control) { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public InputAction get_action() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Nullable<InputBinding> get_bindingMask() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_canceled() { }

		[CallerCount(Count = 0)]
		public InputControlList<InputControl> get_candidates() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_completed() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public string get_expectedControlType() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ReadOnlyArray<Single> get_magnitudes() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ReadOnlyArray<Single> get_scores() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
		public InputControl get_selectedControl() { }

		[CallerCount(Count = 0)]
		public bool get_started() { }

		[CallerCount(Count = 0)]
		public double get_startTime() { }

		[CallerCount(Count = 0)]
		public float get_timeout() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControlPath), Member = "MatchesPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		private static bool HavePathMatch(InputControl control, String[] paths, int pathCount) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "add_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void HookOnAfterUpdate() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputEventListener), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private void HookOnEvent() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputState), Member = "get_currentTime", ReturnType = typeof(double))]
		[Calls(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
		[Calls(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private void OnAfterUpdate() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public RebindingOperation OnApplyBinding(Action<RebindingOperation, String> callback) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public RebindingOperation OnCancel(Action<RebindingOperation> callback) { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		private void OnCancel() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "Complete", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnAfterUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "get_bindings", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputBinding>))]
		[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>), Member = "get_Value", ReturnType = typeof(InputBinding))]
		[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RebindingOperation), Member = "GeneratePathForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
		[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
		[Calls(Type = typeof(RebindingOperation), Member = "SortCandidatesByScore", ReturnType = typeof(void))]
		[Calls(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 16)]
		private void OnComplete() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public RebindingOperation OnComplete(Action<RebindingOperation> callback) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public RebindingOperation OnComputeScore(Func<InputControl, InputEventPtr, Single> callback) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
		[Calls(Type = typeof(RebindingOperation), Member = "SortCandidatesByScore", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputState), Member = "get_currentTime", ReturnType = typeof(double))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]&), typeof(Int32&), typeof(float), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputControlList`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputControl), Member = "get_synthetic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Collection), Member = "IsBasedOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputControlPath), Member = "MatchesPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RebindingOperation), Member = "OnCancel", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputEventPtr), Member = "set_handled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputControlExtensions), Member = "HasValueChangeInState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputControlPath), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
		[Calls(Type = typeof(InputEventControlEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputEventControlCollection), Member = "GetEnumerator", ReturnType = typeof(InputEventControlEnumerator))]
		[Calls(Type = typeof(InputControlExtensions), Member = "EnumerateControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(Enumerate), typeof(InputDevice), typeof(float)}, ReturnType = typeof(InputEventControlCollection))]
		[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
		[Calls(Type = typeof(InternedString), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 19)]
		private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public RebindingOperation OnGeneratePath(Func<InputControl, String> callback) { }

		[CallerCount(Count = 0)]
		public RebindingOperation OnMatchWaitForAnother(float seconds) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public RebindingOperation OnPotentialMatch(Action<RebindingOperation> callback) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControlList`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputControlList`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void RemoveCandidate(InputControl control) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public RebindingOperation Reset() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "Cancel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "Reset", ReturnType = typeof(RebindingOperation))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnAfterUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnCancel", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(InputControlList`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(RebindingOperation), Member = "UnhookOnEvent", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystem), Member = "remove_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "set_inputEventHandledPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventHandledPolicy)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void ResetAfterMatchCompleted() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "AddCandidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ArrayHelpers), Member = "SwapElements", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputControlList`1), Member = "SwapElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private void SortCandidatesByScore() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputState), Member = "get_currentTime", ReturnType = typeof(double))]
		[Calls(Type = typeof(InputManager), Member = "set_inputEventHandledPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventHandledPolicy)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystem), Member = "add_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputEventListener), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 11)]
		public RebindingOperation Start() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "WithExpectedControlType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(RebindingOperation))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private void ThrowIfRebindInProgress() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "remove_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		private void UnhookOnAfterUpdate() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "Finalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputEventListener), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
		[CallsDeduplicatedMethods(Count = 2)]
		private void UnhookOnEvent() { }

		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "PerformInteractiveRebinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RebindingOperation), Member = "WithExpectedControlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RebindingOperation))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 14)]
		public RebindingOperation WithAction(InputAction action) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public RebindingOperation WithActionEventNotificationsBeingSuppressed(bool value = true) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public RebindingOperation WithBindingGroup(string group) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public RebindingOperation WithBindingMask(Nullable<InputBinding> bindingMask) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
		[Calls(Type = typeof(RebindingOperation), Member = "WithCancelingThrough", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RebindingOperation))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		public RebindingOperation WithCancelingThrough(InputControl control) { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "WithCancelingThrough", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(RebindingOperation))]
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "PerformInteractiveRebinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public RebindingOperation WithCancelingThrough(string binding) { }

		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "PerformInteractiveRebinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		public RebindingOperation WithControlsExcluding(string path) { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		public RebindingOperation WithControlsHavingToMatchPath(string path) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RebindingOperation), Member = "ThrowIfRebindInProgress", ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(RebindingOperation), Member = "WithExpectedControlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(RebindingOperation))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public RebindingOperation WithExpectedControlType() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "WithExpectedControlType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(RebindingOperation))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 14)]
		public RebindingOperation WithExpectedControlType(Type type) { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "WithAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(RebindingOperation))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public RebindingOperation WithExpectedControlType(string layoutName) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		public RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true) { }

		[CallerCount(Count = 0)]
		public RebindingOperation WithoutGeneralizingPathOfSelectedControl() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public RebindingOperation WithoutIgnoringNoisyControls() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public RebindingOperation WithRebindAddingNewBinding(string group = null) { }

		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "PerformInteractiveRebinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
		[Calls(Type = typeof(InputControlScheme), Member = "get_deviceRequirements", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme+DeviceRequirement>))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<TValue>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RebindingOperation), Member = "WithExpectedControlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RebindingOperation))]
		[Calls(Type = typeof(InputBindingComposite), Member = "GetExpectedControlLayoutName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(RebindingOperation), Member = "WithControlsHavingToMatchPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RebindingOperation))]
		[Calls(Type = typeof(InputBinding), Member = "GetNameOfComposite", ReturnType = typeof(string))]
		[Calls(Type = typeof(BindingSyntax), Member = "get_binding", ReturnType = typeof(InputBinding))]
		[Calls(Type = typeof(BindingSyntax), Member = "PreviousCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(InputBinding), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		public RebindingOperation WithTargetBinding(int bindingIndex) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public RebindingOperation WithTimeout(float timeInSeconds) { }

	}

	private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; //Field offset: 0x0

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "SaveBindingOverridesAsJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "SaveBindingOverridesAsJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputBinding), Member = "get_hasOverrides", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BindingOverrideJson), Member = "FromBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(string)}, ReturnType = typeof(BindingOverrideJson))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	private static void AddBindingOverrideJsonTo(IInputActionCollection2 actions, InputBinding binding, List<BindingOverrideJson> list, InputAction action = null) { }

	[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[Extension]
	public static void ApplyBindingOverride(InputAction action, string newPath, string group = null, string path = null) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverridesOnMatchingControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputAction), Member = "BindingIndexOnActionToBindingIndexOnMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(int), typeof(InputBinding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[Extension]
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, string path) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "RemoveBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "RemoveBindingOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(MatchOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[Extension]
	public static int ApplyBindingOverride(InputActionMap actionMap, InputBinding bindingOverride) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "RemoveBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJsonInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "CopyActionAssetAndApplyBindingOverrides", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[Extension]
	public static void ApplyBindingOverride(InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "BindingIndexOnActionToBindingIndexOnMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(int), typeof(InputBinding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, InputBinding bindingOverride) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "RemoveBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
	[Calls(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "SetInitialStateCheckPending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static void ApplyBindingOverride(InputAction action, InputBinding bindingOverride) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[Extension]
	public static void ApplyBindingOverrides(InputActionMap actionMap, IEnumerable<InputBinding> overrides) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverridesOnMatchingControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputControl)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static int ApplyBindingOverridesOnMatchingControls(InputAction action, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverridesOnMatchingControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static int ApplyBindingOverridesOnMatchingControls(InputActionMap actionMap, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindingsIfNecessary", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	public static void ApplyParameterOverride(InputActionMap actionMap, Expression<Func`2<TObject, TValue>> expr, TValue value, InputBinding bindingMask = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static void ApplyParameterOverride(InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask = null) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(PrimitiveValue), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, InputBinding bindingMask = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "BindingIndexOnActionToBindingIndexOnMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputBinding), Member = "get_id", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(InputBinding), Member = "set_id", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(PrimitiveValue), typeof(InputBinding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[Extension]
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, int bindingIndex) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", "TValue", typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", "TValue", typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", "TValue", typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(PrimitiveValue), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string), typeof(PrimitiveValue), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(PrimitiveValue), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ParameterEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(PrimitiveValue))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>), Member = "get_Value", ReturnType = typeof(ParameterOverride))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(ParameterOverride), Member = "PickMoreSpecificOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>), typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParameterOverride), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride[]), typeof(int), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride>))]
	[Calls(Type = typeof(ParameterEnumerable), Member = "GetEnumerator", ReturnType = typeof(ParameterEnumerator))]
	[Calls(Type = typeof(InputActionState), Member = "GetActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBinding), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputBinding)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionState), Member = "GetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputBinding&))]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private static void ApplyParameterOverride(InputActionState state, int mapIndex, ref ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, ParameterOverride parameterOverride) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindingsIfNecessary", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	[Extension]
	public static void ApplyParameterOverride(InputAction action, Expression<Func`2<TObject, TValue>> expr, TValue value, InputBinding bindingMask = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "ResolveBindingsIfNecessary", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	public static void ApplyParameterOverride(InputActionAsset asset, Expression<Func`2<TObject, TValue>> expr, TValue value, InputBinding bindingMask = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static void ApplyParameterOverride(InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask = null) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "RemoveAllBindingOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompositeSyntax), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(CompositeSyntax))]
	[CalledBy(Type = typeof(InputActionState), Member = "ResetActionStatesDrivenBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(DeferBindingResolutionWrapper), Member = "Acquire", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static DeferBindingResolutionWrapper DeferBindingResolution() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeTable), Member = "FindNameForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(ParameterOverride), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputBinding), typeof(PrimitiveValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 27)]
	[DeduplicatedMethod]
	private static ParameterOverride ExtractParameterOverride(Expression<Func`2<TObject, TValue>> expr, InputBinding bindingMask = null, PrimitiveValue value = null) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(DisplayStringOptions), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputBinding), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static string GetBindingDisplayString(InputAction action, InputBinding bindingMask, DisplayStringOptions options = 0) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, DisplayStringOptions options = 0) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringHelpers), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValue[]"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringHelpers), Member = "ExpandTemplateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Func`2<System.String, System.String>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputBindingComposite), Member = "GetDisplayFormatString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputBinding), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NameAndParameters), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameAndParameters))]
	[Calls(Type = typeof(InputBinding), Member = "get_effectivePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputBinding), Member = "ToDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(String&), typeof(DisplayStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputBinding), Member = "get_effectiveInteractions", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionState), Member = "GetBindingIndexInState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "BindingIndexOnActionToBindingIndexOnMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputBinding), Member = "get_isComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	[Extension]
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, DisplayStringOptions options = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>), Member = "get_Value", ReturnType = typeof(InputBinding))]
	[Calls(Type = typeof(InputBinding), Member = "MaskByGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputBinding))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static string GetBindingDisplayString(InputAction action, DisplayStringOptions options = 0, string group = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndexForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[Extension]
	public static Nullable<InputBinding> GetBindingForControl(InputAction action, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBinding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static int GetBindingIndex(InputAction action, string group = null, string path = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static int GetBindingIndex(InputActionMap actionMap, InputBinding bindingMask) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputBinding), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static int GetBindingIndex(InputAction action, InputBinding bindingMask) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingState), Member = "get_actionIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionState), Member = "GetBindingIndexInMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "BindingIndexOnMapToBindingIndexOnAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[Extension]
	public static int GetBindingIndexForControl(InputAction action, InputControl control) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(InputBinding)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", typeof(InputBinding)}, ReturnType = "System.Nullable`1<TValue>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParameterEnumerable), Member = "GetEnumerator", ReturnType = typeof(ParameterEnumerator))]
	[Calls(Type = typeof(ParameterEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PrimitiveValue), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PrimitiveValue))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[Extension]
	private static Nullable<PrimitiveValue> GetParameterValue(InputAction action, ParameterOverride parameterOverride) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "BindingIndexOnActionToBindingIndexOnMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputBinding), Member = "get_id", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(InputBinding), Member = "set_id", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(InputBinding)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[Extension]
	public static Nullable<PrimitiveValue> GetParameterValue(InputAction action, string name, int bindingIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(ParameterOverride)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(PrimitiveValue), Member = "get_valuePtr", ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 27)]
	[DeduplicatedMethod]
	[Extension]
	public static Nullable<TValue> GetParameterValue(InputAction action, Expression<Func`2<TObject, TValue>> expr, InputBinding bindingMask = null) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(int)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(ParameterOverride)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static Nullable<PrimitiveValue> GetParameterValue(InputAction action, string name, InputBinding bindingMask = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "RemoveAllBindingOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJsonInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[Extension]
	public static void LoadBindingOverridesFromJson(IInputActionCollection2 actions, string json, bool removeExisting = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "RemoveAllBindingOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJsonInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[Extension]
	public static void LoadBindingOverridesFromJson(InputAction action, string json, bool removeExisting = true) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BindingOverrideJson), Member = "ToBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingOverrideJson)}, ReturnType = typeof(InputBinding))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingOverrideListJson)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingOverrideListJson))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "BindingIndexOnActionToBindingIndexOnMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(int), typeof(InputBinding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[Extension]
	private static void LoadBindingOverridesFromJsonInternal(IInputActionCollection2 actions, string json) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
	[Calls(Type = typeof(InputBinding), Member = "get_isComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RebindingOperation), Member = "WithControlsExcluding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RebindingOperation))]
	[Calls(Type = typeof(RebindingOperation), Member = "WithAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(RebindingOperation))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RebindingOperation), Member = "WithCancelingThrough", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RebindingOperation))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static RebindingOperation PerformInteractiveRebinding(InputAction action, int bindingIndex = -1) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[Extension]
	public static void RemoveAllBindingOverrides(InputAction action) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBinding), Member = "TriggersAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBinding), Member = "RemoveOverrides", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	[Extension]
	public static void RemoveAllBindingOverrides(IInputActionCollection2 actions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[Extension]
	private static void RemoveBindingOverride(InputActionMap actionMap, InputBinding bindingMask) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[Extension]
	public static void RemoveBindingOverride(InputAction action, InputBinding bindingMask) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "BindingIndexOnActionToBindingIndexOnMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(int), typeof(InputBinding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	public static void RemoveBindingOverride(InputAction action, int bindingIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	[Extension]
	public static void RemoveBindingOverrides(InputActionMap actionMap, IEnumerable<InputBinding> overrides) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "AddBindingOverrideJsonTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(InputBinding), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.InputActionMap+BindingOverrideJson>), typeof(InputAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[Extension]
	public static string SaveBindingOverridesAsJson(IInputActionCollection2 actions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputBinding), Member = "TriggersAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "AddBindingOverrideJsonTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(InputBinding), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.InputActionMap+BindingOverrideJson>), typeof(InputAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static string SaveBindingOverridesAsJson(InputAction action) { }

}

