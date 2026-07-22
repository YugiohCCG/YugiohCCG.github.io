namespace UnityEngine.UIElements.Layout;

[IsReadOnly]
internal struct LayoutConfig
{
	private readonly LayoutDataAccess m_Access; //Field offset: 0x0
	private readonly LayoutHandle m_Handle; //Field offset: 0x28

	public LayoutHandle Handle
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float PointScaleFactor
	{
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 109
	}

	public static LayoutConfig Undefined
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 24
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal LayoutConfig(LayoutDataAccess access, LayoutHandle handle) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public LayoutHandle get_Handle() { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_PointScaleFactor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static LayoutConfig get_Undefined() { }

}

