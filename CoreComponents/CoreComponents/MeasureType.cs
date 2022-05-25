namespace MES.CoreComponents
{
    /// <summary>
    /// 用于任何需要带有度量单位的数值的元素
    /// </summary>
    public struct MeasureType
    {
        public decimal 值 { get; set; }

        public MeasureType(decimal 值, string 单位 = null, string 单位代码列表版本ID = null) : this()
        {
            this.值 = 值;
            this.单位 = 单位;
            this.单位代码列表版本ID = 单位代码列表版本ID;
        }

        public string 单位 { get; set; }
        public string 单位代码列表版本ID { get; set; }
    }
}
