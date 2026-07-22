namespace System.Runtime.Serialization.Formatters.Binary;

[DefaultMember("Item")]
internal sealed class IntSizedArray : ICloneable
{
	internal Int32[] objects; //Field offset: 0x10
	internal Int32[] negObjects; //Field offset: 0x18

	internal int Item
	{
		[CalledBy(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 103
		[CalledBy(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(IntSizedArray), Member = "IncreaseCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 175
	}

	[CalledBy(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public IntSizedArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private IntSizedArray(IntSizedArray sizedArray) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override object Clone() { }

	[CalledBy(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal int get_Item(int index) { }

	[CalledBy(Type = typeof(IntSizedArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	internal void IncreaseCapacity(int index) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IntSizedArray), Member = "IncreaseCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void set_Item(int index, int value) { }

}

