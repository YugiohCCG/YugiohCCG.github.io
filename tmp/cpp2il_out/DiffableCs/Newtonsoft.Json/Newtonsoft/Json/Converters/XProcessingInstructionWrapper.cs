namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XProcessingInstructionWrapper : XObjectWrapper
{

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 117
	}

	[Nullable(1)]
	private XProcessingInstruction ProcessingInstruction
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(1)]
		private get { } //Length: 107
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 117
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 161
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	private XProcessingInstruction get_ProcessingInstruction() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void set_Value(string value) { }

}

