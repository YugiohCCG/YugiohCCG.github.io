namespace UnityEngine.Rendering;

[MovedFrom("UnityEngine.Experimental.Rendering")]
public sealed class RayTracingAccelerationStructure : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	}

	internal struct BuildSettings
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private RayTracingAccelerationStructureBuildFlags <buildFlags>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private Vector3 <relativeOrigin>k__BackingField; //Field offset: 0x4

		public RayTracingAccelerationStructureBuildFlags buildFlags
		{
			[CallerCount(Count = 11)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		public Vector3 relativeOrigin
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 16
		}

		[CallerCount(Count = 0)]
		public BuildSettings() { }

		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_buildFlags(RayTracingAccelerationStructureBuildFlags value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_relativeOrigin(Vector3 value) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("RayTracingAccelerationStructure_Bindings::Destroy")]
	private static void Destroy(RayTracingAccelerationStructure accelStruct) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Destroy_Injected(IntPtr accelStruct) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Dispose(bool disposing) { }

}

