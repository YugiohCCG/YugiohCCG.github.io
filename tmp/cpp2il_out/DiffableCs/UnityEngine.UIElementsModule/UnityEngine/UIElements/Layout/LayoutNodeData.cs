namespace UnityEngine.UIElements.Layout;

internal struct LayoutNodeData
{
	[Flags]
	public enum FlexStatus
	{
		IsDirty = 1,
		HasNewLayout = 4,
		DependsOnParentSize = 64,
		Fixed = 8,
		MinViolation = 16,
		MaxViolation = 32,
	}

	public FixedBuffer2<LayoutValue> ResolvedDimensions; //Field offset: 0x0
	private float TargetSize; //Field offset: 0x10
	public int ManagedMeasureFunctionIndex; //Field offset: 0x14
	public int ManagedBaselineFunctionIndex; //Field offset: 0x18
	public int ManagedOwnerIndex; //Field offset: 0x1C
	public int LineIndex; //Field offset: 0x20
	public LayoutHandle Config; //Field offset: 0x24
	public LayoutHandle Parent; //Field offset: 0x2C
	public LayoutHandle NextChild; //Field offset: 0x34
	public LayoutList<LayoutHandle> Children; //Field offset: 0x40
	private FlexStatus Status; //Field offset: 0x50

	public bool HasNewLayout
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 25
	}

	public bool IsDirty
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 25
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_HasNewLayout() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_IsDirty() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_HasNewLayout(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_IsDirty(bool value) { }

}

