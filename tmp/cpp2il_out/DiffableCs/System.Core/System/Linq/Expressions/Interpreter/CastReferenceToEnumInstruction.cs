namespace System.Linq.Expressions.Interpreter;

internal sealed class CastReferenceToEnumInstruction : CastInstruction
{
	private readonly Type _t; //Field offset: 0x10

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public CastReferenceToEnumInstruction(Type t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[ContainsInvalidInstructions]
	public virtual int Run(InterpretedFrame frame) { }

}

