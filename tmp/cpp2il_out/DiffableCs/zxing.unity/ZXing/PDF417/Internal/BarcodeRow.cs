namespace ZXing.PDF417.Internal;

[DefaultMember("Item")]
internal sealed class BarcodeRow
{
	private readonly SByte[] row; //Field offset: 0x10
	private int currentLocation; //Field offset: 0x18

	internal sbyte Item
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 44
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal set { } //Length: 43
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal BarcodeRow(int width) { }

	[CalledBy(Type = typeof(PDF417), Member = "encodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BarcodeRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PDF417), Member = "encodeLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(BarcodeMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	internal void addBar(bool black, int width) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal sbyte get_Item(int x) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal SByte[] getScaledRow(int scale) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal void set(int x, bool black) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal void set_Item(int x, sbyte value) { }

}

