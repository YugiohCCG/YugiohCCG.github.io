namespace UnityEngine.UIElements.Layout;

internal struct LayoutCacheData
{
	public static LayoutCacheData Default; //Field offset: 0x0
	public uint NextCachedMeasurementsIndex; //Field offset: 0x0
	public FixedBuffer16<LayoutCachedMeasurement> cachedMeasurements; //Field offset: 0x4
	public LayoutCachedMeasurement CachedLayout; //Field offset: 0x204

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static LayoutCacheData() { }

}

