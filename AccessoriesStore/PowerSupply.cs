//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccessoriesStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class PowerSupply
    {
        public int ID { get; set; }
        public int ProductPSID { get; set; }
        public string PSPower { get; set; }
        public string PowerSupplyStandard { get; set; }
        public string MaxLineCurrent12V { get; set; }
        public string PFC { get; set; }
        public string PowerSupplyConnectors { get; set; }
        public string Dimensions { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
