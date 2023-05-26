//using Microsoft.AspNetCore.Identity;
//using System;
//using System.ComponentModel.DataAnnotations;

//namespace AuthServer.Models
//{
//    // Add profile data for application users by adding properties to the ApplicationUser class
//    public class ApplicationUser : IdentityUser
//    {
//        // Add additional profile data for application users by adding properties to this class
//        [StringLength(256)]
//        public string Name { get; set; }
//        public int Status { get; set; }
//        [StringLength(450)]
//        public string CreatedBy { get; set; }
//        public DateTime CreatedDate { get; set; }
//        [StringLength(450)]
//        public string LastModifiedBy { get; set; }
//        public DateTime? LastModifiedDate { get; set; }
//        public string OrgId { get; set; }
//    }
//}
