using System.Linq;

namespace LEARNING_EF_CODE_FIRST
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void AddSomeNewPeopleButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.Person person = null;

				// **************************************************
				person =
					new Models.Person
					{
						Age = 20,
						NationalCode = "1111111111",
					};

				person.FullName.FirstName = " Sara   ";
				person.FullName.LastName = "        Ahmadi        ";

				databaseContext.People.Add(person);
				// **************************************************

				// **************************************************
				person =
					new Models.Person
					{
						Age = 30,
						NationalCode = "2222222222",
					};

				person.FullName.FirstName = "        Ali   ";
				person.FullName.MiddleName = "    Reza         ";
				person.FullName.LastName = "              Alavi    ";

				databaseContext.People.Add(person);
				// **************************************************

				// **************************************************
				person =
					new Models.Person
					{
						Age = 40,
						NationalCode = "3333333333",
					};

				databaseContext.People.Add(person);
				// **************************************************

				// **************************************************
				person =
					new Models.Person
					{
						Age = 50,
						NationalCode = "4444444444",
					};

				person.FullName.FirstName = "Mohammad";
				person.FullName.MiddleName = "Ali";
				person.FullName.LastName = "Javanmehr";

				databaseContext.People.Add(person);
				// **************************************************

				databaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("Done!");
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private void DisplayPeopleButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var people =
					databaseContext.People
					.OrderBy(current => current.FullName.FirstName)
					.ThenBy(current => current.FullName.MiddleName)
					.ThenBy(current => current.FullName.LastName)
					.ToList()
					;

				peopleListBox.ValueMember = nameof(Models.Person.Id);
				peopleListBox.DisplayMember = nameof(Models.Person.DisplayFullName);
				peopleListBox.DataSource = people;

				peopleDataGridView.DataSource = people;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}
	}
}
