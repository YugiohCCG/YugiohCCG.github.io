namespace TMPro;

internal struct RichTextTagAttribute
{
	private static readonly RichTextTagAttribute k_Default; //Field offset: 0x0
	public int nameHashCode; //Field offset: 0x0
	public int valueHashCode; //Field offset: 0x4
	public TagValueType valueType; //Field offset: 0x8
	public int valueStartIndex; //Field offset: 0xC
	public int valueLength; //Field offset: 0x10
	public TagUnitType unitType; //Field offset: 0x14

	public static RichTextTagAttribute Default
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 100
	}

	[CallerCount(Count = 0)]
	private static RichTextTagAttribute() { }

	[CallerCount(Count = 0)]
	public static RichTextTagAttribute get_Default() { }

}

