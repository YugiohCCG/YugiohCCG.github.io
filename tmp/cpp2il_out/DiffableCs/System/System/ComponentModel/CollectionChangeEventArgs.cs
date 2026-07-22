namespace System.ComponentModel;

public class CollectionChangeEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly CollectionChangeAction <Action>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly object <Element>k__BackingField; //Field offset: 0x18

	public override CollectionChangeAction Action
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override object Element
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "System.Data.DataColumn", Member = "set_ColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.InternalDataCollectionBase", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.ConstraintCollection", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.Constraint", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.ConstraintCollection", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.Constraint"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataColumnCollection", Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Data.DataColumn"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataColumnCollection", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataColumn"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRelationCollection", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRelation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRelationCollection", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRelation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTableCollection", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTableCollection", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable"}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CollectionChangeEventArgs(CollectionChangeAction action, object element) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override CollectionChangeAction get_Action() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override object get_Element() { }

}

