namespace Discord;

public struct LobbyTransaction
{
	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class DeleteMetadataMethod : MulticastDelegate
		{

			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public DeleteMetadataMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, string key) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetCapacityMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public SetCapacityMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, uint capacity, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, uint capacity) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetLockedMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public SetLockedMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, bool locked, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, bool locked) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetMetadataMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public SetMetadataMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, string value, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, string key, string value) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetOwnerMethod : MulticastDelegate
		{

			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public SetOwnerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long ownerId, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, long ownerId) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetTypeMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public SetTypeMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, LobbyType type, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, LobbyType type) { }

		}

		internal SetTypeMethod SetType; //Field offset: 0x0
		internal SetOwnerMethod SetOwner; //Field offset: 0x8
		internal SetCapacityMethod SetCapacity; //Field offset: 0x10
		internal SetMetadataMethod SetMetadata; //Field offset: 0x18
		internal DeleteMetadataMethod DeleteMetadata; //Field offset: 0x20
		internal SetLockedMethod SetLocked; //Field offset: 0x28

	}

	internal IntPtr MethodsPtr; //Field offset: 0x0
	internal object MethodsStructure; //Field offset: 0x8

	private FFIMethods Methods
	{
		[CalledBy(Type = typeof(LobbyTransaction), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "SetMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "DeleteMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "SetLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 275
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void DeleteMetadata(string key) { }

	[CalledBy(Type = typeof(LobbyTransaction), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "SetMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "DeleteMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "SetLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 3)]
	private FFIMethods get_Methods() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetCapacity(uint capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetLocked(bool locked) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetMetadata(string key, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetOwner(long ownerId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetType(LobbyType type) { }

}

