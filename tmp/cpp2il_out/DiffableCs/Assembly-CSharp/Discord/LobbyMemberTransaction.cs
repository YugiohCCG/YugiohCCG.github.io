namespace Discord;

public struct LobbyMemberTransaction
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

		internal SetMetadataMethod SetMetadata; //Field offset: 0x0
		internal DeleteMetadataMethod DeleteMetadata; //Field offset: 0x8

	}

	internal IntPtr MethodsPtr; //Field offset: 0x0
	internal object MethodsStructure; //Field offset: 0x8

	private FFIMethods Methods
	{
		[CalledBy(Type = typeof(LobbyMemberTransaction), Member = "SetMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyMemberTransaction), Member = "DeleteMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 259
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyMemberTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void DeleteMetadata(string key) { }

	[CalledBy(Type = typeof(LobbyMemberTransaction), Member = "SetMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyMemberTransaction), Member = "DeleteMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 3)]
	private FFIMethods get_Methods() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyMemberTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetMetadata(string key, string value) { }

}

