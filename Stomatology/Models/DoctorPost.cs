
namespace Stomatology
{
    class DoctorPost : IPrimaryKey
    {
        public static string ClassName = "DoctorPost";
        public static string TableName = "Должности врачей";
        public int Id { get; set; }
        public string Name { get; set; }

        public DoctorPost(string name)
        {
            this.Name = name;
        }
    }
}
