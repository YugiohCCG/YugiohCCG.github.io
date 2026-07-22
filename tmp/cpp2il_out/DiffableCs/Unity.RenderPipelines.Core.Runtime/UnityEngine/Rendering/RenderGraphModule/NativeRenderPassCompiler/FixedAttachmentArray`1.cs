namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DefaultMember("Item")]
public struct FixedAttachmentArray
{
	public static FixedAttachmentArray<DataType> Empty; //Field offset: 0x0
	public const int MaxAttachments = 8; //Field offset: 0x0
	private DataType a0; //Field offset: 0x0
	private DataType a1; //Field offset: 0x0
	private DataType a2; //Field offset: 0x0
	private DataType a3; //Field offset: 0x0
	private DataType a4; //Field offset: 0x0
	private DataType a5; //Field offset: 0x0
	private DataType a6; //Field offset: 0x0
	private DataType a7; //Field offset: 0x0
	private int activeAttachments; //Field offset: 0x0

	public DataType Item
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public int size
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private static FixedAttachmentArray`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public FixedAttachmentArray`1(int numAttachments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public FixedAttachmentArray`1(DataType[] attachments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public FixedAttachmentArray`1(NativeArray<DataType> attachments) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int Add(in DataType data) { }

	[CalledBy(Type = typeof(NativePassData), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public DataType get_Item(int index) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_size() { }

}

