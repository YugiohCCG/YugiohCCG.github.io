namespace System.Data;

internal sealed class DataTableTypeConverter : ReferenceConverter
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	public DataTableTypeConverter() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

