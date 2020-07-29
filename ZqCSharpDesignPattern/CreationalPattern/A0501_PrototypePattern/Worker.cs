using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0501_PrototypePattern
{
    class Worker :ICloneable
    {
		private string name;
		private int age;
		private double score;
		private Colleague colleague = new Colleague();

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public double Score
		{
			get { return score; }
			set { score = value; }
		}

		public Colleague Colleague
		{
			get => colleague;
		}
		

		public void SetColleague(string name, string address, int times)
		{
			colleague.ColleagueName = name;
			colleague.ColleagueAddress = address;
			colleague.StudyYears = times;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"姓名：{name}，年龄：{age}，分数：{score}");
			Console.WriteLine($"学习经历：在位于{colleague.ColleagueAddress}的{colleague.ColleagueName}学校，学习{colleague.StudyYears}年。");
			Console.WriteLine();
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}
