namespace System.Xml;

internal class CharEntityEncoderFallback : EncoderFallback
{
	private CharEntityEncoderFallbackBuffer fallbackBuffer; //Field offset: 0x10
	private Int32[] textContentMarks; //Field offset: 0x18
	private int endMarkPos; //Field offset: 0x20
	private int curMarkPos; //Field offset: 0x24
	private int startOffset; //Field offset: 0x28

	public virtual int MaxCharCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	internal int StartOffset
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal CharEntityEncoderFallback() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal bool CanReplaceAt(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int get_MaxCharCount() { }

	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "FlushBuffer", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void Reset(Int32[] textContentMarks, int endMarkPos) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	internal void set_StartOffset(int value) { }

}

