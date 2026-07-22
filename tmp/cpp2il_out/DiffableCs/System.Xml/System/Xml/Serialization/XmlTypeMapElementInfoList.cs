namespace System.Xml.Serialization;

internal class XmlTypeMapElementInfoList : ArrayList
{

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportListMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(XmlAttributes), typeof(int)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateMapMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlReflectionMember), typeof(string)}, ReturnType = typeof(XmlTypeMapMember))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(string), typeof(Type), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes)}, ReturnType = typeof(XmlTypeMapElementInfoList))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportAnyElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReflectionMember), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes)}, ReturnType = typeof(XmlTypeMapElementInfoList))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	public XmlTypeMapElementInfoList() { }

}

