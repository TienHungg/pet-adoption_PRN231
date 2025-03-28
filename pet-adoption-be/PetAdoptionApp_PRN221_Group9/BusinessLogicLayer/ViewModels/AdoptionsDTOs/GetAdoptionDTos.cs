﻿using BusinessObjects.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ViewModels.AdoptionsDTOs
{
    public class GetAdoptionDTos
    {
        public Guid? Id {  get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public AdoptionStatus AdoptionStatus { get; set; }
        public string? AdoptionReason { get; set; }
        public string? PetExperience { get; set; }
        public string? PetName { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? Notes { get; set; }
        public string? UserEmail { get; set; }

        //ShowUser, Show Pet
        public Guid? UserId { get; set; }
        public Guid? PetId {  get; set; }

    }
}
