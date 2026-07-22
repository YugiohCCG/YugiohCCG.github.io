namespace UnityEngine.TextCore.Text;

[DefaultMember("Item")]
internal struct TextBackingContainer
{
	private UInt32[] m_Array; //Field offset: 0x0
	private int m_Count; //Field offset: 0x8

	public int Capacity
	{
		[CallerCount(Count = 24)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 25
	}

	public int Count
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public uint Item
	{
		[CallerCount(Count = 49)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
		[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 91
	}

	[CalledBy(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TextBackingContainer(int size) { }

	[CallerCount(Count = 24)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_Capacity() { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 49)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public uint get_Item(int index) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	public void Resize(int size) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_Count(int value) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_Item(int index, uint value) { }

}

