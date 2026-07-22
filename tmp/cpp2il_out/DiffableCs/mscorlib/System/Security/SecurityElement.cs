namespace System.Security;

[ComVisible(True)]
public sealed class SecurityElement
{
	public class SecurityAttribute
	{
		private string _name; //Field offset: 0x10
		private string _value; //Field offset: 0x18

		public string Name
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string Value
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CalledBy(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SecurityElement), Member = "Unescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 12)]
		public SecurityAttribute(string name, string value) { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public string get_Name() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public string get_Value() { }

	}

	private static readonly Char[] invalid_tag_chars; //Field offset: 0x0
	private static readonly Char[] invalid_text_chars; //Field offset: 0x8
	private static readonly Char[] invalid_attr_name_chars; //Field offset: 0x10
	private static readonly Char[] invalid_attr_value_chars; //Field offset: 0x18
	private static readonly Char[] invalid_chars; //Field offset: 0x20
	private string text; //Field offset: 0x10
	private string tag; //Field offset: 0x18
	private ArrayList attributes; //Field offset: 0x20
	private ArrayList children; //Field offset: 0x28

	public ArrayList Children
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal string m_strText
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public string Tag
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Text
	{
		[CalledBy(Type = typeof(SecurityParser), Member = "OnChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SecurityElement), Member = "Unescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 327
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static SecurityElement() { }

	[CalledBy(Type = typeof(SecurityParser), Member = "OnStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public SecurityElement(string tag) { }

	[CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[CalledBy(Type = typeof(PermissionSet), Member = "ToXml", ReturnType = typeof(SecurityElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SecurityElement), Member = "Unescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public SecurityElement(string tag, string text) { }

	[CalledBy(Type = typeof(SecurityParser), Member = "OnStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[CalledBy(Type = typeof(NamedPermissionSet), Member = "ToXml", ReturnType = typeof(SecurityElement))]
	[CalledBy(Type = typeof(PermissionSet), Member = "ToXml", ReturnType = typeof(SecurityElement))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SecurityElement), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecurityAttribute))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SecurityAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void AddAttribute(string name, string value) { }

	[CalledBy(Type = typeof(SecurityParser), Member = "OnStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void AddChild(SecurityElement child) { }

	[CalledBy(Type = typeof(SecurityParser), Member = "OnStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecurityParser), Member = "OnChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecurityElement), Member = "ToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string Escape(string str) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public ArrayList get_Children() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Tag() { }

	[CalledBy(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	internal SecurityAttribute GetAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool IsValidAttributeName(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool IsValidAttributeValue(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool IsValidTag(string tag) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool IsValidText(string text) { }

	[CalledBy(Type = typeof(KeyPairPersistence), Member = "Load", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "FromXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public SecurityElement SearchForChildByTag(string tag) { }

	[CalledBy(Type = typeof(SecurityElement), Member = "SearchForTextOfLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SecurityElement), Member = "SearchForTextOfLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SecurityElement), Member = "Unescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal string SearchForTextOfLocalName(string strLocalName) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_m_strText(string value) { }

	[CalledBy(Type = typeof(SecurityParser), Member = "OnChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SecurityElement), Member = "Unescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void set_Text(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SecurityElement), Member = "ToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder&), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(SecurityElement), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SecurityElement), Member = "ToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SecurityElement), Member = "Escape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(SecurityElement), Member = "ToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder&), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private void ToXml(ref StringBuilder s, int level) { }

	[CalledBy(Type = typeof(SecurityAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecurityElement), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecurityElement), Member = "SearchForTextOfLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string Unescape(string str) { }

}

