namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
public class SinkProviderData
{
	private string sinkName; //Field offset: 0x10
	private ArrayList children; //Field offset: 0x18
	private Hashtable properties; //Field offset: 0x20

	public IList Children
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public IDictionary Properties
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadCustomProviderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList), typeof(bool)}, ReturnType = typeof(ProviderData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public SinkProviderData(string name) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public IList get_Children() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public IDictionary get_Properties() { }

}

