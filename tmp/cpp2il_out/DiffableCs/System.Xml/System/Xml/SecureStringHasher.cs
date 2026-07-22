namespace System.Xml;

internal class SecureStringHasher : IEqualityComparer<String>
{
	private sealed class HashCodeOfStringDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public HashCodeOfStringDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke(string s, int sLen, long additionalEntropy) { }

	}

	private static HashCodeOfStringDelegate hashCodeDelegate; //Field offset: 0x0
	private int hashCodeRandomizer; //Field offset: 0x10

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(string), typeof(bool), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public SecureStringHasher() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	public override bool Equals(string x, string y) { }

	[CalledBy(Type = typeof(QName), Member = "GetNSHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureStringHasher)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader+AttrInfo", Member = "GetLocalnameAndNamespaceUriAndHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureStringHasher), typeof(String&), typeof(String&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "HashCheckForDuplicateAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SecureStringHasher), Member = "GetHashCodeDelegate", ReturnType = typeof(HashCodeOfStringDelegate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override int GetHashCode(string key) { }

	[CalledBy(Type = typeof(SecureStringHasher), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

}

