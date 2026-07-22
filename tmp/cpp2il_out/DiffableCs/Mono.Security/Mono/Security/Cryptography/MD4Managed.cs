namespace Mono.Security.Cryptography;

public class MD4Managed : MD4
{
	private UInt32[] state; //Field offset: 0x28
	private Byte[] buffer; //Field offset: 0x30
	private UInt32[] count; //Field offset: 0x38
	private UInt32[] x; //Field offset: 0x40
	private Byte[] digest; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public MD4Managed() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void Decode(UInt32[] output, Byte[] input, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void Encode(Byte[] output, UInt32[] input) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private uint F(uint x, uint y, uint z) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private uint G(uint x, uint y, uint z) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private uint H(uint x, uint y, uint z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void HashCore(Byte[] array, int ibStart, int cbSize) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual Byte[] HashFinal() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Initialize() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void MD4Transform(UInt32[] state, Byte[] block, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private Byte[] Padding(int nLength) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private uint ROL(uint x, byte n) { }

}

