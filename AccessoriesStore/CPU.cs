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
    
    public partial class CPU
    {
        public int ID { get; set; }
        public int ProductCPUID { get; set; }
        public string CPUManufacturer { get; set; }
        public string Lineup { get; set; }
        public string DeliveryType { get; set; }
        public string CoolingIncluded { get; set; }
        public string CrystalCodeName { get; set; }
        public string Socket { get; set; }
        public string Cores { get; set; }
        public string MaxNumberThreads { get; set; }
        public string BaseClockFrequency { get; set; }
        public string MaxClockFrequency { get; set; }
        public string MemorySupport { get; set; }
        public string MaxMemoryFrequency { get; set; }
        public string IntegratedPCIExpressController { get; set; }
        public string TDP { get; set; }
        public string KernelMultithreading { get; set; }
    
        public virtual Product Product { get; set; }
    }
}