namespace System.Xml.Serialization;

[DefaultMember("Item")]
public class XmlAnyElementAttributes : CollectionBase
{

	public XmlAnyElementAttribute Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 169
	}

	internal int Order
	{
		[CalledBy(Type = typeof(XmlAttributes), Member = "get_Order", ReturnType = typeof(System.Nullable`1<System.Int32>))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		internal get { } //Length: 400
	}

	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlAnyElementAttributes() { }

	[CalledBy(Type = typeof(XmlAttributes), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int Add(XmlAnyElementAttribute attribute) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void AddKeyHash(StringBuilder sb) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlAnyElementAttribute get_Item(int index) { }

	[CalledBy(Type = typeof(XmlAttributes), Member = "get_Order", ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal int get_Order() { }

}

