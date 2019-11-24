using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class DoctorAssistentPost : DoctorPost
    {
        public static new string ClassName = "DoctorAssistentPost";
        public static new string TableName = "Должности ассистентов врачей";

        public DoctorAssistentPost(string name) : base(name)
        {
        }
    }
}
