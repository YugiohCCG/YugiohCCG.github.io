namespace System.Runtime.Serialization;

[IsReadOnly]
public struct SerializationEntry
{
	private readonly string _name; //Field offset: 0x0
	private readonly object _value; //Field offset: 0x8
	private readonly Type _type; //Field offset: 0x10

	public string Name
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public object Value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal SerializationEntry(string entryName, object entryValue, Type entryType) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public object get_Value() { }

}

