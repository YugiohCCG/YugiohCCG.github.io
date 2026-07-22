namespace System.Xml.Schema;

internal class IdRefNode
{
	internal string Id; //Field offset: 0x10
	internal int LineNo; //Field offset: 0x18
	internal int LinePos; //Field offset: 0x1C
	internal IdRefNode Next; //Field offset: 0x20

	[CalledBy(Type = typeof(DtdValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal IdRefNode(IdRefNode next, string id, int lineNo, int linePos) { }

}

