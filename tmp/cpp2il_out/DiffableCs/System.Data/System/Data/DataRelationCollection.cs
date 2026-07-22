namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
public abstract class DataRelationCollection : InternalDataCollectionBase
{
	[DefaultMember("Item")]
	public sealed class DataSetRelationCollection : DataRelationCollection
	{
		private readonly DataSet _dataSet; //Field offset: 0x38
		private readonly ArrayList _relations; //Field offset: 0x40
		private DataRelation[] _delayLoadingRelations; //Field offset: 0x48

		public virtual DataRelation Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ExceptionBuilder), Member = "RelationOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 248
		}

		public virtual DataRelation Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DataRelationCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 243
		}

		protected virtual ArrayList List
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CalledBy(Type = typeof(DataSet), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DataRelationCollection), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RelationDataSetNull", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 4)]
		internal DataSetRelationCollection(DataSet dataSet) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ForeignRelation", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RelationAlreadyExists", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ConstraintCollection), Member = "FindKeyConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(UniqueConstraint))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ForeignKeyConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConstraintCollection), Member = "FindForeignKeyConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(ForeignKeyConstraint))]
		[Calls(Type = typeof(DataTable), Member = "CacheNestedParent", ReturnType = typeof(void))]
		[Calls(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
		[Calls(Type = typeof(DataKey), Member = "GetIndexDesc", ReturnType = typeof(IndexField[]))]
		[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
		[Calls(Type = typeof(DataRelationCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
		[Calls(Type = typeof(DataKey), Member = "ColumnsEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataRelation), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataRelationCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DataRelationCollection), Member = "RegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataRelation), Member = "CheckNestedRelations", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataRelation), Member = "CheckState", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 15)]
		protected virtual void AddCore(DataRelation relation) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataRelationCollection), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public virtual void Clear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RelationOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public virtual DataRelation get_Item(int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataRelationCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public virtual DataRelation get_Item(string name) { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		protected virtual ArrayList get_List() { }

		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		protected virtual DataSet GetDataSet() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataRelation), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataKey), Member = "GetIndexDesc", ReturnType = typeof(IndexField[]))]
		[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
		[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
		[Calls(Type = typeof(DataTable), Member = "CacheNestedParent", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
		[Calls(Type = typeof(DataRelationCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
		[Calls(Type = typeof(DataRelationCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RelationDoesNotExist", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 9)]
		protected virtual void RemoveCore(DataRelation relation) { }

	}

	[DefaultMember("Item")]
	public sealed class DataTableRelationCollection : DataRelationCollection
	{
		private readonly DataTable _table; //Field offset: 0x38
		private readonly ArrayList _relations; //Field offset: 0x40
		private readonly bool _fParentCollection; //Field offset: 0x48
		[CompilerGenerated]
		private CollectionChangeEventHandler RelationPropertyChanged; //Field offset: 0x50

		internal event CollectionChangeEventHandler RelationPropertyChanged
		{
			[CalledBy(Type = typeof(DataViewListener), Member = "RegisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 2)]
			[CompilerGenerated]
			internal add { } //Length: 146
			[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 2)]
			[CompilerGenerated]
			internal remove { } //Length: 146
		}

		public virtual DataRelation Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ExceptionBuilder), Member = "RelationOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 248
		}

		public virtual DataRelation Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DataRelationCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 243
		}

		protected virtual ArrayList List
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CalledBy(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
		[CalledBy(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
		[CalledBy(Type = typeof(DataTable), Member = "DoRaiseNamespaceChange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "GetPropertyDescriptorCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DataRelationCollection), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RelationTableNull", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 4)]
		internal DataTableRelationCollection(DataTable table, bool fParentCollection) { }

		[CalledBy(Type = typeof(DataViewListener), Member = "RegisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataTable), Member = "UpdatePropertyDescriptorCollectionCache", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void AddCache(DataRelation relation) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataRelationCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "UpdatePropertyDescriptorCollectionCache", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ParentTableMismatch", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ChildTableMismatch", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		protected virtual void AddCore(DataRelation relation) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RelationTableWasRemoved", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		private void EnsureDataSet() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RelationOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public virtual DataRelation get_Item(int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataRelationCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public virtual DataRelation get_Item(string name) { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		protected virtual ArrayList get_List() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RelationTableWasRemoved", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		protected virtual DataSet GetDataSet() { }

		[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataTable), Member = "UpdatePropertyDescriptorCollectionCache", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RelationDoesNotExist", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		private void RemoveCache(DataRelation relation) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataRelationCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "UpdatePropertyDescriptorCollectionCache", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ChildTableMismatch", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ParentTableMismatch", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RelationDoesNotExist", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 7)]
		protected virtual void RemoveCore(DataRelation relation) { }

	}

	private static int s_objectTypeCount; //Field offset: 0x0
	private DataRelation _inTransition; //Field offset: 0x10
	private int _defaultNameIndex; //Field offset: 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; //Field offset: 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; //Field offset: 0x28
	private readonly int _objectID; //Field offset: 0x30

	public event CollectionChangeEventHandler CollectionChanged
	{
		[CalledBy(Type = typeof(DataViewListener), Member = "RegisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 270
		[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 270
	}

	public abstract DataRelation Item
	{
		 get { } //Length: 0
	}

	public abstract DataRelation Item
	{
		 get { } //Length: 0
	}

	internal int ObjectID
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CalledBy(Type = typeof(DataTableRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected DataRelationCollection() { }

	[CalledBy(Type = typeof(DataSet), Member = "DeserializeRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleKeyref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaKeyref)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CollectionChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeAction), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void Add(DataRelation relation) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "RegisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelation), Member = "CheckState", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRelation), Member = "CheckNamespaceValidityForNestedRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelation), Member = "ValidateMultipleNestedRelations", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_ElementColumnCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CaseLocaleMismatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RelationAlreadyInOtherDataSet", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RelationAlreadyInTheDataSet", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 10)]
	protected override void AddCore(DataRelation relation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRelationCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	internal string AssignName() { }

	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRelationCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	public override bool Contains(string name) { }

	public abstract DataRelation get_Item(int index) { }

	public abstract DataRelation get_Item(string name) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_ObjectID() { }

	protected abstract DataSet GetDataSet() { }

	[CalledBy(Type = typeof(DataTableRelationCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataRelation))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataRelation))]
	[CalledBy(Type = typeof(DataRelationCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Merger), Member = "MergeRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleKeyref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaKeyref)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	internal int InternalIndexOf(string name) { }

	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelationCollection), Member = "AssignName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataRelationCollection), Member = "RegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelationCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string MakeName(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRelationCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	internal void RegisterName(string name) { }

	[CalledBy(Type = typeof(DataTableRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelationCollection), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeAction), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void Remove(DataRelation relation) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CalledBy(Type = typeof(DataTable), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRelationCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RelationOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveAt(int index) { }

	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_ElementColumnCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RelationNotInTheDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	protected override void RemoveCore(DataRelation relation) { }

	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelationCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void UnregisterName(string name) { }

}

