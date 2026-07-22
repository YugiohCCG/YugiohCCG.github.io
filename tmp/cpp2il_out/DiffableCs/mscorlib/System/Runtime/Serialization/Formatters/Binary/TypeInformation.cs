namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class TypeInformation
{
	private string fullTypeName; //Field offset: 0x10
	private string assemblyString; //Field offset: 0x18
	private bool hasTypeForwardedFrom; //Field offset: 0x20

	internal string AssemblyString
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string FullTypeName
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool HasTypeForwardedFrom
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal string get_AssemblyString() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal string get_FullTypeName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_HasTypeForwardedFrom() { }

}

