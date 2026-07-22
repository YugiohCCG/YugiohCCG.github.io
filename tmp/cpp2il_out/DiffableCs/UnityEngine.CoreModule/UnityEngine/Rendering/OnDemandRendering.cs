namespace UnityEngine.Rendering;

[RequiredByNativeCode]
public class OnDemandRendering
{
	private static int m_RenderFrameInterval; //Field offset: 0x0

	public static int renderFrameInterval
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 77
	}

	[CallerCount(Count = 0)]
	private static OnDemandRendering() { }

	[CallerCount(Count = 0)]
	public static int get_renderFrameInterval() { }

	[CallerCount(Count = 0)]
	[RequiredByNativeCode]
	internal static void GetRenderFrameInterval(out int frameInterval) { }

}

