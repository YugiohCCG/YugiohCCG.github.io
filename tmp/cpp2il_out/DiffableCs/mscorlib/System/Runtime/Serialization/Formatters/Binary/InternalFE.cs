namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class InternalFE
{
	internal FormatterTypeStyle FEtypeFormat; //Field offset: 0x10
	internal FormatterAssemblyStyle FEassemblyFormat; //Field offset: 0x14
	internal TypeFilterLevel FEsecurityLevel; //Field offset: 0x18
	internal InternalSerializerTypeE FEserializerTypeEnum; //Field offset: 0x1C

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public InternalFE() { }

}

