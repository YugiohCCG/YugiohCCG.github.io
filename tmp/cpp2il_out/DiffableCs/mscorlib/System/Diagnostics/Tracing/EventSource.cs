namespace System.Diagnostics.Tracing;

public class EventSource : IDisposable
{
	private struct EventData
	{
		[CompilerGenerated]
		private IntPtr <DataPointer>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private int <Size>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private int <Reserved>k__BackingField; //Field offset: 0xC

		public IntPtr DataPointer
		{
			[CallerCount(Count = 26)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		internal int Reserved
		{
			[CallerCount(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 4
		}

		public int Size
		{
			[CallerCount(Count = 4)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		[CallerCount(Count = 26)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_DataPointer(IntPtr value) { }

		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_Reserved(int value) { }

		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_Size(int value) { }

	}

	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10

	private string Name
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected EventSource() { }

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public EventSource(string eventSourceName) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal EventSource(Guid eventSourceGuid, string eventSourceName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool IsEnabled() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Name(string value) { }

	[CalledBy(Type = "System.ComponentModel.Design.DesignerOptionService+DesignerOptionCollection+WrappedPropertyDescriptor", Member = "get_PropertyType", ReturnType = typeof(Type))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "CriticalFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "ErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 14)]
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	protected void WriteEvent(int eventId, int arg1) { }

	[CalledBy(Type = "System.Data.DataCommonEventSource", Member = "Trace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected void WriteEvent(int eventId, string arg1) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	protected void WriteEvent(int eventId, int arg1, int arg2) { }

	[CalledBy(Type = typeof(ArrayPoolEventSource), Member = "BufferReturned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimmed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	[CalledBy(Type = "System.Data.VersionNotFoundException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataCommonEventSource", Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRelation", Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRelation", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Data.DataColumn[]", "System.Data.DataColumn[]", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRelationCollection", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRelation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRelationCollection", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRow", Member = "AcceptChanges", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRow", Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataColumn", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRow", Member = "RejectChanges", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTableCollection", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTableCollection", Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.DataTableCollection", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTableCollection", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable"}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 6)]
	protected void WriteEvent(int eventId, long arg1) { }

	[CalledBy(Type = "System.Data.DataCommonEventSource", Member = "EnterScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected void WriteEvent(int eventId, Object[] args) { }

	[CallerCount(Count = 13327)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	protected void WriteEventCore(int eventId, int eventDataCount, EventData* data) { }

}

