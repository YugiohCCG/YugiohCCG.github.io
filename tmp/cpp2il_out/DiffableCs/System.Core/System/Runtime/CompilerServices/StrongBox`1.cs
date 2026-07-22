namespace System.Runtime.CompilerServices;

public class StrongBox : IStrongBox
{
	public T Value; //Field offset: 0x0

	private override object System.Runtime.CompilerServices.IStrongBox.Value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 40
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private set { } //Length: 103
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public StrongBox`1() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public StrongBox`1(T value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override object System.Runtime.CompilerServices.IStrongBox.get_Value() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override void System.Runtime.CompilerServices.IStrongBox.set_Value(object value) { }

}

