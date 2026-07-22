namespace System.Xml;

[DefaultMember("ItemOf")]
public abstract class XmlNodeList : IEnumerable, IDisposable
{

	public abstract int Count
	{
		 get { } //Length: 0
	}

	public override XmlNode ItemOf
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XmlNodeList() { }

	public abstract int get_Count() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override XmlNode get_ItemOf(int i) { }

	public abstract IEnumerator GetEnumerator() { }

	public abstract XmlNode Item(int index) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void PrivateDisposeNodeList() { }

	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.IDisposable.Dispose() { }

}

