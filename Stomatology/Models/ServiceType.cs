
namespace Stomatology
{
    class ServiceType : IPrimaryKey
    {
        public static string ClassName = "ServiceType";
        public static string TableName = "Типы услуг";
        public int Id { get; set; }
        public string Name { get; set; }

        public ServiceType(string name)
        {
            this.Name = name;
        }
    }
}
