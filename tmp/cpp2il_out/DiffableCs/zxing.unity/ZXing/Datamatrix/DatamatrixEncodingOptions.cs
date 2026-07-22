namespace ZXing.Datamatrix;

public class DatamatrixEncodingOptions : EncodingOptions
{

	public Nullable<Int32> DefaultEncodation
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 221
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 252
	}

	public Dimension MaxSize
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 158
	}

	public Dimension MinSize
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 158
	}

	public Nullable<SymbolShapeHint> SymbolShape
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 233
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 252
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public DatamatrixEncodingOptions() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public Nullable<Int32> get_DefaultEncodation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public Dimension get_MaxSize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public Dimension get_MinSize() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public Nullable<SymbolShapeHint> get_SymbolShape() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void set_DefaultEncodation(Nullable<Int32> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void set_MaxSize(Dimension value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void set_MinSize(Dimension value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void set_SymbolShape(Nullable<SymbolShapeHint> value) { }

}

