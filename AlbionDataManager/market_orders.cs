//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlbionDataManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class market_orders
    {
        public long albion_id { get; set; }
        public string item_id { get; set; }
        public Nullable<sbyte> quality_level { get; set; }
        public Nullable<sbyte> enchantment_level { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<int> initial_amount { get; set; }
        public Nullable<int> amount { get; set; }
        public string auction_type { get; set; }
        public Nullable<System.DateTime> expires { get; set; }
        public int location { get; set; }
        public long id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
    }
}