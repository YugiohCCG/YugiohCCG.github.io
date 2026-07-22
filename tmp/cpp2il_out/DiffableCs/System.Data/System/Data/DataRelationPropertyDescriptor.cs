namespace System.Data;

internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor
{
	[CompilerGenerated]
	private readonly DataRelation <Relation>k__BackingField; //Field offset: 0x88

	public virtual Type ComponentType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		 get { } //Length: 77
	}

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Type PropertyType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		 get { } //Length: 77
	}

	internal DataRelation Relation
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	[CalledBy(Type = typeof(DataTable), Member = "GetPropertyDescriptorCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(DataView), Member = "ChildRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "ParentRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal DataRelationPropertyDescriptor(DataRelation dataRelation) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool CanResetValue(object component) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public virtual Type get_ComponentType() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public virtual Type get_PropertyType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal DataRelation get_Relation() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRowView), Member = "CreateChildView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(bool)}, ReturnType = typeof(DataView))]
	[CallsUnknownMethods(Count = 2)]
	public virtual object GetValue(object component) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void ResetValue(object component) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetValue(object component, object value) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool ShouldSerializeValue(object component) { }

}

