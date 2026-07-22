namespace Internal.Cryptography.Pal;

internal struct CertificateData
{
	[CompilerGenerated]
	private sealed class <ReadReverseRdns>d__21 : IEnumerable<KeyValuePair`2<String, String>>, IEnumerable, IEnumerator<KeyValuePair`2<String, String>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private KeyValuePair<String, String> <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		private X500DistinguishedName name; //Field offset: 0x30
		public X500DistinguishedName <>3__name; //Field offset: 0x38
		private Stack<DerSequenceReader> <rdnReaders>5__2; //Field offset: 0x40
		private DerSequenceReader <rdnReader>5__3; //Field offset: 0x48

		private override KeyValuePair<String, String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			private get { } //Length: 69
		}

		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <ReadReverseRdns>d__21(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DerSequenceReader), Member = "get_HasData", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadSet", ReturnType = typeof(DerSequenceReader))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadBMPString", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadT61String", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadPrintableString", ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<KeyValuePair`2<String, String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override KeyValuePair<String, String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	public struct AlgorithmIdentifier
	{
		internal string AlgorithmId; //Field offset: 0x0
		internal Byte[] Parameters; //Field offset: 0x8

	}

	internal Byte[] RawData; //Field offset: 0x0
	internal Byte[] SubjectPublicKeyInfo; //Field offset: 0x8
	internal int Version; //Field offset: 0x10
	internal Byte[] SerialNumber; //Field offset: 0x18
	internal AlgorithmIdentifier TbsSignature; //Field offset: 0x20
	internal X500DistinguishedName Issuer; //Field offset: 0x30
	internal DateTime NotBefore; //Field offset: 0x38
	internal DateTime NotAfter; //Field offset: 0x40
	internal X500DistinguishedName Subject; //Field offset: 0x48
	internal AlgorithmIdentifier PublicKeyAlgorithm; //Field offset: 0x50
	internal Byte[] PublicKey; //Field offset: 0x60
	internal Byte[] IssuerUniqueId; //Field offset: 0x68
	internal Byte[] SubjectUniqueId; //Field offset: 0x70
	internal List<X509Extension> Extensions; //Field offset: 0x78
	internal AlgorithmIdentifier SignatureAlgorithm; //Field offset: 0x80
	internal Byte[] SignatureValue; //Field offset: 0x90

	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadOctetString", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadBoolean", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadBitString", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadX509Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(X500DistinguishedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadNextEncodedValue", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerSequenceReader), Member = "get_HasData", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadIntegerBytes", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadInteger", ReturnType = typeof(int))]
	[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
	[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 60)]
	internal CertificateData(Byte[] rawData) { }

	[CalledBy(Type = typeof(CertificateData), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "get_HasData", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
	[Calls(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static string FindAltNameMatch(Byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CertificateData), Member = "GetSimpleNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedName)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CertificateData), Member = "ReadReverseRdns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedName)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String, System.String>>))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[CalledBy(Type = typeof(CertificateData), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CertificateData), Member = "ReadReverseRdns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedName)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String, System.String>>))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	[CalledBy(Type = typeof(CertificateData), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CertificateData), Member = "GetSimpleNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedName)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ReadReverseRdns>d__21))]
	private static IEnumerable<KeyValuePair`2<String, String>> ReadReverseRdns(X500DistinguishedName name) { }

}

