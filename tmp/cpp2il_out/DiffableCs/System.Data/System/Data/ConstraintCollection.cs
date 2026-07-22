namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class ConstraintCollection : InternalDataCollectionBase
{
	private readonly DataTable _table; //Field offset: 0x10
	private readonly ArrayList _list; //Field offset: 0x18
	private int _defaultNameIndex; //Field offset: 0x20
	private CollectionChangeEventHandler _onCollectionChanged; //Field offset: 0x28
	private Constraint[] _delayLoadingConstraints; //Field offset: 0x30
	private bool _fLoadForeignKeyConstraintsOnly; //Field offset: 0x38

	public Constraint Item
	{
		[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
		[CalledBy(Type = typeof(DataSet), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet), Member = "ValidateCaseConstraint", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DataSet), Member = "ValidateLocaleConstraint", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DataTable), Member = "SerializeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction), typeof(bool)}, ReturnType = typeof(DataRowChangeEventArgs))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Merger), Member = "MergeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleKeyref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaKeyref)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CallerCount(Count = 29)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ConstraintOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 268
	}

	public Constraint Item
	{
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ConstraintCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 243
	}

	protected virtual ArrayList List
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal DataTable Table
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(DataTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ConstraintCollection(DataTable table) { }

	[CalledBy(Type = typeof(DataColumn), Member = "SetOrdinalInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_Unique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleKeyref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaKeyref)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	public void Add(Constraint constraint) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(Constraint))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ConstraintParentValues", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "UniqueConstraintViolation", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(UniqueConstraint), Member = "ConstraintIndexClear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ConstraintForeignTable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AddPrimaryKeyConstraint", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CantAddConstraintToMultipleNestedTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeAction), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniqueConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ConstraintCollection), Member = "RegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "FindKeyConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(UniqueConstraint))]
	[Calls(Type = typeof(UniqueConstraint), Member = "ConstraintIndexInitialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = "AutoGenerated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniqueConstraint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTreeGen), Member = "AutoGenerated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ForeignKeyConstraint), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstraintCollection), Member = "FindConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(ConstraintCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 26)]
	internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	[CalledBy(Type = typeof(XSDSchema), Member = "HandleConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniqueConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ConstraintParentValues", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniqueConstraint), Member = "ConstraintIndexInitialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ConstraintForeignTable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(UniqueConstraint), Member = "ConstraintIndexClear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "UniqueConstraintViolation", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void AddUniqueConstraint(UniqueConstraint constraint) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ArrayAdd(Constraint constraint) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ArrayRemove(Constraint constraint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConstraintCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	internal string AssignName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTreeGen), Member = "AutoGenerated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ForeignKeyConstraint), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTreeGen), Member = "AutoGenerated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniqueConstraint)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool AutoGenerated(Constraint constraint) { }

	[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "BaseGroupSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint[]), typeof(int), typeof(Constraint[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConstraintCollection), Member = "RegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void BaseAdd(Constraint constraint) { }

	[CalledBy(Type = typeof(ConstraintCollection), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConstraintCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	[CalledBy(Type = typeof(ConstraintCollection), Member = "BaseGroupSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint[]), typeof(int), typeof(Constraint[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ConstraintCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(UniqueConstraint), Member = "ConstraintIndexClear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ConstraintRemoveFailed", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	private void BaseRemove(Constraint constraint) { }

	[CalledBy(Type = typeof(DataColumn), Member = "SetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_Unique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool CanRemove(Constraint constraint, bool fThrowException) { }

	[CalledBy(Type = typeof(DataTable), Member = "ResetConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(ConstraintCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "BaseGroupSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint[]), typeof(int), typeof(Constraint[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 19)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConstraintCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	public bool Contains(string name) { }

	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConstraintCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal bool Contains(string name, bool caseSensitive) { }

	[CalledBy(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "SetupAutoGenerated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	internal Constraint FindConstraint(Constraint constraint) { }

	[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "get_ChildKey", ReturnType = typeof(DataKey))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	[CalledBy(Type = typeof(DataColumn), Member = "SetOrdinalInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "SetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal UniqueConstraint FindKeyConstraint(DataColumn column) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataSet), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "ValidateCaseConstraint", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataSet), Member = "ValidateLocaleConstraint", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "SerializeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction), typeof(bool)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Merger), Member = "MergeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleKeyref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaKeyref)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ConstraintOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public Constraint get_Item(int index) { }

	[CalledBy(Type = typeof(XSDSchema), Member = "HandleConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConstraintCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public Constraint get_Item(string name) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	protected virtual ArrayList get_List() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal DataTable get_Table() { }

	[CalledBy(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Constraint))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleKeyref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaKeyref)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	internal int InternalIndexOf(string constraintName) { }

	[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "AssignName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "RegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string MakeName(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	[CalledBy(Type = typeof(Constraint), Member = "set_ConstraintName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ConstraintCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateConstraintName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	internal void RegisterName(string name) { }

	[CalledBy(Type = typeof(DataColumn), Member = "SetOrdinalInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_Unique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ConstraintCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniqueConstraint), Member = "get_IsPrimaryKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeAction), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void Remove(Constraint constraint) { }

	[CalledBy(Type = typeof(Constraint), Member = "set_ConstraintName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConstraintCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ConstraintCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal void UnregisterName(string name) { }

}

