using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest22
{
    public class Student
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public bool Attendance { get; set; }

		public Student(string name, bool attendance )
		{
			_name = name;
			Attendance = attendance;
		}


		public override string ToString()
		{
			return $"Navn {_name}  attendance {Attendance}";
		}

	}
}
