
namespace Stomatology
{
    class DoctorAssistent : Person
    {
        public static string ClassName = "DoctorAssistent";
        public static string TableName = "Ассистенты врачей";
        public DoctorAssistentPost Post { get; set; }

        public DoctorAssistent(string lastName, string firstName, string middleName, DoctorAssistent post) : 
           base(lastName, firstName, middleName)
        {
        }

        
    }
}
