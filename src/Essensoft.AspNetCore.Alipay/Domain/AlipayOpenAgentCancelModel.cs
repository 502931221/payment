using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAgentCancelModel Data Structure.
    /// </summary>
    public class AlipayOpenAgentCancelModel : AlipayObject
    {
        /// <summary>
        /// ISV 代商户操作事务编号，通过事务开启接口alipay.open.agent.create调用返回。
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }
    }
}