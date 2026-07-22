namespace System;

public class DivideByZeroException : ArithmeticException
{

	[CalledBy(Type = "System.Decimal+DecCalc", Member = "VarDecDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "BigIntegerLibrary.BigInteger", Member = "Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"BigIntegerLibrary.BigInteger", "BigIntegerLibrary.BigInteger"}, ReturnType = "BigIntegerLibrary.BigInteger")]
	[CalledBy(Type = "BigIntegerLibrary.BigInteger", Member = "Modulo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"BigIntegerLibrary.BigInteger", "BigIntegerLibrary.BigInteger"}, ReturnType = "BigIntegerLibrary.BigInteger")]
	[CalledBy(Type = "ZXing.PDF417.Internal.EC.ModulusPoly", Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.PDF417.Internal.EC.ModulusPoly"}, ReturnType = "ZXing.PDF417.Internal.EC.ModulusPoly[]")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DivideByZeroException() { }

	[CalledBy(Type = "System.Data.SqlTypes.SqlByte", Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlByte", "System.Data.SqlTypes.SqlByte"}, ReturnType = "System.Data.SqlTypes.SqlByte")]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDecimal", Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlDecimal", "System.Data.SqlTypes.SqlDecimal"}, ReturnType = "System.Data.SqlTypes.SqlDecimal")]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDecimal", Member = "DivByULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDouble", Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlDouble", "System.Data.SqlTypes.SqlDouble"}, ReturnType = "System.Data.SqlTypes.SqlDouble")]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt16", Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlInt16", "System.Data.SqlTypes.SqlInt16"}, ReturnType = "System.Data.SqlTypes.SqlInt16")]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt32", Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlInt32", "System.Data.SqlTypes.SqlInt32"}, ReturnType = "System.Data.SqlTypes.SqlInt32")]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt64", Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlInt64", "System.Data.SqlTypes.SqlInt64"}, ReturnType = "System.Data.SqlTypes.SqlInt64")]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt64", Member = "op_Modulus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlInt64", "System.Data.SqlTypes.SqlInt64"}, ReturnType = "System.Data.SqlTypes.SqlInt64")]
	[CalledBy(Type = "System.Data.SqlTypes.SqlSingle", Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlSingle", "System.Data.SqlTypes.SqlSingle"}, ReturnType = "System.Data.SqlTypes.SqlSingle")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DivideByZeroException(string message) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected DivideByZeroException(SerializationInfo info, StreamingContext context) { }

}

