namespace System;

internal class TypeNames
{
	public abstract class ATypeName : TypeName, IEquatable<TypeName>
	{

		public abstract string DisplayName
		{
			 get { } //Length: 0
		}

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		protected ATypeName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public override bool Equals(TypeName other) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual bool Equals(object other) { }

		public abstract string get_DisplayName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

	}


}

