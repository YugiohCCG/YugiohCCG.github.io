namespace UnityEngine.Networking;

public struct DownloadedTextureParams
{
	public DownloadedTextureFlags flags; //Field offset: 0x0
	public int mipmapCount; //Field offset: 0x4

	public static DownloadedTextureParams Default
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 22
	}

	public bool readable
	{
		[CallerCount(Count = 0)]
		 set { } //Length: 23
	}

	[CallerCount(Count = 0)]
	public static DownloadedTextureParams get_Default() { }

	[CallerCount(Count = 0)]
	public void set_readable(bool value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	private void SetFlags(DownloadedTextureFlags flgs, bool add) { }

}

