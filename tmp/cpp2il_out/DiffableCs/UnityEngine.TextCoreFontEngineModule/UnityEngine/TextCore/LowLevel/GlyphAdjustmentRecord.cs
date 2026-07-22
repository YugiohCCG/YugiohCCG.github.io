namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord>
{
	[NativeName("glyphIndex")]
	[SerializeField]
	private uint m_GlyphIndex; //Field offset: 0x0
	[NativeName("glyphValueRecord")]
	[SerializeField]
	private GlyphValueRecord m_GlyphValueRecord; //Field offset: 0x4

	public uint glyphIndex
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public GlyphValueRecord glyphValueRecord
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public GlyphAdjustmentRecord(uint glyphIndex, GlyphValueRecord glyphValueRecord) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	public override bool Equals(GlyphAdjustmentRecord other) { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public uint get_glyphIndex() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public GlyphValueRecord get_glyphValueRecord() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[ExcludeFromDocs]
	public virtual int GetHashCode() { }

}

