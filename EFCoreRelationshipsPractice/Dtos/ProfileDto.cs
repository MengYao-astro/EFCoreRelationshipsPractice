﻿using EFCoreRelationshipsPractice.Model;

namespace EFCoreRelationshipsPractice.Dtos
{
    public class ProfileDto
    {

        public ProfileDto()
        {
        }

        public ProfileDto(ProfileEntity profileEntity = null)
        {
            this.RegisteredCapital = profileEntity.RegisteredCapital;
            this.CertId = profileEntity.CertId;
        }

        public int RegisteredCapital { get; set; }

        public string CertId { get; set; }

        public ProfileEntity ToEntity()
        {
            return new ProfileEntity()
            {
                RegisteredCapital = this.RegisteredCapital,
                CertId = this.CertId,
            };
        }
    }
}