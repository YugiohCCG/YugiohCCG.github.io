namespace System.Data;

internal sealed class DataError
{
	public struct ColumnError
	{
		internal DataColumn _column; //Field offset: 0x0
		internal string _error; //Field offset: 0x8

	}

	private string _rowError; //Field offset: 0x10
	private int _count; //Field offset: 0x18
	private ColumnError[] _errorList; //Field offset: 0x20

	internal bool HasErrors
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 43
	}

	internal string Text
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 35
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DataError() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal DataError(string rowError) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void Clear(DataColumn column) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasErrors() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal string get_Text() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal string GetColumnError(DataColumn column) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	internal DataColumn[] GetColumnsInError() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal int IndexOf(DataColumn column) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Text(string value) { }

	[CalledBy(Type = typeof(DataRow), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal void SetColumnError(DataColumn column, string error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void SetText(string errorText) { }

}

