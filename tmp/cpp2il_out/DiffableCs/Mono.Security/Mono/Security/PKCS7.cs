namespace Mono.Security;

public sealed class PKCS7
{
	internal class ContentInfo
	{
		private string contentType; //Field offset: 0x10
		private ASN1 content; //Field offset: 0x18

		public ASN1 ASN1
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ContentInfo), Member = "GetASN1", ReturnType = typeof(ASN1))]
			 get { } //Length: 7
		}

		public ASN1 Content
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public string ContentType
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CalledBy(Type = typeof(ContentInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EncryptedData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "CertificateSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CalledBy(Type = typeof(PKCS12), Member = "EncryptedContentInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1), typeof(string)}, ReturnType = typeof(ContentInfo))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public ContentInfo() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContentInfo), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ContentInfo(string oid) { }

		[CalledBy(Type = typeof(PKCS12), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
		[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "RemoveCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[ContainsInvalidInstructions]
		public ContentInfo(Byte[] data) { }

		[CalledBy(Type = typeof(SignedData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 15)]
		public ContentInfo(ASN1 asn1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContentInfo), Member = "GetASN1", ReturnType = typeof(ASN1))]
		public ASN1 get_ASN1() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public ASN1 get_Content() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public string get_ContentType() { }

		[CalledBy(Type = typeof(ContentInfo), Member = "get_ASN1", ReturnType = typeof(ASN1))]
		[CalledBy(Type = typeof(PKCS12), Member = "CertificateSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		internal ASN1 GetASN1() { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_Content(ASN1 value) { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_ContentType(string value) { }

	}

	internal class EncryptedData
	{
		private byte _version; //Field offset: 0x10
		private ContentInfo _content; //Field offset: 0x18
		private ContentInfo _encryptionAlgorithm; //Field offset: 0x20
		private Byte[] _encrypted; //Field offset: 0x28

		public Byte[] EncryptedContent
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 123
		}

		public ContentInfo EncryptionAlgorithm
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public EncryptedData() { }

		[CalledBy(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ContentInfo), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 32)]
		public EncryptedData(ASN1 asn1) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public Byte[] get_EncryptedContent() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public ContentInfo get_EncryptionAlgorithm() { }

	}

	internal class SignedData
	{
		private byte version; //Field offset: 0x10
		private string hashAlgorithm; //Field offset: 0x18
		private ContentInfo contentInfo; //Field offset: 0x20
		private X509CertificateCollection certs; //Field offset: 0x28
		private ArrayList crls; //Field offset: 0x30
		private SignerInfo signerInfo; //Field offset: 0x38
		private bool mda; //Field offset: 0x40

		public X509CertificateCollection Certificates
		{
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public ContentInfo ContentInfo
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string HashName
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			 set { } //Length: 69
		}

		public SignerInfo SignerInfo
		{
			[CallerCount(Count = 38)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ContentInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(SignerInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 22)]
		[ContainsUnimplementedInstructions]
		public SignedData(ASN1 asn1) { }

		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		public X509CertificateCollection get_Certificates() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public ContentInfo get_ContentInfo() { }

		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		public SignerInfo get_SignerInfo() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 6)]
		internal string OidToName(string oid) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public void set_HashName(string value) { }

	}

	internal class SignerInfo
	{
		private byte version; //Field offset: 0x10
		private string hashAlgorithm; //Field offset: 0x18
		private ArrayList authenticatedAttributes; //Field offset: 0x20
		private ArrayList unauthenticatedAttributes; //Field offset: 0x28
		private Byte[] signature; //Field offset: 0x30
		private string issuer; //Field offset: 0x38
		private Byte[] serial; //Field offset: 0x40
		private Byte[] ski; //Field offset: 0x48

		public ArrayList AuthenticatedAttributes
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string HashName
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public string IssuerName
		{
			[CallerCount(Count = 38)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public Byte[] SerialNumber
		{
			[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 123
		}

		public Byte[] Signature
		{
			[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 123
		}

		public ArrayList UnauthenticatedAttributes
		{
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public byte Version
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CalledBy(Type = typeof(SignerInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public SignerInfo() { }

		[CalledBy(Type = typeof(SignedData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SignerInfo), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X501), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 14)]
		public SignerInfo(ASN1 asn1) { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public ArrayList get_AuthenticatedAttributes() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public string get_HashName() { }

		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		public string get_IssuerName() { }

		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public Byte[] get_SerialNumber() { }

		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public Byte[] get_Signature() { }

		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		public ArrayList get_UnauthenticatedAttributes() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public byte get_Version() { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_HashName(string value) { }

	}


}

