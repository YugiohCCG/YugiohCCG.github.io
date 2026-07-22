namespace Mono.Unity;

internal class X509ChainImplUnityTls : X509ChainImpl
{
	private X509ChainElementCollection elements; //Field offset: 0x10
	private unitytls_x509list* ownedList; //Field offset: 0x18
	private unitytls_x509list_ref nativeCertificateChain; //Field offset: 0x20
	private X509ChainPolicy policy; //Field offset: 0x28
	private List<X509ChainStatus> chainStatusList; //Field offset: 0x30
	private bool reverseOrder; //Field offset: 0x38

	public virtual X509ChainElementCollection ChainElements
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509ChainElementCollection), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
		[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 844
	}

	public virtual X509ChainPolicy ChainPolicy
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual bool IsValid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 40
	}

	internal unitytls_x509list_ref NativeCertificateChain
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal X509ChainImplUnityTls(unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal X509ChainImplUnityTls(unitytls_x509list* ownedList, unitytls_errorstate* errorState, bool reverseOrder = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainStatus), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void AddStatus(X509ChainStatusFlags error) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool Build(X509Certificate2 certificate) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	public virtual X509ChainElementCollection get_ChainElements() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public virtual X509ChainPolicy get_ChainPolicy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsValid() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal unitytls_x509list_ref get_NativeCertificateChain() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Reset() { }

}

