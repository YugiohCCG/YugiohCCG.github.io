namespace System.Runtime.Remoting.Messaging;

internal class CADObjRef
{
	internal ObjRef objref; //Field offset: 0x10
	internal int SourceDomain; //Field offset: 0x18
	internal Byte[] TypeInfo; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjRef), Member = "SerializeType", ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public CADObjRef(ObjRef o, int sourceDomain) { }

}

