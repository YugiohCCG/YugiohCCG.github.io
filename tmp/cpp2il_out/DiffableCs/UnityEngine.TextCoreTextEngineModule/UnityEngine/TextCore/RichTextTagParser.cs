namespace UnityEngine.TextCore;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal static class RichTextTagParser
{
	[Nullable(0)]
	[NullableContext(1)]
	public class ParseError : IEquatable<ParseError>
	{
		public readonly int position; //Field offset: 0x10
		public readonly string message; //Field offset: 0x18

		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
			[CompilerGenerated]
			 get { } //Length: 77
		}

		[CalledBy(Type = typeof(RichTextTagParser), Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+ParseError>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal ParseError(string message, int position) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[NullableContext(2)]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[ContainsUnimplementedInstructions]
		[NullableContext(2)]
		public override bool Equals(ParseError other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CompilerGenerated]
		protected override Type get_EqualityContract() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeHelpers), Member = "EnsureSufficientExecutionStack", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		protected override bool PrintMembers(StringBuilder builder) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		public virtual string ToString() { }

	}

	internal struct Segment
	{
		[Nullable(2)]
		public List<Tag> tags; //Field offset: 0x0
		public int start; //Field offset: 0x8
		public int end; //Field offset: 0xC

	}

	public struct Tag
	{
		public TagType tagType; //Field offset: 0x0
		public bool isClosing; //Field offset: 0x4
		public int start; //Field offset: 0x8
		public int end; //Field offset: 0xC
		[Nullable(2)]
		public TagValue value; //Field offset: 0x10

	}

	internal enum TagType
	{
		Hyperlink = 0,
		Align = 1,
		AllCaps = 2,
		Alpha = 3,
		Bold = 4,
		Br = 5,
		Color = 6,
		CSpace = 7,
		Font = 8,
		FontWeight = 9,
		Italic = 10,
		Indent = 11,
		LineHeight = 12,
		LineIndent = 13,
		Link = 14,
		Lowercase = 15,
		Mark = 16,
		Mspace = 17,
		NoBr = 18,
		NoParse = 19,
		Strikethrough = 20,
		Size = 21,
		SmallCaps = 22,
		Space = 23,
		Sprite = 24,
		Style = 25,
		Subscript = 26,
		Superscript = 27,
		Underline = 28,
		Uppercase = 29,
		Unknown = 30,
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class TagTypeInfo : IEquatable<TagTypeInfo>
	{
		public TagType TagType; //Field offset: 0x10
		public string name; //Field offset: 0x18
		public TagValueType valueType; //Field offset: 0x20
		public TagUnitType unitType; //Field offset: 0x24

		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
			[CompilerGenerated]
			 get { } //Length: 77
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal TagTypeInfo(TagType tagType, string name, TagValueType valueType = 0, TagUnitType unitType = 0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[NullableContext(2)]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>))]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[ContainsUnimplementedInstructions]
		[NullableContext(2)]
		public override bool Equals(TagTypeInfo other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CompilerGenerated]
		protected override Type get_EqualityContract() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeHelpers), Member = "EnsureSufficientExecutionStack", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		protected override bool PrintMembers(StringBuilder builder) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		public virtual string ToString() { }

	}

	public enum TagUnitType
	{
		Pixels = 0,
		FontUnits = 1,
		Percentage = 2,
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class TagValue : IEquatable<TagValue>
	{
		internal TagValueType type; //Field offset: 0x10
		private string m_stringValue; //Field offset: 0x18
		private float m_numericalValue; //Field offset: 0x20
		private Color m_colorValue; //Field offset: 0x24

		internal Color ColorValue
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			internal get { } //Length: 113
		}

		[CompilerGenerated]
		[Nullable(1)]
		protected override Type EqualityContract
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
			[CompilerGenerated]
			[NullableContext(1)]
			 get { } //Length: 77
		}

		internal string StringValue
		{
			[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment), typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(TextSpan))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			internal get { } //Length: 101
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal TagValue(Color value) { }

		[CalledBy(Type = typeof(RichTextTagParser), Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+ParseError>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(1)]
		internal TagValue(string value) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>))]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[ContainsUnimplementedInstructions]
		public override bool Equals(TagValue other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		internal Color get_ColorValue() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CompilerGenerated]
		[NullableContext(1)]
		protected override Type get_EqualityContract() { }

		[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment), typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(TextSpan))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		internal string get_StringValue() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 271)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(1)]
		protected override bool PrintMembers(StringBuilder builder) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[NullableContext(1)]
		public virtual string ToString() { }

	}

	public enum TagValueType
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 4,
	}

	[Nullable(1)]
	internal static readonly TagTypeInfo[] TagsInfo; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 153)]
	private static RichTextTagParser() { }

	[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment), typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(TextSpan))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTuple`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[NullableContext(1)]
	private static int AddLink(TagType type, string value, List<ValueTuple`3<Int32, TagType, String>> links) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RichTextTagParser), Member = "PickResultingTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>), typeof(string), typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	internal static void ApplyStateToSegment(string input, List<Tag> tags, Segment[] segments) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.ValueTuple`2<NativeTextInfo, Boolean>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RichTextTagParser), Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+ParseError>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
	[Calls(Type = typeof(RichTextTagParser), Member = "GenerateSegments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>)}, ReturnType = typeof(Segment[]))]
	[Calls(Type = typeof(RichTextTagParser), Member = "PickResultingTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>), typeof(string), typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RichTextTagParser), Member = "CreateTextSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment), typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(TextSpan))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void CreateTextGenerationSettingsArray(ref NativeTextGenerationSettings tgs, List<ValueTuple`3<Int32, TagType, String>> links, Color hyperlinkColor) { }

	[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(TagValue), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(RichTextTagParser), Member = "AddLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TagType), typeof(string), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	private static TextSpan CreateTextSpan(Segment segment, ref NativeTextGenerationSettings tgs, List<ValueTuple`3<Int32, TagType, String>> links, Color hyperlinkColor) { }

	[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(RichTextTagParser), Member = "SpanToEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TagType&), typeof(String&), typeof(ReadOnlySpan`1<Char>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ReadOnlySpan`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ColorUtility), Member = "TryParseHtmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParseError), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(TagValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	[NullableContext(1)]
	internal static List<Tag> FindTags(string inputStr, List<ParseError> errors = null) { }

	[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[NullableContext(1)]
	internal static Segment[] GenerateSegments(string input, List<Tag> tags) { }

	[CalledBy(Type = typeof(RichTextTagParser), Member = "ApplyStateToSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>), typeof(Segment[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tag)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[NullableContext(1)]
	internal static List<Tag> PickResultingTags(List<Tag> allTags, string input, int atPosition, List<Tag> applicableTags = null) { }

	[CalledBy(Type = typeof(RichTextTagParser), Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+ParseError>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.ReadOnlySpan`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static bool SpanToEnum(ReadOnlySpan<Char> tagCandidate, out TagType tagType, out string error, out ReadOnlySpan<Char>& attribute) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool tagMatch(ReadOnlySpan<Char> tagCandidate, string tagName) { }

}

