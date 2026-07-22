namespace TMPro;

public struct MultipleSubstitutionRecord
{
	[SerializeField]
	private uint m_TargetGlyphID; //Field offset: 0x0
	[SerializeField]
	private UInt32[] m_SubstituteGlyphIDs; //Field offset: 0x8

	public UInt32[] substituteGlyphIDs
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public uint targetGlyphID
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UInt32[] get_substituteGlyphIDs() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public uint get_targetGlyphID() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_substituteGlyphIDs(UInt32[] value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_targetGlyphID(uint value) { }

}

