namespace System.Runtime.Serialization;

public abstract class SerializationBinder
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected SerializationBinder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	public abstract Type BindToType(string assemblyName, string typeName) { }

}

