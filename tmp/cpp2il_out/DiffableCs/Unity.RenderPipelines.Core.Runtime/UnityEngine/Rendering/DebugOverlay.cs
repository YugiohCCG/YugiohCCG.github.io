namespace UnityEngine.Rendering;

public class DebugOverlay
{
	[CompilerGenerated]
	private int <x>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <y>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <overlaySize>k__BackingField; //Field offset: 0x18
	private int m_InitialPositionX; //Field offset: 0x1C
	private int m_ScreenWidth; //Field offset: 0x20

	public private int overlaySize
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int x
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int y
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugOverlay() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_overlaySize() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_x() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_y() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+<>c", Member = "<RenderFragmentationOverlay>b__45_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+RenderFragmentationOverlayPassData", typeof(RenderGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public Rect Next(float aspect = 1) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_overlaySize(int value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_x(int value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_y(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+<>c", Member = "<RenderFragmentationOverlay>b__45_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+RenderFragmentationOverlayPassData", typeof(RenderGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetViewport(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	public void StartOverlay(int initialX, int initialY, int overlaySize, int screenWidth) { }

}

