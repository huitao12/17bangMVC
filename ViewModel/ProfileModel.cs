using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17bangMVC.Models
{
    public class ProfileModel
    {
        //年份
        public IList<BirthYear> BirthYears { get; set; }
        //月份
        public int? BirthMonth { get; set; }
        //星座
        public IList<Constellation> Constellations { get; set; }
        //一级
        public string StairKeyword { get; set; }
        //二级
        public string SecondKeyword { get; set; }
        //性别
        public bool? IsMale { get; set; }
    }
    public class Constellation
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
    public class BirthYear
    {
        public int Id { get; set; }
        public int Year { get; set; }
    }
}