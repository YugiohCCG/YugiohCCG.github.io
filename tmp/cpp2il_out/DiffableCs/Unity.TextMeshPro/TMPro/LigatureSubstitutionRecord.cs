namespace TMPro;

public struct LigatureSubstitutionRecord
{
	[SerializeField]
	private UInt32[] m_ComponentGlyphIDs; //Field offset: 0x0
	[SerializeField]
	private uint m_LigatureGlyphID; //Field offset: 0x8

	public UInt32[] componentGlyphIDs
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public uint ligatureGlyphID
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public UInt32[] get_componentGlyphIDs() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public uint get_ligatureGlyphID() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Inequality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_componentGlyphIDs(UInt32[] value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_ligatureGlyphID(uint value) { }

}

