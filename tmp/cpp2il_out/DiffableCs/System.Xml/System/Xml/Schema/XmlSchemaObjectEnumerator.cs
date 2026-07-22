namespace System.Xml.Schema;

public class XmlSchemaObjectEnumerator : IEnumerator
{
	private IEnumerator enumerator; //Field offset: 0x10

	public XmlSchemaObject Current
	{
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
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 149
	}

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 73
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal XmlSchemaObjectEnumerator(IEnumerator enumerator) { }

	[CalledBy(Type = "System.Data.SimpleType", Member = "LoadTypeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnnotation), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "CollectElementsAnnotations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HasAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "IsDatasetParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "DatasetElementCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "FindDatasetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), "System.Data.DataSet"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), "System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup), "System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "BuildKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint), "System.Data.DataTable"}, ReturnType = "System.Data.DataColumn[]")]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), "System.Data.DataTable", typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 3)]
	public XmlSchemaObject get_Current() { }

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
	[CallsUnknownMethods(Count = 2)]
	public bool MoveNext() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override object System.Collections.IEnumerator.get_Current() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Collections.IEnumerator.Reset() { }

}

