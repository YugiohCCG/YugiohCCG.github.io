namespace System.Data;

internal sealed class ConstraintTable
{
	public DataTable table; //Field offset: 0x10
	public XmlSchemaIdentityConstraint constraint; //Field offset: 0x18

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ConstraintTable(DataTable t, XmlSchemaIdentityConstraint c) { }

}

