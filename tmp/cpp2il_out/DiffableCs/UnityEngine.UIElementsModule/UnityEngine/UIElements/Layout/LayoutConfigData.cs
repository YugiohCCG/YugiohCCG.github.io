namespace UnityEngine.UIElements.Layout;

internal struct LayoutConfigData
{
	public float PointScaleFactor; //Field offset: 0x0
	public bool ShouldLog; //Field offset: 0x4

	public static LayoutConfigData Default
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 28
	}

	[CallerCount(Count = 0)]
	public static LayoutConfigData get_Default() { }

}

