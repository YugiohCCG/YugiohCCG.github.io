namespace System.Runtime.Serialization;

internal class TypeLoadExceptionHolder
{
	private string m_typeName; //Field offset: 0x10

	internal string TypeName
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal TypeLoadExceptionHolder(string typeName) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal string get_TypeName() { }

}

