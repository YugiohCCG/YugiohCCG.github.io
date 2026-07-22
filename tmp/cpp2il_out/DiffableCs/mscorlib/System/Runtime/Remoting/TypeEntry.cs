namespace System.Runtime.Remoting;

[ComVisible(True)]
public class TypeEntry
{
	private string assembly_name; //Field offset: 0x10
	private string type_name; //Field offset: 0x18

	public string AssemblyName
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string TypeName
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected TypeEntry() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_AssemblyName() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_TypeName() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_AssemblyName(string value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_TypeName(string value) { }

}

