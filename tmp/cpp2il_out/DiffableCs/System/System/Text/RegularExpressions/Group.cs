namespace System.Text.RegularExpressions;

public class Group : Capture
{
	internal static readonly Group s_emptyGroup; //Field offset: 0x0
	internal readonly Int32[] _caps; //Field offset: 0x20
	internal int _capcount; //Field offset: 0x28
	internal CaptureCollection _capcoll; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x38

	public CaptureCollection Captures
	{
		[CalledBy(Type = "NGettext.Loaders.ContentType", Member = "ParseValue", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 141
	}

	public bool Success
	{
		[CallerCount(Count = 30)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static Group() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal Group(string text, Int32[] caps, int capcount, string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal Group() { }

	[CalledBy(Type = "NGettext.Loaders.ContentType", Member = "ParseValue", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public CaptureCollection get_Captures() { }

	[CallerCount(Count = 30)]
	[ContainsUnimplementedInstructions]
	public bool get_Success() { }

}

