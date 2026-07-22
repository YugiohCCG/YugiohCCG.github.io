namespace System.ComponentModel;

[DefaultMember("Item")]
public class ComponentCollection : ReadOnlyCollectionBase
{

	public override IComponent Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 20)]
		 get { } //Length: 606
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 20)]
	public override IComponent get_Item(string name) { }

}

