namespace System.IO;

public class EndOfStreamException : IOException
{

	[CalledBy(Type = "Spine.SkeletonBinary+SkeletonInput", Member = "ReadSByte", ReturnType = typeof(sbyte))]
	[CalledBy(Type = "Spine.SkeletonBinary+SkeletonInput", Member = "ReadFully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.SkeletonBinary+SkeletonInput", Member = "GetVersionStringOld3X", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public EndOfStreamException() { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.Internal.Extensions", Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[CalledBy(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "NGettext.Loaders.BigEndianBinaryReader", Member = "_FillBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public EndOfStreamException(string message) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected EndOfStreamException(SerializationInfo info, StreamingContext context) { }

}

