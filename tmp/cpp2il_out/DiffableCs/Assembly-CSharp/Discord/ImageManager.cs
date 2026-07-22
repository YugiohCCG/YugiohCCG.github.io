namespace Discord;

public class ImageManager
{
	internal sealed class FetchHandler : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public FetchHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(Result result, ImageHandle handleResult, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Result result, ImageHandle handleResult) { }

	}

	public struct FFIEvents
	{

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchCallback : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			public FetchCallback(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, ImageHandle handleResult, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public override void Invoke(IntPtr ptr, Result result, ImageHandle handleResult) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			public FetchMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, FetchCallback callback, AsyncCallback __callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, FetchCallback callback) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetDataMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			public GetDataMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, Byte[] data, int dataLen, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public override Result Invoke(IntPtr methodsPtr, ImageHandle handle, Byte[] data, int dataLen) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetDimensionsMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			public GetDimensionsMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(ref ImageDimensions dimensions, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public override Result Invoke(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions) { }

		}

		internal FetchMethod Fetch; //Field offset: 0x0
		internal GetDimensionsMethod GetDimensions; //Field offset: 0x8
		internal GetDataMethod GetData; //Field offset: 0x10

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18

	private FFIMethods Methods
	{
		[CalledBy(Type = typeof(ImageManager), Member = "Fetch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(bool), typeof(FetchHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ImageManager), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(ImageDimensions))]
		[CalledBy(Type = typeof(ImageManager), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ImageManager), Member = "Fetch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(FetchHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ImageManager), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(ImageManager), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Texture2D))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 270
	}

	[CalledBy(Type = typeof(Discord), Member = "GetImageManager", ReturnType = typeof(ImageManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal ImageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Fetch(ImageHandle handle, bool refresh, FetchHandler callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Fetch(ImageHandle handle, FetchHandler callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[MonoPInvokeCallback]
	private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult) { }

	[CalledBy(Type = typeof(ImageManager), Member = "Fetch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(bool), typeof(FetchHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ImageManager), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(ImageDimensions))]
	[CalledBy(Type = typeof(ImageManager), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ImageManager), Member = "Fetch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(FetchHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ImageManager), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ImageManager), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 3)]
	private FFIMethods get_Methods() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void GetData(ImageHandle handle, Byte[] data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImageManager), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(ImageDimensions))]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Byte[] GetData(ImageHandle handle) { }

	[CalledBy(Type = typeof(ImageManager), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ImageManager), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public ImageDimensions GetDimensions(ImageHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImageManager), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(ImageDimensions))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(Texture2D), Member = "LoadRawTextureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Texture2D GetTexture(ImageHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

}

