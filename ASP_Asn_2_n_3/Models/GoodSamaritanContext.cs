using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public class GoodSamaritanContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public GoodSamaritanContext()
            : base("name=GoodSamaritanConnection")
        {
        }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.Clients> Clients { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.AbuserRelationship> AbuserRelationships { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.Age> Ages { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.AssignedWorker> AssignedWorkers { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.Crisis> Crises { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.DuplicateFile> DuplicateFiles { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.Ethnicity> Ethnicities { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.FamilyViolenceFile> FamilyViolenceFiles { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.FiscalYear> FiscalYears { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.Incident> Incidents { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.Program> Programs { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.ReferralContact> ReferralContacts { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.ReferralSource> ReferralSources { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.RepeatClient> RepeatClients { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.RiskLevel> RiskLevels { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.RiskStatus> RiskStatus { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.Service> Services { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.StatusOfFile> StatusOfFiles { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.VictimOfIncident> VictimOfIncidents { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.Smart> Smarts { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.BadDateReport> BadDateReports { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.CityOfAssault> CityOfAssaults { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.CityOfResidence> CityOfResidences { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.DrugFacilitatedAssault> DrugFacilitatedAssaults { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.EvidenceStored> EvidenceStoreds { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.HIVMeds> HIVMeds { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.HospitalAttended> HospitalAttendeds { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.MedicalOnly> MedicalOnlies { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.MultiplePerpetrators> MultiplePerpetrators { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.PoliceAttendance> PoliceAttendances { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.PoliceReported> PoliceReporteds { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.ReferredToCBVS> ReferredToCBVS { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.ReferringHospital> ReferringHospitals { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.SexWorkExploitation> SexWorkExploitations { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.SocialWorkAttendance> SocialWorkAttendances { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.ThirdPartyReport> ThirdPartyReports { get; set; }

        public System.Data.Entity.DbSet<ASP_Asn_2_n_3.Models.VictimServicesAttendance> VictimServicesAttendances { get; set; }
    
    }
}
