namespace UnityEngine.Bindings;

[VisibleToOtherModules]
internal struct Unmarshal
{

	[CallerCount(Count = 0)]
	public static GCHandle FromIntPtrUnsafe(IntPtr gcHandle) { }

	[CallerCount(Count = 95)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T UnmarshalUnityObject(IntPtr gcHandlePtr) { }

}

