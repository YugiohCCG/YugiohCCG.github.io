namespace UnityEngine.InputSystem.Utilities;

[DefaultMember("Item")]
internal struct Substring : IComparable<Substring>, IEquatable<Substring>
{
	private readonly string m_String; //Field offset: 0x0
	private readonly int m_Index; //Field offset: 0x8
	private readonly int m_Length; //Field offset: 0xC

	public int index
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool isEmpty
	{
		[CalledBy(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
		[CalledBy(Type = typeof(ParsedPathComponent), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ParsedPathComponent), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsedPathComponent&), typeof(ControlItem&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputDeviceDescription), Member = "ComparePropertyToDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonString), typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 13)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public char Item
	{
		[CalledBy(Type = typeof(ParsedPathComponent), Member = "ComparePathElementToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlPath), Member = "StringMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonString), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(JsonString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonString)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 126
	}

	public int length
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Substring(string str) { }

	[CallerCount(Count = 94)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Substring(string str, int index, int length) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Substring(string str, int index) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(JsonString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonString)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	public static int Compare(Substring left, Substring right, StringComparison comparison) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	public override int CompareTo(Substring other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Equals(string other) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Substring other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Equals(InternedString other) { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_index() { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsedPathComponent&), typeof(ControlItem&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDeviceDescription), Member = "ComparePropertyToDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonString), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[ContainsUnimplementedInstructions]
	public bool get_isEmpty() { }

	[CalledBy(Type = typeof(ParsedPathComponent), Member = "ComparePathElementToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlPath), Member = "StringMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonString), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonString)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public char get_Item(int index) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_length() { }

	[CalledBy(Type = typeof(JsonString), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JsonValue), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(Substring a, Substring b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Substring a, InternedString b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(InternedString a, Substring b) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "get_isWildcard", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "get_isDoubleWildcard", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManager), Member = "MakeEscapedJsonString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JsonString))]
	[CalledBy(Type = typeof(JsonString), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JsonString))]
	[CalledBy(Type = typeof(JsonValue), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JsonValue))]
	[CalledBy(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonValue)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	public static Substring op_Implicit(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Substring a, Substring b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Substring a, InternedString b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(InternedString a, Substring b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public bool StartsWith(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string Substr(int index = 0, int length = -1) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputControlPath+ParsedPathComponent+<>c", Member = "<get_usages>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "get_layout", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "get_name", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "get_displayName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlPath+<>c", Member = "<TryGetDeviceUsages>b__9_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryGetDeviceLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryGetControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonString), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

