namespace Extensions;

public class BoxSlotData : IPooledData
{
	public string Name; //Field offset: 0x10
	public bool Invalid; //Field offset: 0x18
	public Func<Boolean> InvalidCheck; //Field offset: 0x20
	public bool NameEnabled; //Field offset: 0x28
	public AssetType IconType; //Field offset: 0x2C
	public string IconName; //Field offset: 0x30
	public bool Favorite; //Field offset: 0x38
	public Action<BoxSlot, PointerEventData> OnClick; //Field offset: 0x40
	public string ObjName; //Field offset: 0x48
	public bool HasTag; //Field offset: 0x50

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BoxSlotData() { }

}

