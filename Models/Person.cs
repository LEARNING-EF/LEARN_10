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
		[System.ComponentModel.Browsable(false)]
		public System.Guid Id { get; set; }
		// **********

		// **********
		// دستور ذیل منسوخ شده است
		// ولی در محیط ویندوز فرم، اتفاقا دستور ذیل کار می‌کند
		[System.ComponentModel.DisplayName
			(displayName: "Age")]

		//[System.ComponentModel.DataAnnotations.Display
		//	(Name = "سن")]
		public int Age { get; set; }
		// **********

		// **********
		public string Address { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName
			(displayName: "National Code")]
		public string NationalCode { get; set; }
		// **********

		// **********
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
		// **********
		// **********
		[System.ComponentModel.Browsable(false)]
		public ComplexTypes.FullName FullName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName
			(displayName: "Full Name")]
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
