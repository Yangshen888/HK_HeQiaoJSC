//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarAccident
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public System.Guid CarAccidentUuid { get; set; }
        public string AccidentTime { get; set; }
        public string AccidentPlace { get; set; }
        public string CarNum { get; set; }
        public string Name { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string AddTime { get; set; }
        public string AddPeople { get; set; }
        public Nullable<System.Guid> SchoolDistrictUuid { get; set; }
    }
}
