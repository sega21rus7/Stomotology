using System.Collections.Generic;

namespace Stomatology
{
    static class TableAttrs
    {
        public static Dictionary<string, string> Attrs = new Dictionary<string, string>{
            {Address.TableName, Address.ClassName},
            {Doctor.TableName, Doctor.ClassName},
            {DoctorAssistent.TableName, DoctorAssistent.ClassName},
            {DoctorAssistentPost.TableName, DoctorAssistentPost.ClassName},
            {DoctorPost.TableName, DoctorPost.ClassName},
            {Patient.TableName, Patient.ClassName},
            {PatientInsurancePolicy.TableName, PatientInsurancePolicy.ClassName},
            {PatientPassport.TableName, PatientPassport.ClassName},
            {Service.TableName, Service.ClassName},
            {ServiceType.TableName, ServiceType.ClassName},
            {Visit.TableName, Visit.ClassName},
        };
    }
}
