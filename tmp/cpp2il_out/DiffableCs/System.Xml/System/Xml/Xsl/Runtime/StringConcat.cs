namespace System.Xml.Xsl.Runtime;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public struct StringConcat
{
	private string s1; //Field offset: 0x0
	private string s2; //Field offset: 0x8
	private string s3; //Field offset: 0x10
	private string s4; //Field offset: 0x18
	private string delimiter; //Field offset: 0x20
	private List<String> strList; //Field offset: 0x28
	private int idxStr; //Field offset: 0x30

	internal int Count
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CalledBy(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Clear() { }

	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	internal void ConcatNoDelimiter(string s) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_Count() { }

	[CalledBy(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string GetResult() { }

}

