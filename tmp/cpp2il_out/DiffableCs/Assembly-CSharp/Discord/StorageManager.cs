namespace Discord;

public class StorageManager
{
	public struct FFIEvents
	{

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class CountMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public CountMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(ref int count, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class DeleteMethod : MulticastDelegate
		{

			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public DeleteMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, string name) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ExistsMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public ExistsMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ref bool exists, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(ref bool exists, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, string name, ref bool exists) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetPathMethod : MulticastDelegate
		{

			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetPathMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder path, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, StringBuilder path) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ReadAsyncCallback : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public ReadAsyncCallback(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ReadAsyncMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public ReadAsyncMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, IntPtr callbackData, ReadAsyncCallback callback, AsyncCallback __callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr methodsPtr, string name, IntPtr callbackData, ReadAsyncCallback callback) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ReadAsyncPartialCallback : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public ReadAsyncPartialCallback(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ReadAsyncPartialMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public ReadAsyncPartialMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, ReadAsyncPartialCallback callback, AsyncCallback __callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, ReadAsyncPartialCallback callback) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ReadMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public ReadMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, ref uint read, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(ref uint read, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, ref uint read) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class StatAtMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public StatAtMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref FileStat stat, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(ref FileStat stat, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, int index, ref FileStat stat) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class StatMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public StatMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ref FileStat stat, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(ref FileStat stat, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, string name, ref FileStat stat) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class WriteAsyncCallback : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public WriteAsyncCallback(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class WriteAsyncMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public WriteAsyncMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, IntPtr callbackData, WriteAsyncCallback callback, AsyncCallback __callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, IntPtr callbackData, WriteAsyncCallback callback) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class WriteMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			public WriteMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen) { }

		}

		internal ReadMethod Read; //Field offset: 0x0
		internal ReadAsyncMethod ReadAsync; //Field offset: 0x8
		internal ReadAsyncPartialMethod ReadAsyncPartial; //Field offset: 0x10
		internal WriteMethod Write; //Field offset: 0x18
		internal WriteAsyncMethod WriteAsync; //Field offset: 0x20
		internal DeleteMethod Delete; //Field offset: 0x28
		internal ExistsMethod Exists; //Field offset: 0x30
		internal CountMethod Count; //Field offset: 0x38
		internal StatMethod Stat; //Field offset: 0x40
		internal StatAtMethod StatAt; //Field offset: 0x48
		internal GetPathMethod GetPath; //Field offset: 0x50

	}

	internal sealed class ReadAsyncHandler : MulticastDelegate
	{

		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public ReadAsyncHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(Result result, Byte[] data, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Result result, Byte[] data) { }

	}

	internal sealed class ReadAsyncPartialHandler : MulticastDelegate
	{

		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public ReadAsyncPartialHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(Result result, Byte[] data, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Result result, Byte[] data) { }

	}

	internal sealed class WriteAsyncHandler : MulticastDelegate
	{

		[CallerCount(Count = 79)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public WriteAsyncHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Result result) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18

	private FFIMethods Methods
	{
		[CalledBy(Type = typeof(StorageManager), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(StorageManager), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ReadAsyncHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StorageManager), Member = "ReadAsyncPartial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong), typeof(ulong), typeof(ReadAsyncPartialHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StorageManager), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StorageManager), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(WriteAsyncHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StorageManager), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StorageManager), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StorageManager), Member = "Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(StorageManager), Member = "Stat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStat))]
		[CalledBy(Type = typeof(StorageManager), Member = "StatAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FileStat))]
		[CalledBy(Type = typeof(StorageManager), Member = "GetPath", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(StorageManager), Member = "Files", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Discord.FileStat>))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 302
	}

	[CalledBy(Type = typeof(Discord), Member = "GetStorageManager", ReturnType = typeof(StorageManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal StorageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Delete(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool Exists(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public IEnumerable<FileStat> Files() { }

	[CalledBy(Type = typeof(StorageManager), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(StorageManager), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ReadAsyncHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StorageManager), Member = "ReadAsyncPartial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong), typeof(ulong), typeof(ReadAsyncPartialHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StorageManager), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StorageManager), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(WriteAsyncHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StorageManager), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StorageManager), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StorageManager), Member = "Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StorageManager), Member = "Stat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStat))]
	[CalledBy(Type = typeof(StorageManager), Member = "StatAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FileStat))]
	[CalledBy(Type = typeof(StorageManager), Member = "GetPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StorageManager), Member = "Files", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Discord.FileStat>))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 3)]
	private FFIMethods get_Methods() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public string GetPath() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public uint Read(string name, Byte[] data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void ReadAsync(string name, ReadAsyncHandler callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[MonoPInvokeCallback]
	private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void ReadAsyncPartial(string name, ulong offset, ulong length, ReadAsyncPartialHandler callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[MonoPInvokeCallback]
	private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public FileStat Stat(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public FileStat StatAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void Write(string name, Byte[] data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void WriteAsync(string name, Byte[] data, WriteAsyncHandler callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[MonoPInvokeCallback]
	private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result) { }

}

