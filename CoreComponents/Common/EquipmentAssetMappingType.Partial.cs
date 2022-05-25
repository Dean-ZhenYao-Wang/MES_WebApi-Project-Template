using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Util.Model;

namespace MES.Common
{
    public partial class EquipmentAssetMappingType:Base_Entity
    {
        [Key]
        public Guid Key { get; set; }
    }
}
