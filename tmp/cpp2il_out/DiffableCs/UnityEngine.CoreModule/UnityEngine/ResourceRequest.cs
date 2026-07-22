namespace UnityEngine;

[RequiredByNativeCode]
public class ResourceRequest : AsyncOperation
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public static ResourceRequest ConvertToManaged(IntPtr ptr) { }

	}

	internal string m_Path; //Field offset: 0x20
	internal Type m_Type; //Field offset: 0x28

	public object asset
	{
		[CallerCount(Count = 51)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected ResourceRequest(IntPtr ptr) { }

	[CallerCount(Count = 51)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public object get_asset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	protected override object GetResult() { }

}

