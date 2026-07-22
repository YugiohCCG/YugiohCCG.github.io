namespace BigIntegerLibrary;

public sealed class BigIntegerException : Exception
{

	[CalledBy(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigInteger), Member = "Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Modulo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "IntegerSqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Gcd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "ExtendedEuclidGcd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger&), typeof(BigInteger&)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "ModularInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "ModularExponentiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public BigIntegerException(string message, Exception innerException) { }

}

