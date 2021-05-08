using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGRE.TSA.DataStore.API.Models
{
    public class SSTAepLookupGross : Audit
    {
        public int Id { get; set; }

        public string estimationType { get; set; }

        public bool isProposedHubHeightFound { get; set; }

        public decimal aepNominationGross { get; set; }

        public IEnumerable<AepInputJson> aepInputFile { get; set; }

        [Required]
        public Guid AepLookupUuid { get; set; }

    }
}
