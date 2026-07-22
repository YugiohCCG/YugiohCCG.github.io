namespace NGettext.Loaders;

public class MoFile
{
	[CompilerGenerated]
	private Version <FormatRevision>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <BigEndian>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Encoding <Encoding>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Dictionary<String, String> <Headers>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Dictionary<String, String[]> <Translations>k__BackingField; //Field offset: 0x30

	public bool BigEndian
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Encoding Encoding
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Version FormatRevision
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Dictionary<String, String> Headers
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Dictionary<String, String[]> Translations
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public MoFile(Version formatRevision, Encoding encoding = null, bool bigEndian = false) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_BigEndian() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Encoding get_Encoding() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Version get_FormatRevision() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Dictionary<String, String> get_Headers() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Dictionary<String, String[]> get_Translations() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_BigEndian(bool value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Encoding(Encoding value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_FormatRevision(Version value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_Headers(Dictionary<String, String> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_Translations(Dictionary<String, String[]> value) { }

}

