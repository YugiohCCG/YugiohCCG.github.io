namespace Spine.Unity;

public static class SkeletonDataCompatibility
{
	internal class CompatibilityProblemInfo
	{
		public VersionInfo actualVersion; //Field offset: 0x10
		public Int32[][] compatibleVersions; //Field offset: 0x18
		public string explicitProblemDescription; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CompatibilityProblemInfo() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 21)]
		public string DescriptionString() { }

	}

	internal enum SourceType
	{
		Json = 0,
		Binary = 1,
	}

	internal class VersionInfo
	{
		public string rawVersion; //Field offset: 0x10
		public Int32[] version; //Field offset: 0x18
		public SourceType sourceType; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public VersionInfo() { }

	}


}

