namespace System.Data;

internal sealed class Function
{
	internal static String[] s_functionName; //Field offset: 0x0
	internal readonly string _name; //Field offset: 0x10
	internal readonly FunctionId _id; //Field offset: 0x18
	internal readonly Type _result; //Field offset: 0x20
	internal readonly bool _isValidateArguments; //Field offset: 0x28
	internal readonly bool _isVariantArgumentList; //Field offset: 0x29
	internal readonly int _argumentCount; //Field offset: 0x2C
	internal readonly Type[] _parameters; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 42)]
	private static Function() { }

	[CalledBy(Type = typeof(FunctionNode), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	internal Function(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

}

