//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventr
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room_furniture
    {
        public int Id_room_furniture { get; set; }
        public int Number_room { get; set; }
        public int FK_id_furniture { get; set; }
    
        public virtual Furniture Furniture { get; set; }
    }
}
