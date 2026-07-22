namespace Spine.Unity;

public struct SubmeshInstruction
{
	public Skeleton skeleton; //Field offset: 0x0
	public int startSlot; //Field offset: 0x8
	public int endSlot; //Field offset: 0xC
	public Material material; //Field offset: 0x10
	public bool forceSeparate; //Field offset: 0x18
	public int preActiveClippingSlotSource; //Field offset: 0x1C
	public int rawTriangleCount; //Field offset: 0x20
	public int rawVertexCount; //Field offset: 0x24
	public int rawFirstVertexIndex; //Field offset: 0x28
	public bool hasClipping; //Field offset: 0x2C
	public bool hasPMAAdditiveSlot; //Field offset: 0x2D

	public int SlotCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	public int get_SlotCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 20)]
	public virtual string ToString() { }

}

