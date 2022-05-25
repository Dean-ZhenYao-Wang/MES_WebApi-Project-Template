namespace MES.CoreComponents
{
    /// <summary>
    /// 用于需要数过的非货币单位的任何元素
    /// </summary>
    public struct QuantityType
    {
        public decimal 值 { get; set; }

        public QuantityType(decimal 值, string 单位代码 = null, string 单位代码ID列表 = null, string 单位代码机构ID列表 = null, string 单位代码机构名称列表 = null) : this()
        {
            this.值 = 值;
            this.单位代码 = 单位代码;
            this.单位代码ID列表 = 单位代码ID列表;
            this.单位代码机构ID列表 = 单位代码机构ID列表;
            this.单位代码机构名称列表 = 单位代码机构名称列表;
        }

        public string 单位代码 { get; set; }
        public string 单位代码ID列表 { get; set; }
        public string 单位代码机构ID列表 { get; set; }
        public string 单位代码机构名称列表 { get; set; }
    }
}
