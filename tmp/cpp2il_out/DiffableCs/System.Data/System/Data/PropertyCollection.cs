namespace System.Data;

public class PropertyCollection : Hashtable, ICloneable
{

	[CalledBy(Type = typeof(DataColumn), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[CalledBy(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(DataSet), Member = "SerializeDataSetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataTable), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(Constraint), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[CalledBy(Type = typeof(DataRelation), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[CalledBy(Type = typeof(DataRelation), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(DataRelation))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	public PropertyCollection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	protected PropertyCollection(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public virtual object Clone() { }

}

