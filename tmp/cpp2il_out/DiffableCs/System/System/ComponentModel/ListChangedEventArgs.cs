namespace System.ComponentModel;

public class ListChangedEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly ListChangedType <ListChangedType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <NewIndex>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly int <OldIndex>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField; //Field offset: 0x20

	public ListChangedType ListChangedType
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int NewIndex
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int OldIndex
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Newtonsoft.Json.Linq.JToken", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "RemoveItemAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "ClearItems", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "InternalPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JProperty"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JProperty", Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataView", Member = "AddNew", ReturnType = "System.Data.DataRowView")]
	[CalledBy(Type = "System.Data.DataView", Member = "FinishAddNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataView", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Index", Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex) { }

	[CalledBy(Type = "System.Data.DataView", Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	[CalledBy(Type = "System.Data.DataView", Member = "ChildRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataView", Member = "ParentRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataView", Member = "ColumnCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	[CalledBy(Type = "System.Data.DataView", Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), "System.Data.DataRow", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Index", Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ListChangedType get_ListChangedType() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_NewIndex() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_OldIndex() { }

}

