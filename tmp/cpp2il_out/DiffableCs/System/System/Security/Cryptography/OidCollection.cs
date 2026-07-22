namespace System.Security.Cryptography;

[DefaultMember("Item")]
public sealed class OidCollection : ICollection, IEnumerable
{
	private readonly List<Oid> _list; //Field offset: 0x10

	public override int Count
	{
		[CalledBy(Type = typeof(OidCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 60
	}

	public override bool IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public Oid Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 81
	}

	public override object SyncRoot
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainPolicy), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OidCollection), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(AsnDecodeStatus))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public OidCollection() { }

	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OidCollection), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(AsnDecodeStatus))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int Add(Oid oid) { }

	[CalledBy(Type = typeof(OidCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override int get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Oid get_Item(int index) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public override object get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public OidEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OidCollection), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

