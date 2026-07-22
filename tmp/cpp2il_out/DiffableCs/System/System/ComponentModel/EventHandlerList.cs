namespace System.ComponentModel;

[DefaultMember("Item")]
public sealed class EventHandlerList
{
	private sealed class ListEntry
	{
		internal ListEntry _next; //Field offset: 0x10
		internal object _key; //Field offset: 0x18
		internal Delegate _handler; //Field offset: 0x20

	}

	private ListEntry _head; //Field offset: 0x10
	private Component _parent; //Field offset: 0x18

	public Delegate Item
	{
		[CalledBy(Type = typeof(MarshalByValueComponent), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Component), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 91
	}

	[CallerCount(Count = 0)]
	private ListEntry Find(object key) { }

	[CalledBy(Type = typeof(MarshalByValueComponent), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Component), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Delegate get_Item(object key) { }

}

