namespace System.IO;

public class EnumerationOptions
{
	[CompilerGenerated]
	private static readonly EnumerationOptions <Compatible>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly EnumerationOptions <CompatibleRecursive>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static readonly EnumerationOptions <Default>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <RecurseSubdirectories>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IgnoreInaccessible>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private int <BufferSize>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private FileAttributes <AttributesToSkip>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private MatchType <MatchType>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private MatchCasing <MatchCasing>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <ReturnSpecialDirectories>k__BackingField; //Field offset: 0x24

	public FileAttributes AttributesToSkip
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int BufferSize
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	internal static EnumerationOptions Compatible
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 78
	}

	private static EnumerationOptions CompatibleRecursive
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private get { } //Length: 79
	}

	internal static EnumerationOptions Default
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 79
	}

	public bool IgnoreInaccessible
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

	public MatchCasing MatchCasing
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public MatchType MatchType
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool RecurseSubdirectories
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 370
	}

	public bool ReturnSpecialDirectories
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static EnumerationOptions() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public EnumerationOptions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static EnumerationOptions FromSearchOption(SearchOption searchOption) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public FileAttributes get_AttributesToSkip() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_BufferSize() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static EnumerationOptions get_Compatible() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static EnumerationOptions get_CompatibleRecursive() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static EnumerationOptions get_Default() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IgnoreInaccessible() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MatchCasing get_MatchCasing() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MatchType get_MatchType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_RecurseSubdirectories() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_ReturnSpecialDirectories() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_AttributesToSkip(FileAttributes value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IgnoreInaccessible(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_MatchType(MatchType value) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_RecurseSubdirectories(bool value) { }

}

