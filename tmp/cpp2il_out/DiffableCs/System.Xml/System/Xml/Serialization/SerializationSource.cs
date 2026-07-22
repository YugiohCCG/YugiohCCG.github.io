namespace System.Xml.Serialization;

internal abstract class SerializationSource
{
	private Type[] includedTypes; //Field offset: 0x10
	private string namspace; //Field offset: 0x18
	private bool canBeGenerated; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public SerializationSource(string namspace, Type[] includedTypes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected bool BaseEquals(SerializationSource other) { }

}

