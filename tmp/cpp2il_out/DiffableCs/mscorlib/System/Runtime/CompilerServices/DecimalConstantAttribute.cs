namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
public sealed class DecimalConstantAttribute : Attribute
{
	private decimal _dec; //Field offset: 0x10

	public decimal Value
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low) { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public decimal get_Value() { }

}

