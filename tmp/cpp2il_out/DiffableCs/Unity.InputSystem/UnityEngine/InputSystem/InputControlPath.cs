namespace UnityEngine.InputSystem;

[Extension]
public static class InputControlPath
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Substring, String> <>9__9_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		internal string <TryGetDeviceUsages>b__9_0(Substring x) { }

	}

	[CompilerGenerated]
	private sealed class <Parse>d__34 : IEnumerable<ParsedPathComponent>, IEnumerable, IEnumerator<ParsedPathComponent>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ParsedPathComponent <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x68
		private string path; //Field offset: 0x70
		public string <>3__path; //Field offset: 0x78
		private PathParser <parser>5__2; //Field offset: 0x80

		private override ParsedPathComponent System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 43
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			private get { } //Length: 105
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		public <Parse>d__34(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputSystem.InputControlPath+PathParser", Member = "MoveToNextComponent", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override ParsedPathComponent System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.get_Current() { }

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

	[Flags]
	internal enum HumanReadableStringOptions
	{
		None = 0,
		OmitDevice = 2,
		UseShortNames = 4,
	}

	internal struct ParsedPathComponent
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Substring, String> <>9__7_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
			[DeduplicatedMethod]
			internal string <get_usages>b__7_0(Substring x) { }

		}

		internal Substring m_Layout; //Field offset: 0x0
		internal InlinedArray<Substring> m_Usages; //Field offset: 0x10
		internal Substring m_Name; //Field offset: 0x30
		internal Substring m_DisplayName; //Field offset: 0x40

		public string displayName
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
			 get { } //Length: 11
		}

		internal bool isDoubleWildcard
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
			[CallsDeduplicatedMethods(Count = 1)]
			internal get { } //Length: 109
		}

		internal bool isWildcard
		{
			[CalledBy(Type = typeof(InputControlPath), Member = "TryGetDeviceLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
			[CalledBy(Type = typeof(InputControlPath), Member = "TryGetControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
			[CallsDeduplicatedMethods(Count = 1)]
			internal get { } //Length: 109
		}

		public string layout
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
			 get { } //Length: 7
		}

		public string name
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
			 get { } //Length: 11
		}

		public IEnumerable<String> usages
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 326
		}

		[CalledBy(Type = typeof(ParsedPathComponent), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Substring), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(char), Member = "ToLowerInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private static bool ComparePathElementToString(Substring pathElement, string element) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
		public string get_displayName() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool get_isDoubleWildcard() { }

		[CalledBy(Type = typeof(InputControlPath), Member = "TryGetDeviceLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputControlPath), Member = "TryGetControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool get_isWildcard() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
		public string get_layout() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
		public string get_name() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[CallsUnknownMethods(Count = 1)]
		public IEnumerable<String> get_usages() { }

		[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputControlPath), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchesPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchesRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControl), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Substring), Member = "get_isEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ParsedPathComponent), Member = "ComparePathElementToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(InputControl), Member = "get_usages", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString>))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		public bool Matches(InputControl control) { }

		[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "get_Value", ReturnType = typeof(ControlItem))]
		[Calls(Type = typeof(InputControlLayout), Member = "FindControlIncludingArrayElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>))]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Cache), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputControlLayout))]
		[Calls(Type = typeof(InputControlLayout), Member = "get_cache", ReturnType = typeof(Cache&))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringHelpers), Member = "Unescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Substring), Member = "get_isEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, HumanReadableStringOptions options) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(StringHelpers), Member = "Unescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		private static string ToHumanReadableString(Substring substring) { }

	}

	public enum PathComponentType
	{
		Name = 0,
		DisplayName = 1,
		Usage = 2,
		Layout = 3,
	}

	private struct PathParser
	{
		private string path; //Field offset: 0x0
		private int length; //Field offset: 0x8
		private int leftIndexInPath; //Field offset: 0xC
		private int rightIndexInPath; //Field offset: 0x10
		public ParsedPathComponent current; //Field offset: 0x18

		public bool isAtEnd
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 10
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public PathParser(string path) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_isAtEnd() { }

		[CalledBy(Type = "UnityEngine.InputSystem.InputControlPath+<Parse>d__34", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputControlPath), Member = "TryGetDeviceUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
		[CalledBy(Type = typeof(InputControlPath), Member = "TryGetDeviceLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputControlPath), Member = "TryGetControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControlLayout)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputControlPath), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchesPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchesRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControl), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(InlinedArray`1), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		public bool MoveToNextComponent() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private Substring ParseComponentPart(char terminator) { }

	}

	public const string Wildcard = "*"; //Field offset: 0x0
	public const string DoubleWildcard = "**"; //Field offset: 0x0
	public const char Separator = '\u2F'; //Field offset: 0x0
	internal const char SeparatorReplacement = '\u20'; //Field offset: 0x0

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	internal static string CleanSlashes(string pathComponent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string Combine(InputControl parent, string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlPath), Member = "StringMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	private static bool ControlLayoutMatchesPathComponent(ref ControlItem controlItem, ref PathParser parser) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "TryGetControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControlLayout)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlLayout), Member = "CacheRef", ReturnType = typeof(CacheRefInstance))]
	[Calls(Type = typeof(InputControlLayout), Member = "get_cache", ReturnType = typeof(Cache&))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Cache), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputControlLayout))]
	[Calls(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControlLayout)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CacheRefInstance), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string FindControlLayoutRecursive(ref PathParser parser, string layoutName) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControlLayout), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>))]
	[Calls(Type = typeof(InputControlPath), Member = "StringMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InternedString), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathParser), Member = "MoveToNextComponent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static string FindControlLayoutRecursive(ref PathParser parser, InputControlLayout layout) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControlPath), Member = "PathComponentCanYieldMultipleMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "MatchPathComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(PathComponentType), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	private static TControl MatchByUsageAtDeviceRootRecursive(InputDevice device, string path, int indexInPath, ref InputControlList<TControl>& matches, bool matchMultiple) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_children", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(InputControlPath), Member = "PathComponentCanYieldMultipleMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static TControl MatchChildrenRecursive(InputControl control, string path, int indexInPath, ref InputControlList<TControl>& matches, bool matchMultiple) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Substring), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "StringMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InlinedArray`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<TValue>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static bool MatchControlComponent(ref ParsedPathComponent expectedControlComponent, ref ControlItem controlItem, bool matchAlias = false) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindChild", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchChildrenRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputControlPath), Member = "MatchPathComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(PathComponentType), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "get_displayName", ReturnType = typeof(string))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "get_usages", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString>))]
	[Calls(Type = typeof(InputControl), Member = "get_layout", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "get_aliases", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString>))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "MatchByUsageAtDeviceRootRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static TControl MatchControlsRecursive(InputControl control, string path, int indexInPath, ref InputControlList<TControl>& matches, bool matchMultiple) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "IsUsableWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionMap), Member = "IsUsableWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "MatchesRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControl), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathParser), Member = "MoveToNextComponent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsedPathComponent), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static bool Matches(string expected, InputControl control) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "HavePathMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(String[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "MatchesRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControl), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathParser), Member = "MoveToNextComponent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsedPathComponent), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static bool MatchesPrefix(string expected, InputControl control) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlPath), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchesPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchesRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControl), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputControlPath), Member = "MatchesRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControl), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathParser), Member = "MoveToNextComponent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsedPathComponent), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool MatchesRecursive(ref PathParser parser, InputControl currentControl, bool prefixOnly = false) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchByUsageAtDeviceRootRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchPathComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(PathComponentType), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "ToLowerInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputControlPath), Member = "MatchPathComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(PathComponentType), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool MatchPathComponent(string component, string path, ref int indexInPath, PathComponentType componentType, int startIndexInComponent = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<Parse>d__34))]
	public static IEnumerable<ParsedPathComponent> Parse(string path) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "MatchByUsageAtDeviceRootRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchChildrenRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControlLayout)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlPath), Member = "ControlLayoutMatchesPathComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem&), typeof(PathParser&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsedPathComponent&), typeof(ControlItem&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InternedString), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(Substring), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "ToLowerInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool StringMatches(Substring str, InternedString matchTo) { }

	[CalledBy(Type = typeof(InputBinding), Member = "ToDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(String&), typeof(DisplayStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CacheRefInstance), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ParsedPathComponent), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControlLayout), Member = "CacheRef", ReturnType = typeof(CacheRefInstance))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "get_displayName", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "get_shortDisplayName", ReturnType = typeof(string))]
	[Calls(Type = typeof(ParsedPathComponent), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathParser), Member = "MoveToNextComponent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "MatchesRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControl), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	public static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, HumanReadableStringOptions options = 0, InputControl control = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	public static string ToHumanReadableString(string path, HumanReadableStringOptions options = 0, InputControl control = null) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControlIfMissing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InsertChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem&)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ApplyUseStateFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&), typeof(InputControlLayout)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindChild", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	public static InputControl TryFindChild(InputControl control, string path, int indexInPath = 0) { }

	[CalledBy(Type = typeof(InputControl), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputControl), Member = "TryGetChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputControl), Member = "GetChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputControl), Member = "get_children", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static TControl TryFindChild(InputControl control, string path, int indexInPath = 0) { }

	[CalledBy(Type = typeof(InputControlScheme), Member = "SupportsDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputSystem), Member = "FindControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static TControl TryFindControl(InputControl control, string path, int indexInPath = 0) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverridesOnMatchingControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputActionState), Member = "CanUseDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlScheme), Member = "PickDevicesFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", typeof(InputDevice)}, ReturnType = typeof(MatchResult))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "SetupInputControl", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	public static InputControl TryFindControl(InputControl control, string path, int indexInPath = 0) { }

	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "FindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputControlList`1<TControl>")]
	[CalledBy(Type = typeof(InputSystem), Member = "FindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.InputSystem.InputControlList`1<TControl>&"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl[]))]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(InputControlList`1<InputControl>&), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputManager), Member = "GetControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.InputSystem.InputControlList`1<TControl>&"}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int TryFindControls(InputControl control, string path, int indexInPath, ref InputControlList<TControl>& matches) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControlList`1), Member = "ToArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "TControl[]")]
	[Calls(Type = typeof(InputControlList`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&"}, ReturnType = typeof(int))]
	public static int TryFindControls(InputControl control, string path, ref InputControlList<InputControl>& matches, int indexInPath = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PathParser), Member = "MoveToNextComponent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsedPathComponent), Member = "get_isWildcard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringHelpers), Member = "Unescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static string TryGetControlLayout(string path) { }

	[CalledBy(Type = typeof(InputControlScheme), Member = "PickDevicesFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", typeof(InputDevice)}, ReturnType = typeof(MatchResult))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "SetupInputControl", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PathParser), Member = "MoveToNextComponent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsedPathComponent), Member = "get_isWildcard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringHelpers), Member = "Unescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static string TryGetDeviceLayout(string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PathParser), Member = "MoveToNextComponent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOther"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TValue, TOther>"}, ReturnType = "TOther[]")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static String[] TryGetDeviceUsages(string path) { }

}

