namespace System.Data;

internal class ConstraintEnumerator
{
	private IEnumerator _tables; //Field offset: 0x10
	private IEnumerator _constraints; //Field offset: 0x18
	private Constraint _currentObject; //Field offset: 0x20

	protected Constraint CurrentObject
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public ConstraintEnumerator(DataSet dataSet) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	protected Constraint get_CurrentObject() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Constraint GetConstraint() { }

	[CalledBy(Type = typeof(DataSet), Member = "EnableConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CascadeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RemoveRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CanBeRemovedFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstraintCollection), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public bool GetNext() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected override bool IsValidCandidate(Constraint constraint) { }

}

