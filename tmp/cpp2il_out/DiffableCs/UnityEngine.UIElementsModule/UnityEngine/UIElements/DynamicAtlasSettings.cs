namespace UnityEngine.UIElements;

public class DynamicAtlasSettings
{
	[HideInInspector]
	[SerializeField]
	private int m_MinAtlasSize; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private int m_MaxAtlasSize; //Field offset: 0x14
	[HideInInspector]
	[SerializeField]
	private int m_MaxSubTextureSize; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private DynamicAtlasFilters m_ActiveFilters; //Field offset: 0x1C
	private DynamicAtlasCustomFilter m_CustomFilter; //Field offset: 0x20

	public DynamicAtlasFilters activeFilters
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DynamicAtlasCustomFilter customFilter
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public static DynamicAtlasFilters defaultFilters
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 7
	}

	public static DynamicAtlasSettings defaults
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 128
	}

	public int maxAtlasSize
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int maxSubTextureSize
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int minAtlasSize
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DynamicAtlasSettings() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public DynamicAtlasFilters get_activeFilters() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public DynamicAtlasCustomFilter get_customFilter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DynamicAtlasFilters get_defaultFilters() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static DynamicAtlasSettings get_defaults() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_maxAtlasSize() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_maxSubTextureSize() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_minAtlasSize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_activeFilters(DynamicAtlasFilters value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_maxAtlasSize(int value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_maxSubTextureSize(int value) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_minAtlasSize(int value) { }

}

