namespace ZXing.Common.ReedSolomon;

public sealed class ReedSolomonEncoder
{
	private readonly GenericGF field; //Field offset: 0x10
	private readonly IList<GenericGFPoly> cachedGenerators; //Field offset: 0x18

	[CalledBy(Type = typeof(Encoder), Member = "generateCheckWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(Encoder), Member = "interleaveWithECBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(Encoder), Member = "generateECBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public ReedSolomonEncoder(GenericGF field) { }

	[CalledBy(Type = typeof(ReedSolomonEncoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericGF), Member = "exp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGFPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private GenericGFPoly buildGenerator(int degree) { }

	[CalledBy(Type = typeof(Encoder), Member = "generateCheckWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(Encoder), Member = "interleaveWithECBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(Encoder), Member = "generateECBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReedSolomonEncoder), Member = "buildGenerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGFPoly), Member = "multiplyByMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[Calls(Type = typeof(GenericGFPoly), Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly[]))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void encode(Int32[] toEncode, int ecBytes) { }

}

