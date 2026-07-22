namespace System.Resources;

internal struct ResourceLocator
{
	internal object _value; //Field offset: 0x0
	internal int _dataPos; //Field offset: 0x8

	internal int DataPosition
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal object Value
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 8
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal ResourceLocator(int dataPos, object value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool CanCache(ResourceTypeCode value) { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	internal int get_DataPosition() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	internal object get_Value() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Value(object value) { }

}

