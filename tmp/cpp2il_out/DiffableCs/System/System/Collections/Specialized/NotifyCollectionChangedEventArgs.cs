namespace System.Collections.Specialized;

public class NotifyCollectionChangedEventArgs : EventArgs
{
	private NotifyCollectionChangedAction _action; //Field offset: 0x10
	private IList _newItems; //Field offset: 0x18
	private IList _oldItems; //Field offset: 0x20
	private int _newStartingIndex; //Field offset: 0x28
	private int _oldStartingIndex; //Field offset: 0x2C

	public NotifyCollectionChangedAction Action
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public IList NewItems
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int NewStartingIndex
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public IList OldItems
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int OldStartingIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "ClearItems", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action) { }

	[CalledBy(Type = typeof(ObservableCollection`1), Member = "OnCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Newtonsoft.Json.Linq.JToken", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "RemoveItemAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 26)]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index) { }

	[CalledBy(Type = typeof(ObservableCollection`1), Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObservableCollection`1), Member = "OnCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(object), typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "InternalPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JProperty"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JProperty", Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NotifyCollectionChangedEventArgs), Member = "InitializeMoveOrReplace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(IList), typeof(IList), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public NotifyCollectionChangedAction get_Action() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public IList get_NewItems() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_NewStartingIndex() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public IList get_OldItems() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_OldStartingIndex() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	[CalledBy(Type = typeof(NotifyCollectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(IList), typeof(IList), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

}

