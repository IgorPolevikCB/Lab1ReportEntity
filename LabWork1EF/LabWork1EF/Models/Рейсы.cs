//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabWork1EF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Рейсы
    {
        public int Код_рейса { get; set; }
        public System.TimeSpan Время_отправления { get; set; }
        public System.TimeSpan Время_прибытия { get; set; }
        public string Маршрут { get; set; }
        public string Автобус { get; set; }
        public decimal Цена { get; set; }
        public int РасстояниеКМ { get; set; }
        public int Код_маршрута { get; set; }
        public int Код_автобуса { get; set; }
    }
}
