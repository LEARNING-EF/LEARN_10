namespace Models
{
	public class Person : object
	{
		public Person() : base()
		{
			Id = System.Guid.NewGuid();

			// Note: Complex types should be created in the constructor!
			FullName = new ComplexTypes.FullName();
		}

		// **********
		public System.Guid Id { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DisplayName
		//	(displayName: "سن")]

		[System.ComponentModel.DataAnnotations.Display
			(Name = "سن")]
		public int Age { get; set; }
		// **********

		// **********
		public string Address { get; set; }
		// **********

		// **********
		public string NationalCode { get; set; }
		// **********

		// **********
		//public string FirstName { get; set; }
		// **********

		// **********
		//public string MiddleName { get; set; }
		// **********

		// **********
		//public string LastName { get; set; }
		// **********

		// **********
		// **********
		// **********
		public ComplexTypes.FullName FullName { get; set; }
		// **********

		// **********
		public string DisplayFullName
		{
			get
			{
				string result = FullName.ToString();

				if (result == string.Empty)
				{
					result = "Undefined!";
				}

				return result;
			}
		}
		// **********
		// **********
		// **********
	}
}
