namespace System;

public class ArithmeticException : SystemException
{

	[CalledBy(Type = "ZXing.Common.ReedSolomon.GenericGF", Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "ZXing.PDF417.Internal.EC.ErrorCorrection", Member = "findErrorMagnitudes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.PDF417.Internal.EC.ModulusPoly", "ZXing.PDF417.Internal.EC.ModulusPoly", "System.Int32[]"}, ReturnType = "System.Int32[]")]
	[CalledBy(Type = "ZXing.PDF417.Internal.EC.ModulusGF", Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public ArithmeticException() { }

	[CalledBy(Type = "Mono.Math.BigInteger+Kernel", Member = "modInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(DivideByZeroException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DivideByZeroException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Math), Member = "Sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Math), Member = "Sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(OverflowException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Math.BigInteger+Kernel", Member = "modInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Math.BigInteger", "Mono.Math.BigInteger"}, ReturnType = "Mono.Math.BigInteger")]
	[CalledBy(Type = "Mono.Math.BigInteger", Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Math.BigInteger", "Mono.Math.BigInteger"}, ReturnType = "Mono.Math.BigInteger")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public ArithmeticException(string message) { }

	[CalledBy(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public ArithmeticException(string message, Exception innerException) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ArithmeticException(SerializationInfo info, StreamingContext context) { }

}

