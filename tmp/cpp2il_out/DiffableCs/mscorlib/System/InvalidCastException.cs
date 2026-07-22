namespace System;

public class InvalidCastException : SystemException
{

	[CalledBy(Type = typeof(Nullable`1), Member = "UnboxExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "System.Nullable`1<T>")]
	[CalledBy(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.EnumMap", Member = "GetXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionNoT", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public InvalidCastException() { }

	[CallerCount(Count = 92)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public InvalidCastException(string message) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected InvalidCastException(SerializationInfo info, StreamingContext context) { }

}

