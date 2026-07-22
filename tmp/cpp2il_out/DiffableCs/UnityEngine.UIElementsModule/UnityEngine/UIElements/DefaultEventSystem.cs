namespace UnityEngine.UIElements;

internal class DefaultEventSystem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal bool <.cctor>b__48_0() { }

	}

	public struct FocusBasedEventSequenceContext : IDisposable
	{
		private DefaultEventSystem es; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public FocusBasedEventSequenceContext(DefaultEventSystem es) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public override void Dispose() { }

	}

	private class InputForUIProcessor
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_0; //Field offset: 0x8
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_1; //Field offset: 0x10
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_2; //Field offset: 0x18
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_3; //Field offset: 0x20
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "scrollDelta"})]
			public static Func<Vector3, Vector3, ValueTuple`2<EventModifiers, Vector2>, EventBase> <>9__9_4; //Field offset: 0x28
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"move", "deviceType", "mod"})]
			public static Func<ValueTuple`3<Vector2, NavigationDeviceType, EventModifiers>, EventBase> <>9__10_2; //Field offset: 0x30
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"direction", "deviceType", "mod"})]
			public static Func<ValueTuple`3<Direction, NavigationDeviceType, EventModifiers>, EventBase> <>9__10_3; //Field offset: 0x38
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"deviceType", "mod"})]
			public static Func<ValueTuple`2<NavigationDeviceType, EventModifiers>, EventBase> <>9__10_0; //Field offset: 0x40
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"deviceType", "mod"})]
			public static Func<ValueTuple`2<NavigationDeviceType, EventModifiers>, EventBase> <>9__10_1; //Field offset: 0x48
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "keyCode"})]
			public static Func<ValueTuple`2<EventModifiers, KeyCode>, EventBase> <>9__11_0; //Field offset: 0x50
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "keyCode"})]
			public static Func<ValueTuple`2<EventModifiers, KeyCode>, EventBase> <>9__11_1; //Field offset: 0x58
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "character"})]
			public static Func<ValueTuple`2<EventModifiers, Char>, EventBase> <>9__12_0; //Field offset: 0x60

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(KeyboardEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(KeyCode), typeof(EventModifiers)}, ReturnType = "T")]
			internal EventBase <ProcessKeyEvent>b__11_0(ValueTuple<EventModifiers, KeyCode> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(KeyboardEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(KeyCode), typeof(EventModifiers)}, ReturnType = "T")]
			internal EventBase <ProcessKeyEvent>b__11_1(ValueTuple<EventModifiers, KeyCode> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
			internal EventBase <ProcessNavigationEvent>b__10_0(ValueTuple<NavigationDeviceType, EventModifiers> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
			internal EventBase <ProcessNavigationEvent>b__10_1(ValueTuple<NavigationDeviceType, EventModifiers> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
			internal EventBase <ProcessNavigationEvent>b__10_2(ValueTuple<Vector2, NavigationDeviceType, EventModifiers> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
			internal EventBase <ProcessNavigationEvent>b__10_3(ValueTuple<Direction, NavigationDeviceType, EventModifiers> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
			internal EventBase <ProcessPointerEvent>b__9_0(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<PointerEvent, Int32, Single> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
			internal EventBase <ProcessPointerEvent>b__9_1(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<PointerEvent, Int32, Single> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
			internal EventBase <ProcessPointerEvent>b__9_2(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<PointerEvent, Int32, Single> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
			internal EventBase <ProcessPointerEvent>b__9_3(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<PointerEvent, Int32, Single> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(WheelEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(EventModifiers)}, ReturnType = typeof(WheelEvent))]
			internal EventBase <ProcessPointerEvent>b__9_4(Vector3 panelPosition, Vector3 _, ValueTuple<EventModifiers, Vector2> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(KeyboardEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(KeyCode), typeof(EventModifiers)}, ReturnType = "T")]
			internal EventBase <ProcessTextInputEvent>b__12_0(ValueTuple<EventModifiers, Char> t) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			public IMECompositionEvent compositionEvent; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass14_0() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(IMEEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IMEEvent))]
			internal EventBase <ProcessIMECompositionEvent>b__0(int _) { }

		}

		private readonly DefaultEventSystem m_EventSystem; //Field offset: 0x10
		private DiscreteTime m_LastPointerTimestamp; //Field offset: 0x18
		private DiscreteTime m_NextPointerTimestamp; //Field offset: 0x20
		private readonly Queue<Event> m_EventList; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public InputForUIProcessor(DefaultEventSystem eventSystem) { }

		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessNavigationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.KeyEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.TextInputEvent"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isShiftPressed", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isCtrlPressed", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isAltPressed", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isMetaPressed", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isCapsLockEnabled", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isNumericPressed", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isFunctionKeyPressed", ReturnType = typeof(bool))]
		private EventModifiers GetModifiers(EventModifiers eventModifiers) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<UnityEngine.InputForUI.Event>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public bool OnEvent(in Event ev) { }

		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private void ProcessCommandEvent(CommandEvent commandEvent) { }

		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Int32, UnityEngine.UIElements.EventBase>), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		private void ProcessIMECompositionEvent(IMECompositionEvent compositionEvent) { }

		[CalledBy(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessNavigationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asNavigationEvent", ReturnType = "UnityEngine.InputForUI.NavigationEvent")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.CommandEvent"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asCommandEvent", ReturnType = "UnityEngine.InputForUI.CommandEvent")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessIMECompositionEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.IMECompositionEvent"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asIMECompositionEvent", ReturnType = "UnityEngine.InputForUI.IMECompositionEvent")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.TextInputEvent"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asTextInputEvent", ReturnType = "UnityEngine.InputForUI.TextInputEvent")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asPointerEvent", ReturnType = "UnityEngine.InputForUI.PointerEvent")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.KeyEvent"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asKeyEvent", ReturnType = "UnityEngine.InputForUI.KeyEvent")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "FocusBasedEventSequence", ReturnType = typeof(FocusBasedEventSequenceContext))]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<UnityEngine.InputForUI.Event>), Member = "Dequeue", ReturnType = "UnityEngine.InputForUI.Event")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void ProcessInputForUIEvents() { }

		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputForUIProcessor), Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventModifiers"}, ReturnType = typeof(EventModifiers))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		private void ProcessKeyEvent(KeyEvent keyEvent) { }

		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputForUIProcessor), Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventModifiers"}, ReturnType = typeof(EventModifiers))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<System.Int32Enum, System.Int32Enum, System.Int32Enum>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.ValueTuple`3<System.Int32Enum, System.Int32Enum, System.Int32Enum>, UnityEngine.UIElements.EventBase>), typeof(System.ValueTuple`3<System.Int32Enum, System.Int32Enum, System.Int32Enum>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.Vector2, System.Int32Enum, System.Int32Enum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Int32Enum", "System.Int32Enum"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		private void ProcessNavigationEvent(NavigationEvent navigationEvent) { }

		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.InputForUI.PointerEvent", Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Func`4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputForUIProcessor), Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventModifiers"}, ReturnType = typeof(EventModifiers))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>, UnityEngine.UIElements.EventBase>), typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 21)]
		[ContainsUnimplementedInstructions]
		private void ProcessPointerEvent(PointerEvent pointerEvent) { }

		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputForUIProcessor), Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventModifiers"}, ReturnType = typeof(EventModifiers))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private void ProcessTextInputEvent(TextInputEvent textInputEvent) { }

	}

	public class LegacyInputProcessor
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Event, EventBase> <>9__26_0; //Field offset: 0x8
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "scrollDelta"})]
			public static Func<Vector3, Vector3, ValueTuple`2<EventModifiers, Vector2>, EventBase> <>9__26_1; //Field offset: 0x10
			public static Func<Vector3, Vector3, Event, EventBase> <>9__26_2; //Field offset: 0x18
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`2<EventModifiers, Nullable`1<Int32>>, EventBase> <>9__27_0; //Field offset: 0x20
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"button", "clickCount", "modifiers", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`4<Int32, Int32, EventModifiers, Nullable`1<Int32>>, EventBase> <>9__27_1; //Field offset: 0x28
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"button", "clickCount", "modifiers", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`4<Int32, Int32, EventModifiers, Nullable`1<Int32>>, EventBase> <>9__27_2; //Field offset: 0x30
			public static Func<LegacyInputProcessor, EventBase> <>9__28_0; //Field offset: 0x38
			public static Func<LegacyInputProcessor, EventBase> <>9__28_1; //Field offset: 0x40
			public static Func<LegacyInputProcessor, EventBase> <>9__28_2; //Field offset: 0x48
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"touch", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`2<Touch, Nullable`1<Int32>>, EventBase> <>9__29_0; //Field offset: 0x50
			public static Func<Vector3, Vector3, PenData, EventBase> <>9__30_0; //Field offset: 0x58
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"direction", "modifiers", "input"})]
			public static Func<ValueTuple`3<Direction, EventModifiers, IInput>, EventBase> <>9__37_0; //Field offset: 0x60

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
			internal EventBase <ProcessMouseEvents>b__27_0(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<EventModifiers, Nullable`1<Int32>> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(PointerEventHelper), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = typeof(EventBase))]
			internal EventBase <ProcessMouseEvents>b__27_1(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Int32, Int32, EventModifiers, Nullable`1<Int32>> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(PointerEventHelper), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = typeof(EventBase))]
			internal EventBase <ProcessMouseEvents>b__27_2(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Int32, Int32, EventModifiers, Nullable`1<Int32>> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PenData), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
			[ContainsUnimplementedInstructions]
			internal EventBase <ProcessPenEvents>b__30_0(Vector3 panelPosition, Vector3 panelDelta, PenData _pen) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
			[CallsUnknownMethods(Count = 2)]
			internal EventBase <ProcessTabEvent>b__37_0(ValueTuple<Direction, EventModifiers, IInput> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
			[CallsDeduplicatedMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			internal EventBase <ProcessTouchEvents>b__29_0(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Touch, Nullable`1<Int32>> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
			internal EventBase <SendIMGUIEvents>b__26_0(Event e) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(WheelEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(EventModifiers)}, ReturnType = typeof(WheelEvent))]
			internal EventBase <SendIMGUIEvents>b__26_1(Vector3 panelPosition, Vector3 _, ValueTuple<EventModifiers, Vector2> t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Event), Member = "set_mousePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Event), Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
			[CallsUnknownMethods(Count = 1)]
			internal EventBase <SendIMGUIEvents>b__26_2(Vector3 panelPosition, Vector3 panelDelta, Event evt) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(LegacyInputProcessor), Member = "GetRawMoveVector", ReturnType = typeof(Vector2))]
			[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal EventBase <SendInputEvents>b__28_0(LegacyInputProcessor self) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
			[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
			[CallsUnknownMethods(Count = 3)]
			internal EventBase <SendInputEvents>b__28_1(LegacyInputProcessor self) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
			[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
			[CallsUnknownMethods(Count = 3)]
			internal EventBase <SendInputEvents>b__28_2(LegacyInputProcessor self) { }

		}

		public interface IInput
		{

			public bool anyKey
			{
				 get { } //Length: 0
			}

			public float doubleClickTime
			{
				 get { } //Length: 0
			}

			public int mouseButtonCount
			{
				 get { } //Length: 0
			}

			public Vector3 mousePosition
			{
				 get { } //Length: 0
			}

			public bool mousePresent
			{
				 get { } //Length: 0
			}

			public int touchCount
			{
				 get { } //Length: 0
			}

			public float unscaledTime
			{
				 get { } //Length: 0
			}

			public void ClearLastPenContactEvent() { }

			public bool get_anyKey() { }

			public float get_doubleClickTime() { }

			public int get_mouseButtonCount() { }

			public Vector3 get_mousePosition() { }

			public bool get_mousePresent() { }

			public int get_touchCount() { }

			public float get_unscaledTime() { }

			public float GetAxisRaw(string axis) { }

			public bool GetButtonDown(string button) { }

			public PenData GetLastPenContactEvent() { }

			public bool GetMouseButtonDown(int button) { }

			public bool GetMouseButtonUp(int button) { }

			public Touch GetTouch(int index) { }

		}

		private class Input : IInput
		{

			public override bool anyKey
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Input), Member = "get_anyKey", ReturnType = typeof(bool))]
				 get { } //Length: 7
			}

			public override float doubleClickTime
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
				 get { } //Length: 31
			}

			public override int mouseButtonCount
			{
				[CallerCount(Count = 6)]
				[DeduplicatedMethod]
				 get { } //Length: 6
			}

			public override Vector3 mousePosition
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
				[DeduplicatedMethod]
				 get { } //Length: 44
			}

			public override bool mousePresent
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
				[DeduplicatedMethod]
				 get { } //Length: 7
			}

			public override int touchCount
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
				[DeduplicatedMethod]
				 get { } //Length: 7
			}

			public override float unscaledTime
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
				[DeduplicatedMethod]
				 get { } //Length: 7
			}

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public Input() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "ClearLastPenContactEvent", ReturnType = typeof(void))]
			public override void ClearLastPenContactEvent() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_anyKey", ReturnType = typeof(bool))]
			public override bool get_anyKey() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
			public override float get_doubleClickTime() { }

			[CallerCount(Count = 6)]
			[DeduplicatedMethod]
			public override int get_mouseButtonCount() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
			[DeduplicatedMethod]
			public override Vector3 get_mousePosition() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			public override bool get_mousePresent() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
			[DeduplicatedMethod]
			public override int get_touchCount() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
			[DeduplicatedMethod]
			public override float get_unscaledTime() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
			public override float GetAxisRaw(string axis) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			public override bool GetButtonDown(string button) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetLastPenContactEvent", ReturnType = typeof(PenData))]
			[DeduplicatedMethod]
			public override PenData GetLastPenContactEvent() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			public override bool GetMouseButtonDown(int button) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			public override bool GetMouseButtonUp(int button) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
			[DeduplicatedMethod]
			public override Touch GetTouch(int index) { }

		}

		private class NoInput : IInput
		{

			public override bool anyKey
			{
				[CallerCount(Count = 271)]
				[DeduplicatedMethod]
				 get { } //Length: 3
			}

			public override float doubleClickTime
			{
				[CallerCount(Count = 0)]
				 get { } //Length: 9
			}

			public override int mouseButtonCount
			{
				[CallerCount(Count = 182)]
				[DeduplicatedMethod]
				 get { } //Length: 3
			}

			public override Vector3 mousePosition
			{
				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				 get { } //Length: 12
			}

			public override bool mousePresent
			{
				[CallerCount(Count = 271)]
				[DeduplicatedMethod]
				 get { } //Length: 3
			}

			public override int touchCount
			{
				[CallerCount(Count = 182)]
				[DeduplicatedMethod]
				 get { } //Length: 3
			}

			public override float unscaledTime
			{
				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				 get { } //Length: 4
			}

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public NoInput() { }

			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			public override void ClearLastPenContactEvent() { }

			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			public override bool get_anyKey() { }

			[CallerCount(Count = 0)]
			public override float get_doubleClickTime() { }

			[CallerCount(Count = 182)]
			[DeduplicatedMethod]
			public override int get_mouseButtonCount() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public override Vector3 get_mousePosition() { }

			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			public override bool get_mousePresent() { }

			[CallerCount(Count = 182)]
			[DeduplicatedMethod]
			public override int get_touchCount() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public override float get_unscaledTime() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public override float GetAxisRaw(string axis) { }

			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			public override bool GetButtonDown(string button) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public override PenData GetLastPenContactEvent() { }

			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			public override bool GetMouseButtonDown(int button) { }

			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			public override bool GetMouseButtonUp(int button) { }

			[CallerCount(Count = 0)]
			public override Touch GetTouch(int index) { }

		}

		private bool m_SendingTouchEvents; //Field offset: 0x10
		private bool m_SendingPenEvent; //Field offset: 0x11
		private EventModifiers m_CurrentModifiers; //Field offset: 0x14
		private int m_LastMousePressButton; //Field offset: 0x18
		private float m_NextMousePressTime; //Field offset: 0x1C
		private int m_LastMouseClickCount; //Field offset: 0x20
		private Vector2 m_LastMousePosition; //Field offset: 0x24
		private bool m_MouseProcessedAtLeastOnce; //Field offset: 0x2C
		private IInput m_Input; //Field offset: 0x30
		private readonly Event m_Event; //Field offset: 0x38
		private readonly DefaultEventSystem m_EventSystem; //Field offset: 0x40
		private int m_ConsecutiveMoveCount; //Field offset: 0x48
		private Vector2 m_LastMoveVector; //Field offset: 0x4C
		private float m_PrevActionTime; //Field offset: 0x54
		private bool m_IsMoveFromKeyboard; //Field offset: 0x58

		public IInput input
		{
			[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
			[CallerCount(Count = 5)]
			[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 63
		}

		private EventModifiers m_CurrentPointerModifiers
		{
			[CallerCount(Count = 0)]
			private get { } //Length: 7
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public LegacyInputProcessor(DefaultEventSystem eventSystem) { }

		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[CallsUnknownMethods(Count = 1)]
		public IInput get_input() { }

		[CallerCount(Count = 0)]
		private EventModifiers get_m_CurrentPointerModifiers() { }

		[CalledBy(Type = typeof(<>c), Member = "<SendInputEvents>b__28_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
		[CalledBy(Type = typeof(<>c), Member = "<SendInputEvents>b__28_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "get_input", ReturnType = typeof(IInput))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendInputEvents", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessPenEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "GetRawMoveVector", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ShouldSendMoveFromInput", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventModifiers)}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(DefaultEventSystem), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public IInput GetDefaultInput() { }

		[CalledBy(Type = typeof(<>c), Member = "<SendInputEvents>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ShouldSendMoveFromInput", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[CallsUnknownMethods(Count = 9)]
		private Vector2 GetRawMoveVector() { }

		[CalledBy(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "ProcessPenEvents", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "SendInputEvents", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		public void ProcessLegacyInputEvents() { }

		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(Func`4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "get_input", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.ValueTuple`4<System.Int32, System.Int32, System.Int32Enum, System.Nullable`1<System.Int32>>, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.ValueTuple`4<System.Int32, System.Int32, System.Int32Enum, System.Nullable`1<System.Int32>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Int32Enum", typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`4<System.Int32, System.Int32, System.Int32Enum, System.Nullable`1<System.Int32>>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.ValueTuple`4<System.Int32, System.Int32, System.Int32Enum, System.Nullable`1<System.Int32>>, UnityEngine.UIElements.EventBase>), typeof(System.ValueTuple`4<System.Int32, System.Int32, System.Int32Enum, System.Nullable`1<System.Int32>>), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 19)]
		[ContainsUnimplementedInstructions]
		private void ProcessMouseEvents() { }

		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.PenData, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PenData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.PenData, UnityEngine.UIElements.EventBase>), typeof(PenData), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		private bool ProcessPenEvents() { }

		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(KeyboardEventExtensions), Member = "ShouldSendNavigationMoveEventRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Event), Member = "get_shift", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(ValueTuple`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private void ProcessTabEvent(Event e, EventModifiers modifiers) { }

		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(Touch), Member = "get_rawPosition", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(Touch), Member = "set_rawPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "ScreenBottomLeftToPanelDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.ValueTuple`2<UnityEngine.Touch, System.Nullable`1<System.Int32>>, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.ValueTuple`2<UnityEngine.Touch, System.Nullable`1<System.Int32>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<UnityEngine.Touch, System.Nullable`1<System.Int32>>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.ValueTuple`2<UnityEngine.Touch, System.Nullable`1<System.Int32>>, UnityEngine.UIElements.EventBase>), typeof(System.ValueTuple`2<UnityEngine.Touch, System.Nullable`1<System.Int32>>), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 9)]
		[ContainsUnimplementedInstructions]
		private bool ProcessTouchEvents() { }

		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Event), Member = "get_delta", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Func`4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "get_input", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.Object, UnityEngine.UIElements.EventBase>), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MultiDisplayToLocalScreenPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, UnityEngine.UIElements.EventBase>), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(Event), Member = "get_pointerType", ReturnType = typeof(PointerType))]
		[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
		[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
		[Calls(Type = typeof(Event), Member = "PopEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventModifiers)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		private void SendIMGUIEvents() { }

		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "ShouldSendMoveFromInput", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, UnityEngine.UIElements.EventBase>), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		private void SendInputEvents() { }

		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetRawMoveVector", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(NavigationMoveEvent), Member = "DetermineMoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Direction))]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		private bool ShouldSendMoveFromInput() { }

	}

	internal enum UpdateMode
	{
		Always = 0,
		IgnoreIfAppNotFocused = 1,
	}

	internal static Func<Boolean> IsEditorRemoteConnected; //Field offset: 0x0
	private BaseRuntimePanel m_FocusedPanel; //Field offset: 0x10
	private BaseRuntimePanel m_PreviousFocusedPanel; //Field offset: 0x18
	private Focusable m_PreviousFocusedElement; //Field offset: 0x20
	private LegacyInputProcessor m_LegacyInputProcessor; //Field offset: 0x28
	private InputForUIProcessor m_InputForUIProcessor; //Field offset: 0x30
	private bool m_IsInputReady; //Field offset: 0x38
	private bool m_UseInputForUI; //Field offset: 0x39
	private bool m_IsInputForUIActive; //Field offset: 0x3A
	internal bool verbose; //Field offset: 0x3B
	internal bool logToGameScreen; //Field offset: 0x3C
	private Label m_LogLabel; //Field offset: 0x40
	private List<String> m_LogLines; //Field offset: 0x48

	public BaseRuntimePanel focusedPanel
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
		[Calls(Type = typeof(Panel), Member = "Focus", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 81
	}

	private InputForUIProcessor inputForUIProcessor
	{
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "RemoveInputProcessor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "InitInputProcessor", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 300
	}

	private bool isAppFocused
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
		private get { } //Length: 64
	}

	internal bool isInputReady
	{
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UnregisterPlayerloopCallback", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DefaultEventSystem), Member = "get_inputForUIProcessor", ReturnType = typeof(InputForUIProcessor))]
		[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Unsubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer", typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(Type[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal set { } //Length: 499
	}

	internal LegacyInputProcessor legacyInputProcessor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 274
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static DefaultEventSystem() { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "get_defaultEventSystem", ReturnType = typeof(DefaultEventSystem))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public DefaultEventSystem() { }

	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal FocusBasedEventSequenceContext FocusBasedEventSequence() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public BaseRuntimePanel get_focusedPanel() { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "RemoveInputProcessor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "InitInputProcessor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private InputForUIProcessor get_inputForUIProcessor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
	private bool get_isAppFocused() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal LegacyInputProcessor get_legacyInputProcessor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "get_inputForUIProcessor", ReturnType = typeof(InputForUIProcessor))]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer", typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(Type[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void InitInputProcessor() { }

	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessNavigationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.KeyEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.TextInputEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.CommandEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessIMECompositionEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.IMECompositionEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "LogToGameScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Log(object o) { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(Object), Member = "FindFirstObjectByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void LogToGameScreen(string s) { }

	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "LogToGameScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void LogWarning(object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PenData), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	private static EventBase MakePenEvent(PenData pen, EventModifiers modifiers, int targetDisplay) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers, int targetDisplay) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
	[Calls(Type = typeof(Panel), Member = "Focus", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void OnFocusEvent(RuntimePanel panel, FocusEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultEventSystem), Member = "get_inputForUIProcessor", ReturnType = typeof(InputForUIProcessor))]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Unsubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RemoveInputProcessor() { }

	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessNavigationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.KeyEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.TextInputEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DefaultEventSystem), Member = "UpdateFocusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>))]
	[Calls(Type = typeof(FocusController), Member = "get_focusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 21)]
	[DeduplicatedMethod]
	internal void SendFocusBasedEvent(Func<TArg, EventBase> evtFactory, TArg arg) { }

	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "ScreenToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2&), typeof(Vector2&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "PointerEntersPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "PointerLeavesPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "ScreenToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(EventBase), Member = "get_processedByFocusController", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPlayerPanelWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "UpdateFocusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "SetPlayerPanelWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void SendPositionBasedEvent(Vector3 mousePosition, Vector3 delta, int pointerId, Nullable<Int32> targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
	[Calls(Type = typeof(Panel), Member = "Focus", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_focusedPanel(BaseRuntimePanel value) { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UnregisterPlayerloopCallback", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DefaultEventSystem), Member = "get_inputForUIProcessor", ReturnType = typeof(InputForUIProcessor))]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Unsubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer", typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(Type[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void set_isInputReady(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool ShouldIgnoreEventsOnAppNotFocused() { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "get_inputForUIProcessor", ReturnType = typeof(InputForUIProcessor))]
	[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Update(UpdateMode updateMode = 0) { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FocusController), Member = "get_focusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
	[Calls(Type = typeof(Panel), Member = "Focus", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel) { }

}

