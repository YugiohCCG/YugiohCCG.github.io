namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectMapInfo
{
	internal int objectId; //Field offset: 0x10
	private int numMembers; //Field offset: 0x14
	private String[] memberNames; //Field offset: 0x18
	private Type[] memberTypes; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ObjectMapInfo(int objectId, int numMembers, String[] memberNames, Type[] memberTypes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal bool isCompatible(int numMembers, String[] memberNames, Type[] memberTypes) { }

}

