namespace UnityEngine.InputSystem.Layouts;

public struct InputDeviceMatcher : IEquatable<InputDeviceMatcher>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Char, Boolean> <>9__12_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		internal bool <With>b__12_0(char ch) { }

	}

	[CompilerGenerated]
	private sealed class <get_patterns>d__4 : IEnumerable<KeyValuePair`2<String, Object>>, IEnumerable, IEnumerator<KeyValuePair`2<String, Object>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private KeyValuePair<String, Object> <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		public InputDeviceMatcher <>4__this; //Field offset: 0x30
		public InputDeviceMatcher <>3__<>4__this; //Field offset: 0x38
		private int <count>5__2; //Field offset: 0x40
		private int <i>5__3; //Field offset: 0x44

		private override KeyValuePair<String, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			private get { } //Length: 69
		}

		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <get_patterns>d__4(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<KeyValuePair`2<String, Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override KeyValuePair<String, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	public struct MatcherJson
	{
		internal struct Capability
		{
			public string path; //Field offset: 0x0
			public string value; //Field offset: 0x8

		}

		public string interface; //Field offset: 0x0
		public String[] interfaces; //Field offset: 0x8
		public string deviceClass; //Field offset: 0x10
		public String[] deviceClasses; //Field offset: 0x18
		public string manufacturer; //Field offset: 0x20
		public string manufacturerContains; //Field offset: 0x28
		public String[] manufacturers; //Field offset: 0x30
		public string product; //Field offset: 0x38
		public String[] products; //Field offset: 0x40
		public string version; //Field offset: 0x48
		public String[] versions; //Field offset: 0x50
		public Capability[] capabilities; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		public static MatcherJson FromMatcher(InputDeviceMatcher matcher) { }

		[CalledBy(Type = typeof(InputControlLayout), Member = "ParseHeaderFieldsFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InternedString&), typeof(InlinedArray`1<InternedString>&), typeof(InputDeviceMatcher&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputDeviceMatcher), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
		[Calls(Type = typeof(InputDeviceMatcher), Member = "WithManufacturerContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDeviceMatcher))]
		[Calls(Type = typeof(InputDeviceMatcher), Member = "WithCapability", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(InputDeviceMatcher))]
		[CallsUnknownMethods(Count = 1)]
		public InputDeviceMatcher ToMatcher() { }

	}

	private static readonly InternedString kInterfaceKey; //Field offset: 0x0
	private static readonly InternedString kDeviceClassKey; //Field offset: 0x10
	private static readonly InternedString kManufacturerKey; //Field offset: 0x20
	private static readonly InternedString kManufacturerContainsKey; //Field offset: 0x30
	private static readonly InternedString kProductKey; //Field offset: 0x40
	private static readonly InternedString kVersionKey; //Field offset: 0x50
	private KeyValuePair<InternedString, Object>[] m_Patterns; //Field offset: 0x0

	public bool empty
	{
		[CallerCount(Count = 13)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public IEnumerable<KeyValuePair`2<String, Object>> patterns
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[IteratorStateMachine(typeof(<get_patterns>d__4))]
		 get { } //Length: 115
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Intern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 25)]
	private static InputDeviceMatcher() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher), typeof(InputDeviceMatcher)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher), typeof(InputDeviceMatcher)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override bool Equals(InputDeviceMatcher other) { }

	[CalledBy(Type = typeof(HID), Member = "OnFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(string), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue"}, ReturnType = typeof(int))]
	public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription) { }

	[CallerCount(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_empty() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<get_patterns>d__4))]
	public IEnumerable<KeyValuePair`2<String, Object>> get_patterns() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private static int GetNumPropertiesIn(InputDeviceDescription description) { }

	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayoutWithInferiorMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddAvailableDevicesMatchingDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Collection), Member = "TryFindMatchingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(InternedString))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "NavigateToProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "CurrentPropertyHasValueEqualTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "MatchSingleProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public float MatchPercentage(InputDeviceDescription deviceDescription) { }

	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "MatchPercentage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private static bool MatchSingleProperty(object pattern, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool MatchSinglePropertyContains(object pattern, string value) { }

	[CalledBy(Type = typeof(Collection), Member = "AddMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(bool))]
	public static bool op_Equality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(MatcherJson), Member = "ToMatcher", ReturnType = typeof(InputDeviceMatcher))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "WithInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "WithDeviceClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "WithManufacturer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "WithProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "WithVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "WithCapability", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValue"}, ReturnType = typeof(InputDeviceMatcher))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Enumerable), Member = "All", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private InputDeviceMatcher With(InternedString key, object value, bool supportRegex = true) { }

	[CalledBy(Type = typeof(SwitchSupportHID), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HID), Member = "OnFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(string), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DualShockSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 48)]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public InputDeviceMatcher WithCapability(string path, TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex = true) { }

	[CalledBy(Type = typeof(XRSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XInputSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SwitchSupportHID), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualShockSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	public InputDeviceMatcher WithInterface(string pattern, bool supportRegex = true) { }

	[CalledBy(Type = typeof(XRSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex = true) { }

	[CalledBy(Type = typeof(DualShockSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatcherJson), Member = "ToMatcher", ReturnType = typeof(InputDeviceMatcher))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue"}, ReturnType = typeof(int))]
	public InputDeviceMatcher WithManufacturerContains(string noRegExPattern) { }

	[CalledBy(Type = typeof(XRSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualShockSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	public InputDeviceMatcher WithProduct(string pattern, bool supportRegex = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	public InputDeviceMatcher WithVersion(string pattern, bool supportRegex = true) { }

}

