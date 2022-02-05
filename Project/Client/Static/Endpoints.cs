using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string StaffEndpoint = $"{Prefix}/staff";
        public static readonly string AppointmentEndpoint = $"{Prefix}/appointment";
        public static readonly string DepartmentEndpoint = $"{Prefix}/department";
        public static readonly string DiagnosisEndpoint = $"{Prefix}/diagnosis";
        public static readonly string PatientEndpoint = $"{Prefix}/patient";
        public static readonly string PrescriptionEndpoint = $"{Prefix}/prescription";

    }
}
