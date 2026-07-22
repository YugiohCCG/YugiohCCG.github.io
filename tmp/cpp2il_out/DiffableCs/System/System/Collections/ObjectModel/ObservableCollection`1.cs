namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
public class ObservableCollection : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged
{
	private sealed class SimpleMonitor : IDisposable
	{
		internal int _busyCount; //Field offset: 0x0
		internal ObservableCollection<T> _collection; //Field offset: 0x0

		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public SimpleMonitor(ObservableCollection<T> collection) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Dispose() { }

	}

	private SimpleMonitor<T> _monitor; //Field offset: 0x0
	private int _blockReentrancyCount; //Field offset: 0x0
	[CompilerGenerated]
	private NotifyCollectionChangedEventHandler CollectionChanged; //Field offset: 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x0

	public override event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	[CalledBy(Type = "Game.ClientField", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Duel", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard", Member = "Initialization", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ObservableCollection`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected void CheckReentrancy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collection`1), Member = "ClearItems", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected virtual void ClearItems() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private SimpleMonitor<T> EnsureMonitorInitialized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collection`1), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected virtual void InsertItem(int index, T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotifyCollectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(object), typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnCollectionChanged(NotifyCollectionChangedAction action, object oldItem, object newItem, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotifyCollectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnCollectionReset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnCountPropertyChanged() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnIndexerPropertyChanged() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected override void OnPropertyChanged(PropertyChangedEventArgs e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[OnSerializing]
	private void OnSerializing(StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected virtual void RemoveItem(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collection`1), Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotifyCollectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(object), typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected virtual void SetItem(int index, T item) { }

}

