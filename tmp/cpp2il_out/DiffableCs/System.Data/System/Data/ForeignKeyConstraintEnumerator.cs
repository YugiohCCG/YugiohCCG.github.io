namespace System.Data;

internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator
{

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public ForeignKeyConstraintEnumerator(DataSet dataSet) { }

	[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CascadeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RemoveRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CanBeRemovedFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstraintCollection), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public ForeignKeyConstraint GetForeignKeyConstraint() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	protected virtual bool IsValidCandidate(Constraint constraint) { }

}

