namespace System.Data;

internal sealed class DataViewListener
{
	private readonly WeakReference _dvWeak; //Field offset: 0x10
	private DataTable _table; //Field offset: 0x18
	private Index _index; //Field offset: 0x20
	internal readonly int _objectID; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal DataViewListener(DataView dv) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "ChildRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterListChangedEvent", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterListChangedEvent", ReturnType = typeof(void))]
	private void CleanUp(bool updateListeners) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterListChangedEvent", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[CalledBy(Type = "System.Data.Index+<>c", Member = "<OnListChanged>b__85_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewListener), typeof(ListChangedEventArgs), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterListChangedEvent", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal void IndexListChanged(ListChangedEventArgs e) { }

	[CalledBy(Type = "System.Data.Index+<>c__DisplayClass86_0", Member = "<MaintainDataView>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewListener), typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataView), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterListChangedEvent", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "ParentRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterListChangedEvent", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[CalledBy(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "ListChangedAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewListener)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void RegisterListChangedEvent(Index index) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "RegisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterListChangedEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void RegisterListener(DataTable table) { }

	[CalledBy(Type = typeof(DataView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataViewListener), Member = "RegisterListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "add_ColumnPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "add_CollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataTableRelationCollection), Member = "add_RelationPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelationCollection), Member = "add_CollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal void RegisterMetaDataEvents(DataTable table) { }

	[CalledBy(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "ChildRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "ParentRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "ColumnCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "IndexListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "CleanUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "RegisterListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "ListChangedRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewListener)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void UnregisterListChangedEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	internal void UnregisterMetaDataEvents() { }

	[CalledBy(Type = typeof(DataView), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "ChildRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "ParentRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "ColumnCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "IndexListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "CleanUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "RegisterListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DataColumnCollection), Member = "remove_ColumnPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "remove_CollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataTableRelationCollection), Member = "remove_RelationPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelationCollection), Member = "remove_CollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UnregisterMetaDataEvents(bool updateListeners) { }

}

