namespace Newtonsoft.Json;

[AttributeUsage(3484, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(1)]
public sealed class JsonConverterAttribute : Attribute
{
	private readonly Type _converterType; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private readonly Object[] <ConverterParameters>k__BackingField; //Field offset: 0x18

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Object[] ConverterParameters
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Type ConverterType
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public JsonConverterAttribute(Type converterType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public JsonConverterAttribute(Type converterType, Object[] converterParameters) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Object[] get_ConverterParameters() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Type get_ConverterType() { }

}

