namespace System.Xml.Schema;

[DefaultMember("Item")]
public class XmlSchemaObjectCollection : CollectionBase
{
	private XmlSchemaObject parent; //Field offset: 0x18

	public override XmlSchemaObject Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 169
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 115
	}

	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlSchemaObjectCollection() { }

	[CallerCount(Count = 76)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int Add(XmlSchemaObject item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Add(XmlSchemaObjectCollection collToAdd) { }

	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaObjectCollection))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneGroupBaseParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObjectCollection))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaParticle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaObjectCollection Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override XmlSchemaObject get_Item(int index) { }

	[CalledBy(Type = "System.Data.SimpleType", Member = "LoadTypeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "BuildKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint), "System.Data.DataTable"}, ReturnType = "System.Data.DataColumn[]")]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup), "System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), "System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), "System.Data.DataTable", typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), "System.Data.DataSet"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "FindDatasetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "DatasetElementCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "IsDatasetParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HasAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "CollectElementsAnnotations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnnotation), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Insert(int index, XmlSchemaObject item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnClear() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnInsert(int index, object item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnRemove(int index, object item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Remove(XmlSchemaObject item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void set_Item(int index, XmlSchemaObject value) { }

}

