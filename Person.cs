namespace cse210_batter_csharp
{
    public class Person
    {
        private string first_name;
        private string last_name;

        

        public void Set_First_Name(string _firstName)
        {
            first_name = _firstName;
        }
        public void Set_Last_Name(string _lastName)
        {
            last_name = _lastName;
        }
        public string Get_First_Name()
        {
            return first_name;
        }
        public string Get_Last_Name()
        {
            return last_name;
        }
        public virtual string Get_Full_Info()
        {
            return $"{first_name} {last_name}";
        }
    }
}