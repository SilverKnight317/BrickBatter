namespace cse210_batter_csharp
{
    class Student : Person
    {
        private float gpa;

        public void Set_GPA(float _grade_point_average)
        {
            gpa = _grade_point_average;
        }
        public float Get_GPA()
        {
            return gpa;
        }
        public override string Get_Full_Info()
        {
            string totalString =  base.Get_Full_Info();
            return totalString + $" GPA: {gpa}";
        }
    }
}